using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BaseDatos;
using System.Drawing.Printing;
using System.Reflection.Metadata;

// Creacion de archivo PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Punto_de_Venta
{
    public partial class FCompra : Form
    {
        private Carrito carrito;
        private DatabaseProductos dbConnection; // Instancia para la conexión a la base de datos de productos
        private DatabaseVentas dbVentas; // Instancia para la conexión a la base de datos de ventas

        public FCompra(Carrito carrito)
        {
            this.carrito = carrito;
            dbConnection = new DatabaseProductos();
            dbVentas = new DatabaseVentas();
            InitializeComponent();
            CargarArticulos();
            MostrarTotal();
        }

        private void CargarArticulos()
        {
            DArticulos.DataSource = carrito.ObtenerArticulos().Select(a => new
            {
                a.Nombre,
                a.Cantidad,
                PrecioUnitario = a.Precio,
                Total = a.Precio * a.Cantidad
            }).ToList();
        }

        private void MostrarTotal()
        {
            decimal total = carrito.ObtenerTotal();
            TTotal.Text = total.ToString("C");
        }
        public decimal ObtenerImpuesto()
        {
            decimal impuesto = carrito.ObtenerTotal() * 0.06m;
            return impuesto;
        }
        public decimal ObtenerTotalConImpuesto()
        {
            decimal totalMasImpuesto = ObtenerImpuesto() + carrito.ObtenerTotal();
            return totalMasImpuesto;
        }

        private void BPagar_Click(object sender, EventArgs e)
        {
            if (carrito.ObtenerArticulos().Count > 0)
            {
                decimal total = carrito.ObtenerTotal();
                if (decimal.TryParse(TPago.Text, out decimal pagado) && pagado >= total)
                {
                    decimal cambio = pagado - total;

                    ActualizarExistencias();
                    RegistrarVenta();
                    MessageBox.Show($"Compra registrada exitosamente.\nCambio: {cambio:C}\nGenerando ticket...");

                    SaveFileDialog guardar = new SaveFileDialog();
                    guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                    guardar.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                    guardar.Title = "Guardar ticket como PDF";

                    // Cargar el contenido de la plantilla HTML desde recursos
                    string paginahtml_texto = Properties.Resources.plantilla.ToString();

                    // Generar las filas para la tabla de artículos
                    string filas = "";
                    foreach (var articulo in carrito.ObtenerArticulos())
                    {
                        filas += $"<tr><td>{articulo.Cantidad}</td><td>{articulo.Nombre}</td><td>{articulo.Precio:C}</td><td>{(articulo.Precio * articulo.Cantidad):C}</td></tr>";
                    }
                    paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);
                    string subtotal = carrito.ObtenerTotal().ToString("C");
                    string impuesto = ObtenerImpuesto().ToString("C");
                    string total1 = ObtenerTotalConImpuesto().ToString("C");

                    paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                    paginahtml_texto = paginahtml_texto.Replace("@SUBTOTAL", subtotal);
                    paginahtml_texto = paginahtml_texto.Replace("@IMPUESTO", impuesto);
                    paginahtml_texto = paginahtml_texto.Replace("@TOTAL", total1);

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 25, 25, 25, 25);
                                PdfWriter pdfw = PdfWriter.GetInstance(document, stream);
                                document.Open();

                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LOGOfragannis, System.Drawing.Imaging.ImageFormat.Png);
                                img.ScaleToFit(80, 80);
                                img.Alignment = iTextSharp.text.Image.UNDERLYING;
                                img.SetAbsolutePosition(document.LeftMargin, document.Top - 60);
                                document.Add(img);
                                using (StringReader sr = new StringReader(paginaHtml_texto))
                                    {
                                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfw, document, sr);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error al procesar el HTML: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                                        document.Add(new Paragraph("Error al procesar el HTML"));
                                    }
                                }
                                document.Close();
                            }
                            // Abrir el PDF automáticamente
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = guardar.FileName, UseShellExecute = true });

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al generar el PDF: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                        }
                    }
                    carrito.ObtenerArticulos().Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El monto pagado debe ser igual o mayor al total de la compra.");
                }
            }
            else
            {
                MessageBox.Show("El carrito está vacío. No se puede realizar la compra.");
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarExistencias()
        {
            try
            {
                foreach (var articulo in carrito.ObtenerArticulos())
                {
                    dbConnection.RestarExistencias(articulo.ID, articulo.Cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar existencias: {ex.Message}");
            }
        }

        private void RegistrarVenta()
        {
            try
            {
                string articulos = string.Join(", ", carrito.ObtenerArticulos().Select(a => $"{a.Nombre} (x{a.Cantidad})"));
                dbVentas.InsertarVenta(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:mm:ss"), carrito.ObtenerUsuario(), articulos, carrito.ObtenerTotal());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
        }
    }
}