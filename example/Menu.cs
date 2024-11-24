using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void Salir_Inicio(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password(object sender, EventArgs e)
        {

        }

        private void clic(object sender, EventArgs e)
        {
            try
            {
                // Variables con los valores a comprobar
                string usuarioIngresado = txt1.Text; // Usuario ingresado
                string contrasenaIngresada = txt2.Text; // Contraseña ingresada

                // Crear instancia de la clase DatabaseHelper
                DatabaseHelper db = new DatabaseHelper();

                // Obtener los datos de la tabla
                DataTable usuarios = db.GetUsuarios(); // Método que devuelve los datos de la tabla

                // Revisar si el usuario existe
                bool usuarioExiste = usuarios.AsEnumerable().Any(row =>
                    row["Usuario"].ToString() == usuarioIngresado);

                // Revisar si la contraseña existe
                bool contraseñaExiste = usuarios.AsEnumerable().Any(row =>
                    row["Contraseña"].ToString() == contrasenaIngresada);

                // Mensajes condicionales
                if (!usuarioExiste && !contraseñaExiste)
                {
                    MessageBox.Show("El usuario y la contraseña son incorrectos.");
                }
                else if (!usuarioExiste)
                {
                    MessageBox.Show("El usuario ingresado es incorrecto.");
                }
                else if (!contraseñaExiste)
                {
                    MessageBox.Show("La contraseña ingresada es incorrecta.");
                }
                else
                {
                    if (usuarioIngresado=="Admin")
                    {
                        Admin Menu_Admin = new Admin();
                        Menu_Admin.FormClosed += Menu_cerrado;
                        this.Hide();
                        Menu_Admin.Show();
                    }
                    else
                    {
                        Usuario Menu_Usuario = new Usuario();
                        Menu_Usuario.FormClosed += Menu_cerrado;
                        this.Hide();
                        Menu_Usuario.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje si hay un error al conectar
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
            }
        }




        private void Menu_cerrado(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
