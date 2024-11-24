using MySql.Data.MySqlClient;
using System.Data;

public class DatabaseHelper
{
    private MySqlConnection connection;

    // Constructor para inicializar la conexión
    public DatabaseHelper()
    {
        string connectionString = "Server=localhost;Database=punto_de_venta;Uid=root;Pwd=;";
        connection = new MySqlConnection(connectionString);
    }

    // Método para abrir la conexión
    public void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    // Método para cerrar la conexión
    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    // Método para obtener datos de la tabla usuarios
    public DataTable GetUsuarios()
    {
        DataTable dataTable = new DataTable();

        try
        {
            OpenConnection();

            // Consulta SQL: seleccionamos Usuario y Contraseña
            string query = "SELECT Usuario, Contraseña FROM usuarios";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            // Llenamos el DataTable con los resultados
            adapter.Fill(dataTable);
        }
        catch (Exception ex)
        {
            // Mostramos el mensaje de error en caso de excepción
            throw new Exception($"Error al obtener los datos: {ex.Message}");
        }
        finally
        {
            CloseConnection(); // Aseguramos de cerrar la conexión después
        }

        return dataTable;
    }

    // Método para obtener datos de la tabla de productos
    public DataTable GetProductos()
    {
        DataTable dataTable = new DataTable();

        try
        {
            OpenConnection();

            // Consulta SQL: seleccionamos id, Nombre, Descripcion, Precio, Existencias
            string query = "SELECT Id, Imagen, Descripcion, Precio, Existencias FROM productos";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            // Llenamos el DataTable con los resultados
            adapter.Fill(dataTable);
        }
        catch (Exception ex)
        {
            // Mostramos el mensaje de error en caso de excepción
            throw new Exception($"Error al obtener los datos: {ex.Message}");
        }
        finally
        {
            CloseConnection(); // Aseguramos de cerrar la conexión después
        }
       
        return dataTable;

    }

    }