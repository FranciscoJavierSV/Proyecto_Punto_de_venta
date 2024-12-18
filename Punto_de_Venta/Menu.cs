using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Media;
using System.Resources;
using System.Windows.Forms.PropertyGridInternal;
using Punto_de_Venta.Properties;
using System.Numerics;
namespace example
{
    public partial class Menu : Form
    {
        public SoundPlayer player2;
        public Menu()
        {
            InitializeComponent();
            Hora.Enabled = true;
            var stream = new MemoryStream(Resources.Awakening); //convierte archivo wav de byte a stream
            player2 = new SoundPlayer(stream);
            Hora.Enabled = true;
        }

        private void Salir_Inicio(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clic(object sender, EventArgs e)
        {
            //Llamo al metodo
            acceso();
        }

        /// <summary>
        /// Javier
        /// Este metodo obtiene los datos de la base de datos de usuarios y comprueba que lo ingresado este dentro de ella
        /// </summary>
        private void acceso()
        {

            try
            {
                // Variables con los valores a comprobar
                string usuarioIngresado = TUser.Text; // Usuario ingresado
                string contrasenaIngresada = TPassword.Text; // Contraseña ingresada

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
                    if (usuarioIngresado == "Admin")
                    {
                        Admin Menu_Admin = new Admin();
                        MessageBox.Show("¡Bienvenido! " + usuarioIngresado);
                        Menu_Admin.Show();
                        this.Hide();
                        Menu_Admin.FormClosed += Menu_cerrado;
                    }
                    else
                    {
                        Usuario Menu_Usuario = new Usuario(usuarioIngresado);
                        MessageBox.Show("¡Bienvenido! " + usuarioIngresado);
                        Menu_Usuario.Show();
                        this.Hide();
                        Menu_Usuario.FormClosed += Menu_cerrado;
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje si hay un error al conectar
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Esto hace aparecer de nuevo el meno de ingreso
        /// javi
        /// </summary>
        /// <param name="e"></param>

        private void Menu_cerrado(object sender, FormClosedEventArgs e)
        {
            this.Show();
            TUser.Text = "";
            TPassword.Text = "";
        }


        private void buttonPlay_Click(object sender, EventArgs e)
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

        private void buttonStop_Click(object sender, EventArgs e)
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

        private void Hora_Tick(object sender, EventArgs e)
        {
            LTiempo.Text = DateTime.Now.ToString("hh:mm:ss");
        }

    }
}
