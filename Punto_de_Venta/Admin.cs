using BaseDatos;
using Punto_de_Venta;
using Punto_de_Venta.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace example
{
    public partial class Admin : Form
    {
        private DatabaseProductos dbConnection;
        private List<GroupBox> groupBoxList = new List<GroupBox>();
        public SoundPlayer player2;

        public Admin()
        {
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
            CargarProductos(); // Llamamos al método para cargar los productos al iniciar
            Hora.Enabled = true;
        }

        private void Menu_cerrado(object sender, FormClosedEventArgs e)
        {
            this.Show();
            CargarProductos();
        }

        private void Salir_Usuario(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mod_Articulos(object sender, EventArgs e)
        {
            MProductos Modificar = new MProductos();
            this.Hide();
            Modificar.Show();
            Modificar.FormClosed += Menu_cerrado;
        }

        private void Estadistica(object sender, EventArgs e)
        {
            FEstadistica Estadistica = new FEstadistica();
            this.Hide();
            Estadistica.Show();
            Estadistica.FormClosed += Menu_cerrado;
        }

        private void CargarProductos()
        {
            // Obtener los productos desde la base de datos
            DataTable dt = dbConnection.VerRegistros();

            // Índice para recorrer los GroupBox
            int groupBoxIndex = 0;

            // Recorrer los productos obtenidos desde la base de datos
            foreach (DataRow row in dt.Rows)
            {
                if (groupBoxIndex >= 10) break; // Solo mostramos hasta 10 productos

                // Acceder al GroupBox desde la lista por índice
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
                        pictureBox.Image = CargarImagenDesdeCarpeta(imageName); // Método para cargar la imagen desde una carpeta

                    }

                    // Asignar la descripción al Label dentro del GroupBox
                    Label labelDescripcion = groupBox.Controls["LArticulo" + (groupBoxIndex + 1)] as Label;
                    if (labelDescripcion != null)
                    {
                        labelDescripcion.Text = row["Descripcion"].ToString();
                    }
                }

                groupBoxIndex++; // Incrementamos el índice para el siguiente GroupBox
            }

            // Deshabilitar los GroupBox que no se utilizaron
            for (int i = groupBoxIndex; i < 10; i++)
            {
                GroupBox groupBox = groupBoxList[i];
                if (groupBox != null)
                {
                    groupBox.Visible = false; // Ocultar los GroupBox no utilizados
                }
            }
        }

        private Image CargarImagenDesdeCarpeta(string imageName)
        {
            try
            {
                // Establecemos la ruta de la carpeta donde se encuentran las imágenes
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "ImageArt", imageName);

                // Verificamos si el archivo de imagen existe
                if (File.Exists(imagePath))
                {
                    return Image.FromFile(imagePath); // Cargar la imagen desde la carpeta
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

        private void Hora_Tick(object sender, EventArgs e)
        {
            LTiempo.Text = DateTime.Now.ToString("hh:mm:ss");
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
    }
}
