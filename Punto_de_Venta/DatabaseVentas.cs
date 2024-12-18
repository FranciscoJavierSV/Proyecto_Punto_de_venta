using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BaseDatos
{
    public class DatabaseVentas
    {
        private MySqlConnection connection;
        private string connectionString;

        public DatabaseVentas()
        {
            connectionString = "server=localhost;database=punto_de_venta;user=root;password=;";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public bool InsertarVenta(string fecha, string hora, string usuario, string articulos, decimal total)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO ventas (Fecha, Hora, Usuario, Articulos, Total) VALUES (@Fecha, @Hora, @Usuario, @Articulos, @Total)", connection);
            cmd.Parameters.AddWithValue("@Fecha", fecha);
            cmd.Parameters.AddWithValue("@Hora", hora);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Articulos", articulos);
            cmd.Parameters.AddWithValue("@Total", total);

            try
            {
                cmd.ExecuteNonQuery();
                ActualizarTotalUsuario(usuario, total); // Actualiza la tabla de totales
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable VerVentas()
        {
            DataTable dt = new DataTable();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ventas", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public DataTable BuscarVenta(int id)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ventas WHERE ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public bool ModificarVenta(int id, string fecha, string hora, string usuario, string articulos, decimal total)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE ventas SET Fecha = @Fecha, Hora = @Hora, Usuario = @Usuario, Articulos = @Articulos, Total = @Total WHERE ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Fecha", fecha);
            cmd.Parameters.AddWithValue("@Hora", hora);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Articulos", articulos);
            cmd.Parameters.AddWithValue("@Total", total);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool EliminarVenta(int id)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM ventas WHERE ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }



        // Nuevo método para ejecutar consultas y devolver un DataTable
        public DataTable EjecutarConsulta(string query)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        // Método para obtener los totales desde la tabla `total`
        public DataTable ObtenerTotales()
        {
            DataTable dt = new DataTable();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT Usuario, SUM(Total) as Total FROM total GROUP BY Usuario", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los totales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public decimal ObtenerSumaTotal()
        {
            decimal sumaTotal = 0;
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT SUM(Total) as SumaTotal FROM total", connection);

            try
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    sumaTotal = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la suma total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return sumaTotal;
        }

        // Método para actualizar la tabla de totales
        public void ActualizarTotalUsuario(string usuario, decimal totalVenta)
        {
            OpenConnection();

            try
            {
                // Verificar si el usuario ya existe en la tabla total
                MySqlCommand cmdCheck = new MySqlCommand("SELECT Total FROM total WHERE Usuario = @Usuario", connection);
                cmdCheck.Parameters.AddWithValue("@Usuario", usuario);

                object result = cmdCheck.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    // El usuario existe, actualizar el total
                    decimal totalActual = Convert.ToDecimal(result);
                    decimal nuevoTotal = totalActual + totalVenta;

                    MySqlCommand cmdUpdate = new MySqlCommand("UPDATE total SET Total = @NuevoTotal WHERE Usuario = @Usuario", connection);
                    cmdUpdate.Parameters.AddWithValue("@NuevoTotal", nuevoTotal);
                    cmdUpdate.Parameters.AddWithValue("@Usuario", usuario);
                    cmdUpdate.ExecuteNonQuery();
                }
                else
                {
                    // El usuario no existe, insertar nuevo registro
                    MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO total (Usuario, Total) VALUES (@Usuario, @Total)", connection);
                    cmdInsert.Parameters.AddWithValue("@Usuario", usuario);
                    cmdInsert.Parameters.AddWithValue("@Total", totalVenta);
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el total del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}