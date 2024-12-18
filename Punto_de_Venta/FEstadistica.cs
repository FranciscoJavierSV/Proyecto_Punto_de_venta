using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BaseDatos; // Importa el espacio de nombres de tu clase DatabaseVentas

namespace Punto_de_Venta
{
    public partial class FEstadistica : Form
    {
        private DatabaseVentas db;

        public FEstadistica()
        {
            InitializeComponent();
            db = new DatabaseVentas();
            ConfigurarGrafico();
            MostrarTotal(); // Mostrar el total al inicializar el formulario
        }

        private void ConfigurarGrafico()
        {
            // Configurar el gráfico
            ChartDatos.Series.Clear();
            ChartDatos.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            ChartDatos.ChartAreas.Add(chartArea);
        }

        private void MostrarTotal()
        {
            // Mostrar el total en LTotal
            decimal sumaTotal = db.ObtenerSumaTotal();
            LTotal.Text = $"Total: {sumaTotal:C}"; // Formato de moneda
        }

        private void CargarDatos(string query)
        {
            DataTable dt = db.EjecutarConsulta(query);

            ChartDatos.Series.Clear(); // Limpiar series existentes

            foreach (DataRow row in dt.Rows)
            {
                string usuario = row["Usuario"].ToString();
                string fecha = row["Fecha"].ToString();
                decimal total = Convert.ToDecimal(row["Total"]);

                // Verificar si ya existe una serie para el usuario
                Series series = ChartDatos.Series.FindByName(usuario);
                if (series == null)
                {
                    // Si no existe, crear una nueva serie para el usuario
                    series = new Series(usuario)
                    {
                        ChartType = SeriesChartType.StackedColumn
                    };
                    ChartDatos.Series.Add(series);
                }

                // Añadir punto a la serie del usuario
                series.Points.AddXY(Convert.ToDateTime(fecha).ToString("yyyy-MM-dd"), total);
            }
        }

        private void BConfirmar_Click(object sender, EventArgs e)
        {
            if (RDiario.Checked)
            {
                CargarDatosDiarios();
            }
            else if (RMensual.Checked)
            {
                CargarDatosMensuales();
            }
            else if (RTotal.Checked)
            {
                CargarDatosTotales();
            }
        }

        private void CargarDatosDiarios()
        {
            string query = "SELECT Fecha, Usuario, SUM(Total) as Total FROM ventas GROUP BY Fecha, Usuario";
            CargarDatos(query);
        }

        private void CargarDatosMensuales()
        {
            string query = "SELECT DATE_FORMAT(Fecha, '%Y-%m') as Fecha, Usuario, SUM(Total) as Total FROM ventas GROUP BY DATE_FORMAT(Fecha, '%Y-%m'), Usuario";
            CargarDatos(query);
        }

        private void CargarDatosTotales()
        {
            DataTable dt = db.ObtenerTotales();

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos.");
                return;
            }

            // Cargar datos en gráfico circular
            ChartDatos.Series.Clear(); // Limpiar series existentes
            Series pieSeries = new Series("TotalVentas")
            {
                ChartType = SeriesChartType.Pie
            };
            ChartDatos.Series.Add(pieSeries);

            foreach (DataRow row in dt.Rows)
            {
                string usuario = row["Usuario"].ToString();
                decimal total = Convert.ToDecimal(row["Total"]);

                pieSeries.Points.AddXY(usuario, total);
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string fecha = TFecha.Text;
            if (DateTime.TryParse(fecha, out DateTime fechaParsed))
            {
                string query = $"SELECT Fecha, Usuario, SUM(Total) as Total FROM ventas WHERE Fecha = '{fechaParsed.ToString("yyyy-MM-dd")}' GROUP BY Fecha, Usuario";
                CargarDatos(query);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una fecha válida.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}