using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
public partial class Consulta_Carrito : Form
{
    private Carrito carrito;
    private List<TextBox> articuloTextBoxes = new List<TextBox>();
    private List<TextBox> cantidadTextBoxes = new List<TextBox>();
    private List<Button> eliminarButtons = new List<Button>();

    public Consulta_Carrito(Carrito carrito)
    {
        this.carrito = carrito;
        InitializeComponent();  // Llama al método InitializeComponent definido en el Designer
        InicializarListas();    // Inicializa las listas de controles
        CargarCarrito();        // Carga los datos del carrito
    }


        private void InicializarListas()
        {
            for (int i = 0; i < 10; i++)
            {
                TextBox txtArticulo = this.Controls.Find("TArticulo" + (i + 1), true).FirstOrDefault() as TextBox;
                if (txtArticulo != null)
                {
                    articuloTextBoxes.Add(txtArticulo);
                }

                TextBox txtCantidad = this.Controls.Find("TCantidad" + (i + 1), true).FirstOrDefault() as TextBox;
                if (txtCantidad != null)
                {
                    cantidadTextBoxes.Add(txtCantidad);
                }

                Button btnEliminar = this.Controls.Find("BEliminar" + (i + 1), true).FirstOrDefault() as Button;
                if (btnEliminar != null)
                {
                    btnEliminar.Click -= BtnEliminar_Click; // Eliminar cualquier asignación previa
                    btnEliminar.Click += BtnEliminar_Click; // Asignar el evento Click
                    eliminarButtons.Add(btnEliminar);
                }
            }

            Button btnSalir = this.Controls.Find("btnSalir", true).FirstOrDefault() as Button;
            if (btnSalir != null)
            {
                btnSalir.Click += BtnSalir_Click;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                int buttonIndex = eliminarButtons.IndexOf(button);

                if (buttonIndex >= 0 && buttonIndex < carrito.ObtenerArticulos().Count)
                {
                    carrito.ObtenerArticulos().RemoveAt(buttonIndex);

                    // Mostrar el índice para depuración
                 

                    CargarCarrito();  // Actualizar la visibilidad después de eliminar
                }
                else
                {
                    MessageBox.Show("El índice está fuera del rango de los artículos.");
                }
            }
        }


        private void CargarCarrito()
        {
            var articulos = carrito.ObtenerArticulos();
            for (int i = 0; i < 10; i++)
            {
                if (i < articulos.Count)
                {
                    // Actualiza los controles para mostrar el artículo
                    articuloTextBoxes[i].Text = articulos[i].Nombre;
                    cantidadTextBoxes[i].Text = articulos[i].Cantidad.ToString();
                    articuloTextBoxes[i].Visible = true;
                    cantidadTextBoxes[i].Visible = true;
                    eliminarButtons[i].Visible = true;
                }
                else
                {
                    // Oculta los controles si no hay artículo en esa posición
                    articuloTextBoxes[i].Visible = false;
                    cantidadTextBoxes[i].Visible = false;
                    eliminarButtons[i].Visible = false;
                }
            }
        } 

        private void BtnSalir_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
}