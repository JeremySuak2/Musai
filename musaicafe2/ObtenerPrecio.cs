using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDominio
{
    public class ObtenerPrecio
    {
        private string ObtenerPrecioDesdeBD(string nombreProducto)
        {
            string precio = ""; // Inicializa el precio como una cadena vacía

            try
            {
                // Configura la cadena de conexión a la base de datos
                string connectionString = "Data Source=TuServidor;Initial Catalog=Servicios;Integrated Security=True";

                // Crea una conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crea la consulta SQL para obtener el precio del producto
                    string query = "SELECT Precio FROM Productos WHERE Nombre = @NombreProducto";

                    // Crea un comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agrega un parámetro para el nombre del producto
                        command.Parameters.AddWithValue("@NombreProducto", nombreProducto);

                        // Ejecuta la consulta y obtén el precio
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            precio = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el precio desde la base de datos: " + ex.Message);
            }

            return precio;
        }
    }
}
