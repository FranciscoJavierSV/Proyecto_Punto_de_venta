using BaseDatos;
using Punto_de_Venta;
using Punto_de_Venta.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace example
{
    public partial class Usuario : Form
    {
        private DatabaseProductos dbConnection;
        private List<GroupBox> groupBoxList = new List<GroupBox>();
        private Carrito carrito;
        public SoundPlayer player2;


        public Usuario(string usuarioIngresado)
        {
            carrito = new Carrito(usuarioIngresado);  // Instancia del carrito
            InitializeComponent();
            var stream = new MemoryStream(Resources.Awakening); //convierte archivo wav de byte a stream
            player2 = new SoundPlayer(stream);
            dbConnection = new DatabaseProductos();
            groupBoxList.Add(GArticulo1);
            groupBoxList.Add(GArticulo2);
            groupBoxList.Add(GArticulo3);
            groupBoxList.Add(GArticulo4);
            groupBoxList.Add(GArticulo5);
            groupBoxList.Add(GArticulo6);
            groupBoxList.Add(GArticulo7);
            groupBoxList.Add(GArticulo8);
            groupBoxList.Add(GArticulo9);
            groupBoxList.Add(GArticulo10);
            CargarProductos();  // Llamamos al método para cargar los productos al iniciar
            Hora.Enabled = true;
            GPanel.Text = usuarioIngresado;
        }

        private void Salir_Usuario(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            LTiempo.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void CargarProductos()
        {
            DataTable dt = dbConnection.VerRegistros();
            int groupBoxIndex = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (groupBoxIndex >= 10) break;  // Solo mostramos hasta 10 productos

                GroupBox groupBox = groupBoxList[groupBoxIndex];

                if (groupBox != null)
                {
                    // Asignar el nombre del producto al título del GroupBox
                    groupBox.Text = row["Nombre"].ToString();

                    // Cargar la imagen en el PictureBox dentro del GroupBox
                    PictureBox pictureBox = groupBox.Controls["PArticulo" + (groupBoxIndex + 1)] as PictureBox;
                    if (pictureBox != null)
                    {
                        string imageName = row["Imagen"].ToString();
                        pictureBox.Image = CargarImagenDesdeCarpeta(imageName);  // Método para cargar la imagen desde una carpeta
                    }

                    // Asignar la descripción al Label dentro del GroupBox
                    Label labelDescripcion = groupBox.Controls["LArticulo" + (groupBoxIndex + 1)] as Label;
                    if (labelDescripcion != null)
                    {
                        labelDescripcion.Text = row["Descripcion"].ToString();
                    }

                    // Encontrar el Panel PPreciox dentro del GroupBox
                    Panel panel = groupBox.Controls["PPrecio" + (groupBoxIndex + 1)] as Panel;
                    if (panel != null)
                    {
                        // Asignar el precio al TextBox correspondiente dentro del Panel
                        TextBox textBoxPrecio = panel.Controls["TPrecio" + (groupBoxIndex + 1)] as TextBox;
                        if (textBoxPrecio != null)
                        {
                            string mesaje = "Precio: ";
                            textBoxPrecio.Text = mesaje + row["Precio"].ToString();
                        }

                        // Asignar las existencias al TextBox correspondiente dentro del Panel
                        TextBox textBoxCantidad = panel.Controls["TCantidad" + (groupBoxIndex + 1)] as TextBox;
                        if (textBoxCantidad != null)
                        {
                            string mesaje2 = "Existencias: ";
                            textBoxCantidad.Text = mesaje2 + row["Existencias"].ToString();
                        }
                    }

                    // Asignar el evento de clic al botón "Añadir"
                    Button buttonAñadir = groupBox.Controls["BAnadir" + (groupBoxIndex + 1)] as Button;
                    if (buttonAñadir != null)
                    {
                        buttonAñadir.Click += Clic_Aceptar;
                    }
                }

                groupBoxIndex++;
            }

            // Deshabilitar los GroupBox que no se utilizaron
            for (int i = groupBoxIndex; i < 10; i++)
            {
                GroupBox groupBox = groupBoxList[i];
                if (groupBox != null)
                {
                    groupBox.Visible = false;  // Ocultar los GroupBox no utilizados
                }
            }
        }

        private void BCompra_clic(object sender, EventArgs e)
        {
            if (carrito.ObtenerArticulos().Count > 0)
            {
                // Crear una instancia del formulario de destino y pasarle el carrito como parámetro
                FCompra formCompra = new FCompra(carrito);
                formCompra.FormClosed += Menu_cerrado;
                formCompra.Show();
            }
            else
            {
                MessageBox.Show("El carrito está vacío. Añade al menos un artículo antes de continuar.");
            }
        }

        private void Menu_cerrado(object sender, FormClosedEventArgs e)
        {
            var formCompra = sender as FCompra;
            if (formCompra != null && formCompra.OperacionCompletada)
            {
                RTotal.Text = string.Empty;
                RTotalMImp.Text = string.Empty;
            }
            CargarProductos();
        }


        private void Clic_Aceptar(object sender, EventArgs e)
        {
            // Determinar el botón presionado
            Button button = sender as Button;

            if (button != null)
            {
                // Obtener el número del artículo desde el nombre del botón
                string buttonName = button.Name;
                int articleNumber = int.Parse(buttonName.Replace("BAnadir", ""));

                // Obtener el NumericUpDown correspondiente
                NumericUpDown numericUpDownCantidad = Controls.Find("NArt" + articleNumber, true).FirstOrDefault() as NumericUpDown;

                if (numericUpDownCantidad != null && numericUpDownCantidad.Value > 0)
                {
                    // Obtener la fila de datos correspondiente
                    DataRow row = dbConnection.VerRegistros().Rows[articleNumber - 1];

                    try
                    {
                        // Llamar a la función de añadir al carrito
                        carrito.AñadirArticulo(new ArticuloCarrito
                        {
                            ID = Convert.ToInt32(row["ID"]),
                            Nombre = row["Nombre"].ToString(),
                            Cantidad = (int)numericUpDownCantidad.Value,
                            Precio = Convert.ToDecimal(row["Precio"])
                        }, Convert.ToInt32(row["Existencias"]));

                        MessageBox.Show($"Añadido {numericUpDownCantidad.Value} de {row["Nombre"]} al carrito.");
                        ActualizarTotal();  // Llamar a la función para actualizar el total
                        ActualizarTotalConImpuestos();
                        numericUpDownCantidad.Value = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una cantidad mayor a 0.");
                }
            }
        }

        private void ActualizarTotal()
        {
            decimal sumaTotal = carrito.ObtenerTotal();
            RTotal.Text = $"Total: {sumaTotal:C}";  // Actualizar el RichTextBox con el sub total
        }
        private void ActualizarTotalConImpuestos()
        {
            decimal sumaTotal = carrito.ObtenerTotal();
            RTotalMImp.Text = $"Total: {sumaTotal*1.06m:C}";  // Actualizar el RichTextBox con el total
        }


        private Image CargarImagenDesdeCarpeta(string imageName)
        {
            try
            {
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "ImageArt", imageName);
                if (File.Exists(imagePath))
                {
                    return Image.FromFile(imagePath);  // Cargar la imagen desde la carpeta
                }
                else
                {
                    // Si no existe, retornar una imagen por defecto
                    return Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "ImageArt", "ImagenPorDefecto.png"));
                }
            }
            catch
            {
                // Si ocurre un error al cargar la imagen, retornar una imagen por defecto
                return Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "ImageArt", "ImagenPorDefecto.png"));
            }
        }

        private void BCarrito_Clic(object sender, EventArgs e)
        {
            Consulta_Carrito formCarrito = new Consulta_Carrito(carrito);
            if (formCarrito.ShowDialog() == DialogResult.OK || formCarrito.DialogResult == DialogResult.Cancel)
            {
                ActualizarTotal(); // Actualizar el total después de cerrar el carrito
                ActualizarTotalConImpuestos();
            }


        }

        private void TLArticulos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BMusic_Play_Click(object sender, EventArgs e)
        {
            try
            {
                player2.Play();
                player2.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reproducir: {ex.Message}");
            }
        }

        private void BMusic_Stop_Click(object sender, EventArgs e)
        {
            if (player2 != null)
            {
                try
                {
                    player2.Stop(); // Detener el audio
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al detener: {ex.Message}");
                }

            }
        }

        private void RTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void GPanel_Enter(object sender, EventArgs e)
        {

        }
    }
}