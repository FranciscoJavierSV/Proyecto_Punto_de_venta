using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BaseDatos;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Punto_de_Venta
{
    public partial class FCompra : Form
    {
        private Carrito carrito;
        private DatabaseProductos dbConnection; // Instancia para la conexión a la base de datos de productos
        private DatabaseVentas dbVentas; // Instancia para la conexión a la base de datos de ventas
        public bool OperacionCompletada { get; private set; } = false;

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

                    // Crear PDF usando PdfSharp
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            GenerarPDF(guardar.FileName);
                            MessageBox.Show("PDF generado exitosamente.");
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = guardar.FileName, UseShellExecute = true });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al generar el PDF: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                        }
                    }
                    carrito.ObtenerArticulos().Clear();
                    OperacionCompletada = true;
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

        private void GenerarPDF(string filePath)
        {
            // Crear un nuevo documento PDF
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Ticket de Compra";

            // Crear una nueva página
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Fuente y estilo
            XFont font = new XFont("Verdana", 12);
            XFont fontBold = new XFont("Verdana", 12);

            // Dibujar el logo desde recursos
            using (MemoryStream logoStream = new MemoryStream())
            {
                Properties.Resources.LOGOfragannis.Save(logoStream, System.Drawing.Imaging.ImageFormat.Png);
                logoStream.Position = 0; // Reiniciar la posición del stream
                XImage image = XImage.FromStream(logoStream);
                double logoXPosition = (page.Width.Point - 150) / 2; // Centrar el logo
                gfx.DrawImage(image, logoXPosition, 30, 150, 75);
            }

            // Información de la empresa
            double infoYPosition = 120;
            double infoXPosition = 30;
            gfx.DrawString("FRAGANNIS", fontBold, XBrushes.Black, new XRect(infoXPosition, infoYPosition, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            infoYPosition += 20;
            gfx.DrawString("Direccion: Av. Universidad 940, Ciudad Universitaria 20100, Aguascalientes, Ags", font, XBrushes.Black, new XRect(infoXPosition, infoYPosition, page.Width.Point - infoXPosition, page.Height.Point), XStringFormats.TopLeft);
            infoYPosition += 20;
            gfx.DrawString("Telefono: 449-910-7400", font, XBrushes.Black, new XRect(infoXPosition, infoYPosition, page.Width.Point - infoXPosition, page.Height.Point), XStringFormats.TopLeft);

            // Información de compra
            gfx.DrawString("Folio: 00000111", fontBold, XBrushes.Black, new XRect(30, 180, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), font, XBrushes.Black, new XRect(30, 200, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            // Tabla de artículos
            gfx.DrawString("Cant.", fontBold, XBrushes.Black, new XRect(30, 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("Descripcion", fontBold, XBrushes.Black, new XRect(100, 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("P. Unitario", fontBold, XBrushes.Black, new XRect(300, 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("Importe", fontBold, XBrushes.Black, new XRect(400, 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            int yPoint = 260;

            foreach (var articulo in carrito.ObtenerArticulos())
            {
                gfx.DrawString(articulo.Cantidad.ToString(), font, XBrushes.Black, new XRect(30, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(articulo.Nombre, font, XBrushes.Black, new XRect(100, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString(articulo.Precio.ToString("C"), font, XBrushes.Black, new XRect(300, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                gfx.DrawString((articulo.Precio * articulo.Cantidad).ToString("C"), font, XBrushes.Black, new XRect(400, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                yPoint += 20;
            }

            // Totales
            yPoint += 20;
            gfx.DrawString("Subtotal: " + carrito.ObtenerTotal().ToString("C"), font, XBrushes.Black, new XRect(300, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("Impuesto (6%): " + ObtenerImpuesto().ToString("C"), font, XBrushes.Black, new XRect(300, yPoint + 20, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("Total: " + ObtenerTotalConImpuesto().ToString("C"), fontBold, XBrushes.Black, new XRect(300, yPoint + 40, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            // Guardar el documento
            document.Save(filePath);
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