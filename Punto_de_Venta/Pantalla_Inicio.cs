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

namespace example
{

    public partial class Pantalla_Inicio : Form
    {
        public SoundPlayer player;
        private int lastWidth, lastHeight, lastLeft, lastTop;

        public Pantalla_Inicio()
        {
            InitializeComponent();
            var stream = new MemoryStream(Resources.Awakening); //convierte archivo wav de byte a stream
            player = new SoundPlayer(stream);
            Hora.Enabled = true;


        }
        //Variables para las funciones de MouseDown
        //Sirve para arrastrar la ventana 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


         //Función para usar el tamaño que tiene el ultimo form
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Solo guardamos el tamaño cuando no está maximizado
            if (WindowState != FormWindowState.Maximized)
            {
                lastWidth = this.Width;
                lastHeight = this.Height;
                lastLeft = this.Left;
                lastTop = this.Top;
            }
        }

        private void Siguiente(object sender, EventArgs e)
        {
            Menu Menu_Opciones = new Menu();
            Menu_Opciones.FormClosed += Menu_cerrado;
            this.Hide();
            
            Menu_Opciones.StartPosition = FormStartPosition.Manual;
            Menu_Opciones.Left = lastLeft;
            Menu_Opciones.Top = lastTop;
            Menu_Opciones.Width = lastWidth;
            Menu_Opciones.Height = lastHeight;
            Menu_Opciones.Show();

        }

        private void Menu_cerrado(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LTiempo.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonminim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Maximizar la ventana o regresarla a tamaño por defecto dependiendo como esté
        private void buttonmaxim_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
        //MouseDown es para poder arrastrar o mover el form por toda la pantalla
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_Pantalla_Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                player.Play();
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reproducir: {ex.Message}");
            }

        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                try
                {
                    player.Stop(); // Detener el audio
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al detener: {ex.Message}");
                }

            }

        }
    }
}
