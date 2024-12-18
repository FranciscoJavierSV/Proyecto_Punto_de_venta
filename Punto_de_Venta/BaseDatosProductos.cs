using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BaseDatos
{
    public class DatabaseProductos
    {
        private MySqlConnection connection;
        private string connectionString;

        public DatabaseProductos()
        {
            connectionString = "server=localhost;database=punto_de_venta;user=root;password=;";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
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

        public void RestarExistencias(int articuloId, int cantidad)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE productos SET Existencias = Existencias - @Cantidad WHERE ID = @ID", connection);
            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
            cmd.Parameters.AddWithValue("@ID", articuloId);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar existencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }


        private bool ProductoExiste(int id)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM productos WHERE ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el ID del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int ObtenerCantidadProductos()
        {
            int count = 0;

            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM productos", connection);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return count;
        }

        public bool AgregarProducto(int id, string nombre, double precio, int existencias, string descripcion, string imagen)
        {
            if (ProductoExiste(id))
            {
                MessageBox.Show("El ID del producto ya existe. Por favor, usa un ID diferente.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO productos (ID, Nombre, Precio, Existencias, Descripcion , Imagen) VALUES (@ID, @Nombre, @Precio, @Existencias, @Descripcion, @Imagen)", connection);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Existencias", existencias);
            cmd.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd.Parameters.AddWithValue("@Imagen", imagen);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ítem agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el ítem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool EliminarProducto(int id)
        {
            if (!ProductoExiste(id))
            {
                MessageBox.Show("No se pudo eliminar el producto.", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM productos WHERE ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ítem eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el ítem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ModificarProducto(int id, string nombre, double? precio, int? existencias, string descripcion, string imagen)
        {
            OpenConnection();

            // Construir dinámicamente la consulta con solo los campos que tienen valor
            string query = "UPDATE productos SET ";
            if (!string.IsNullOrEmpty(nombre)) query += "Nombre = @Nombre, ";
            if (precio.HasValue) query += "Precio = @Precio, ";
            if (existencias.HasValue) query += "Existencias = @Existencias, ";
            if (!string.IsNullOrEmpty(descripcion)) query += "Descripcion = @Descripcion, ";
            if (!string.IsNullOrEmpty(imagen)) query += "Imagen = @Imagen, ";
            query = query.TrimEnd(' ', ',');
            query += " WHERE ID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", id);
            if (!string.IsNullOrEmpty(nombre)) cmd.Parameters.AddWithValue("@Nombre", nombre);
            if (precio.HasValue) cmd.Parameters.AddWithValue("@Precio", precio);
            if (existencias.HasValue) cmd.Parameters.AddWithValue("@Existencias", existencias);
            if (!string.IsNullOrEmpty(descripcion)) cmd.Parameters.AddWithValue("@Descripcion", descripcion);
            if (!string.IsNullOrEmpty(imagen)) cmd.Parameters.AddWithValue("@Imagen", imagen);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el ítem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }


        public DataTable VerRegistros()
        {
            DataTable dt = new DataTable();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM productos", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public DataTable OrdenarPorExistenciasDescendente()
        {
            DataTable dt = new DataTable();
            OpenConnection();

            // Consulta SQL para ordenar por Existencias de manera descendente
            string query = "SELECT * FROM productos ORDER BY Existencias DESC";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ordenar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }


        public DataTable BuscarRegistro(int id)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM productos WHERE ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dt);
                MessageBox.Show("Registro buscado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

    }
}