using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace example
{

    public partial class Pantalla_Inicio : Form
    {
        public Pantalla_Inicio()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        private void gartic()
        {


        }

        private void Siguiente(object sender, EventArgs e)
        {
            Menu Menu_Opciones = new Menu();
            Menu_Opciones.FormClosed += Menu_cerrado;

            this.Hide();
            Menu_Opciones.Show();

        }

        private void Menu_cerrado(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
