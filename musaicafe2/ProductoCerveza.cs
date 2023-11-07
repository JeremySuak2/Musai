using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDominio
{
    public class ProductoCerveza
    {
        public void Clasicadesdebd(out string nombreProducto)
        {
            decimal precioProducto = 0.0m; // Inicializamos el precio a 0
            nombreProducto = string.Empty;

            // Configura la conexión a la base de datos
            string connectionString = "Tu_Cadena_De_Conexión_Aquí";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crea una consulta SQL para recuperar el nombre y precio del producto "Frost" desde la base de datos
                string query = "SELECT Nombre, Precio FROM Productos WHERE Nombre = 'Frost'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtén el nombre y precio del producto desde la base de datos
                            nombreProducto = reader.GetString(0);
                            precioProducto = reader.GetDecimal(1);
                        }
                    }
                }
            }

           


        }
    }
}
