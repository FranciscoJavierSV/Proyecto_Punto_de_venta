using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BaseDatos; // Importa el espacio de nombres de tu clase DatabaseVentas

namespace Punto_de_Venta
{
    public partial class FEstadistica : Form
    {
        private DatabaseVentas db; // Instancia de la clase DatabaseVentas para acceder a la base de datos

        public FEstadistica()
        {
            InitializeComponent();
            db = new DatabaseVentas(); // Inicializar la instancia de DatabaseVentas
            ConfigurarGrafico(); // Configurar el gráfico
            ConfigurarDataGridView(); // Configurar el DataGridView
            MostrarTotal(); // Mostrar el total al inicializar el formulario
        }

        private void ConfigurarGrafico()
        {
            // Configurar el gráfico
            ChartDatos.Series.Clear();
            ChartDatos.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();

            // Establecer propiedades de la ChartArea
            chartArea.AxisX.Interval = 1; // Asegura que todas las etiquetas del eje X se muestren
            chartArea.AxisX.LabelStyle.Angle = -45; // Inclina las etiquetas del eje X para mejor legibilidad si hay muchas
            chartArea.AxisX.LabelStyle.IsStaggered = true; // Evita la superposición de etiquetas del eje X
            chartArea.AxisX.MajorGrid.Enabled = false; // Deshabilita las líneas de la cuadrícula mayor del eje X

            chartArea.AxisY.MajorGrid.Enabled = false; // Deshabilita las líneas de la cuadrícula mayor del eje Y
            chartArea.InnerPlotPosition = new ElementPosition(10, 10, 80, 80); // Ajusta la posición interna del gráfico

            ChartDatos.ChartAreas.Add(chartArea);
        }


        private void ConfigurarDataGridView()
        {
            // Configurar el DataGridView
            TDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar automáticamente el tamaño de las columnas al tamaño del grid
        }

        private void MostrarTotal()
        {
            // Mostrar el total en LTotal
            decimal sumaTotal = db.ObtenerSumaTotal(); // Obtener la suma total desde la base de datos
            LTotal.Text = $"Total: {sumaTotal:C}"; // Formato de moneda
        }

        private void CargarDatosDiarios()
        {
            // Consulta para obtener los datos diarios
            string query = "SELECT Fecha, Hora, Usuario, Articulos, Total FROM ventas ORDER BY Fecha, Hora, Usuario";
            DataTable dt = db.EjecutarConsulta(query); // Ejecutar la consulta y obtener los datos en un DataTable

            if (dt == null || dt.Rows.Count == 0) // Verificar si no se encontraron datos
            {
                MessageBox.Show("No se encontraron datos."); // Mostrar mensaje de error
                return;
            }

            TDatos.DataSource = dt; // Mostrar datos en el DataGridView
            TDatos.Visible = true; // Hacer visible el DataGridView
            ChartDatos.Visible = false; // Ocultar el gráfico
        }

        private void CargarDatosMensuales()
        {
            string query = "SELECT DATE_FORMAT(Fecha, '%Y-%m') as Fecha, Usuario, SUM(Total) as Total FROM ventas GROUP BY DATE_FORMAT(Fecha, '%Y-%m'), Usuario";
            DataTable dt = db.EjecutarConsulta(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos.");
                return;
            }

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
                series.Points.AddXY(fecha, total);
            }

            ChartDatos.Visible = true;
            TDatos.Visible = false; // Ocultar el DataGridView
        }

        private void CargarDatosTotales()
        {
            // Obtener los totales desde la base de datos
            DataTable dt = db.ObtenerTotales();

            if (dt == null || dt.Rows.Count == 0) // Verificar si no se encontraron datos
            {
                MessageBox.Show("No se encontraron datos."); // Mostrar mensaje de error
                return;
            }

            // Cargar datos en gráfico circular
            ChartDatos.Series.Clear(); // Limpiar series existentes
            Series pieSeries = new Series("TotalVentas")
            {
                ChartType = SeriesChartType.Pie
            };
            ChartDatos.Series.Add(pieSeries);

            foreach (DataRow row in dt.Rows) // Iterar a través de las filas del DataTable
            {
                string usuario = row["Usuario"].ToString();
                decimal total = Convert.ToDecimal(row["Total"]);

                pieSeries.Points.AddXY(usuario, total); // Añadir punto al gráfico circular
            }

            ChartDatos.Visible = true; // Hacer visible el gráfico
            TDatos.Visible = false; // Ocultar el DataGridView
        }

        private void BConfirmar_Click(object sender, EventArgs e)
        {
            // Manejar el evento del botón Confirmar
            if (RDiario.Checked)
            {
                CargarDatosDiarios(); // Cargar datos diarios
            }
            else if (RMensual.Checked)
            {
                CargarDatosMensuales(); // Cargar datos mensuales
            }
            else if (RTotal.Checked)
            {
                CargarDatosTotales(); // Cargar datos totales
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            // Manejar el evento del botón Buscar
            string fecha = TFecha.Text;
            if (DateTime.TryParse(fecha, out DateTime fechaParsed)) // Verificar si la fecha es válida
            {
                string query = $"SELECT Fecha, Hora, Usuario, Articulos, Total FROM ventas WHERE Fecha = '{fechaParsed:yyyy-MM-dd}' ORDER BY Hora, Usuario";
                DataTable dt = db.EjecutarConsulta(query); // Ejecutar la consulta y obtener los datos en un DataTable

                if (dt == null || dt.Rows.Count == 0) // Verificar si no se encontraron datos
                {
                    MessageBox.Show("No se encontraron datos."); // Mostrar mensaje de error
                    return;
                }

                TDatos.DataSource = dt; // Mostrar datos en el DataGridView
                TDatos.Visible = true; // Hacer visible el DataGridView
                ChartDatos.Visible = false; // Ocultar el gráfico
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una fecha válida.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mostrar mensaje de advertencia
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }
    }
}
