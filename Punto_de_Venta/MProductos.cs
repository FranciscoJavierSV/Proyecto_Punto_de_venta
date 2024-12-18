using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace BaseDatos
{
    public partial class MProductos : Form
    {
        private DatabaseProductos dbConnection;
        private string currentAction;
        private string selectedImagePath;


        public MProductos()
        {
            InitializeComponent();
            dbConnection = new DatabaseProductos();
            HabilitarCampos(false);
            TId.Enabled = false;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            LimpiarCampos();
            currentAction = "Agregar";
            Console.WriteLine("Acción seleccionada: Agregar");
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            LimpiarCampos();
            currentAction = "Eliminar";
            Console.WriteLine("Acción seleccionada: Eliminar");
        }

        private void BImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Guardar la ruta completa de la imagen seleccionada
                    selectedImagePath = openFileDialog.FileName;

                    // Guardar solo el nombre del archivo en el campo TImagen
                    TImagen.Text = Path.GetFileName(selectedImagePath);
                }
            }
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            LimpiarCampos();
            currentAction = "Modificar";
            Console.WriteLine("Acción seleccionada: Modificar");
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            LimpiarCampos();
            currentAction = "Buscar";
            Console.WriteLine("Acción seleccionada: Buscar");
        }

        private void BVerRegistro_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            TId.Enabled = false;
            VerRegistros();
        }

        private void BConfirmar_Click(object sender, EventArgs e)
        {
            if (currentAction == "Agregar")
            {
                if (!CamposLlenos())
                {
                    MessageBox.Show("Por favor, llena todos los campos.");
                    return;
                }
            }

            if (currentAction == "Agregar" || currentAction == "Modificar")
            {
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    // Define el directorio de destino correcto para las imágenes de los productos
                    string destinationDirectory = Path.Combine(Application.StartupPath, "Resources", "ImageArt");
                    if (!Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }

                    string destinationFilePath = Path.Combine(destinationDirectory, Path.GetFileName(selectedImagePath));
                    File.Copy(selectedImagePath, destinationFilePath, true);

                    // Actualizar TImagen con el nombre del archivo copiado
                    TImagen.Text = Path.GetFileName(destinationFilePath);
                }
            }

            switch (currentAction)
            {
                case "Agregar":
                    AgregarProducto();
                    break;

                case "Eliminar":
                    EliminarProducto();
                    break;

                case "Modificar":
                    ModificarProducto();
                    break;

                case "Buscar":
                    BuscarRegistro();
                    break;

                default:
                    MessageBox.Show("No hay acción seleccionada.");
                    break;
            }
            LimpiarCampos();
        }

        private void ModificarProducto()
        {
            if (!string.IsNullOrEmpty(TId.Text))
            {
                int id = Convert.ToInt32(TId.Text);
                string nombre = !string.IsNullOrEmpty(TNombre.Text) ? TNombre.Text : null;
                double? precio = !string.IsNullOrEmpty(TPrecio.Text) ? (double?)Convert.ToDouble(TPrecio.Text) : null;
                int? existencias = !string.IsNullOrEmpty(TExistencias.Text) ? (int?)Convert.ToInt32(TExistencias.Text) : null;
                string descripcion = !string.IsNullOrEmpty(TDescripcion.Text) ? TDescripcion.Text : null;
                string imagen = !string.IsNullOrEmpty(TImagen.Text) ? TImagen.Text : null;

                bool success = dbConnection.ModificarProducto(id, nombre, precio, existencias, descripcion, imagen);

                if (success)
                {
                    MessageBox.Show("Producto modificado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al modificar el producto. Inténtalo nuevamente.");
                }

                // Llamar al método para ordenar los productos por existencias en orden descendente
                dbConnection.OrdenarPorExistenciasDescendente();

            }
            else
            {
                MessageBox.Show("Por favor, ingresa el ID.");
            }
            LimpiarCampos();
        }


        private void AgregarProducto()
        {
            // Verificar la cantidad actual de productos
            int cantidadActual = dbConnection.ObtenerCantidadProductos();

            if (cantidadActual >= 10)
            {
                MessageBox.Show("No puedes agregar más de 10 productos.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No permitir agregar más
            }

            if (CamposLlenos())
            {
                bool success = dbConnection.AgregarProducto(
                    Convert.ToInt32(TId.Text),
                    TNombre.Text,
                    Convert.ToDouble(TPrecio.Text),
                    Convert.ToInt32(TExistencias.Text),
                    TDescripcion.Text,
                    TImagen.Text);

                if (success)
                {
                    MessageBox.Show("Producto agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto. Inténtalo nuevamente.");
                }

                // Llamar al método para ordenar los productos por existencias en orden descendente
                dbConnection.OrdenarPorExistenciasDescendente();
            }
            else
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }

            LimpiarCampos();
        }


        private void EliminarProducto()
        {
            if (string.IsNullOrEmpty(TId.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del producto a eliminar.");
                return;
            }

            // Verificar la cantidad actual de productos
            int cantidadActual = dbConnection.ObtenerCantidadProductos();

            if (cantidadActual <= 6)
            {
                MessageBox.Show("No puedes tener menos de 6 productos en la base de datos.", "Límite mínimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No permitir eliminar más
            }

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool success = dbConnection.EliminarProducto(Convert.ToInt32(TId.Text));
                if (success)
                {
                    MessageBox.Show("Producto eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto. Inténtalo nuevamente.");
                }

                // Llamar al método para ordenar los productos por existencias en orden descendente
                dbConnection.OrdenarPorExistenciasDescendente();
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }

            LimpiarCampos();
        }


        private bool CamposLlenos()
        {
            return !string.IsNullOrEmpty(TId.Text) && !string.IsNullOrEmpty(TNombre.Text) &&
                    !string.IsNullOrEmpty(TExistencias.Text) && !string.IsNullOrEmpty(TPrecio.Text) &&
                    !string.IsNullOrEmpty(TDescripcion.Text) && !string.IsNullOrEmpty(TImagen.Text);
        }

        private void LimpiarCampos()
        {
            TId.Clear();
            TNombre.Clear();
            TExistencias.Clear();
            TPrecio.Clear();
            TDescripcion.Clear();
            TImagen.Clear();
        }

        private void HabilitarCampos(bool enable)
        {
            TId.Enabled = true; // Siempre habilitar ID
            TNombre.Enabled = enable;
            TExistencias.Enabled = enable;
            TPrecio.Enabled = enable;
            TDescripcion.Enabled = enable;
            TImagen.Enabled = enable;
        }

        public void VerRegistros()
        {
            DataTable dt = dbConnection.VerRegistros();
            TablaDatos.Rows.Clear(); // Limpiar DataGridView antes de llenarlo

            foreach (DataRow row in dt.Rows)
            {
                TablaDatos.Rows.Add(row["ID"], row["Nombre"], row["Precio"], row["Existencias"], row["Descripcion"], row["Imagen"]);
            }
        }

        public void BuscarRegistro()
        {
            if (string.IsNullOrEmpty(TId.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID para buscar.");
                return;
            }

            DataTable dt = dbConnection.BuscarRegistro(Convert.ToInt32(TId.Text));
            TablaDatos.Rows.Clear(); // Limpiar DataGridView antes de llenarlo

            foreach (DataRow row in dt.Rows)
            {
                TablaDatos.Rows.Add(row["ID"], row["Nombre"], row["Precio"], row["Existencias"], row["Descripcion"], row["Imagen"]);
            }

            MessageBox.Show(dt.Rows.Count > 0 ? "Ítem encontrado." : "Ítem no encontrado.");
        }

        private void B_Salir(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}