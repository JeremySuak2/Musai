using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace capaDominio
{
    public partial class regalias : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";
        public regalias()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cmbcategoria.Text;
            string productoSeleccionado = CmbProducto.Text;
            int cantidadARestar = (int)numericUpDown1.Value;

            // Obtener el inventario actual del producto
            int inventarioActual = ObtenerInventarioProducto(categoriaSeleccionada, productoSeleccionado);

            // Realizar la operación para restar la cantidad
            if (inventarioActual >= cantidadARestar)
            {
                // Calcular el nuevo inventario
                int nuevoInventario = inventarioActual - cantidadARestar;

                // Actualizar el inventario en la base de datos (deberás implementar esta parte)
                ActualizarInventarioEnBaseDeDatos(categoriaSeleccionada, productoSeleccionado, nuevoInventario);

                MessageBox.Show("Inventario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay suficiente inventario disponible para restar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void ActualizarInventarioEnBaseDeDatos(string categoria, string producto, int nuevoInventario)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Actualiza el inventario del producto en la base de datos
                    string sql = "UPDATE Productos " +
                                 "SET Inventario = @NuevoInventario " +
                                 "WHERE Nombre = @Producto AND IDCategoria = (SELECT IDCategoria FROM Categorias WHERE NombreCategoria = @Categoria)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NuevoInventario", nuevoInventario);
                        command.Parameters.AddWithValue("@Producto", producto);
                        command.Parameters.AddWithValue("@Categoria", categoria);

                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            // Éxito: el inventario se actualizó correctamente
                        }
                        else
                        {
                            // Error: no se pudo actualizar el inventario
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores, por ejemplo, mostrar un mensaje de error.
                    MessageBox.Show("Error al actualizar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int ObtenerInventarioProducto(string categoriaSeleccionada, string productoSeleccionado)
        {
            int inventarioActual = 0; // Valor predeterminado en caso de que no se encuentre el producto.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Primero, obten la ID de la categoría seleccionada
                int categoriaID = ObtenerIDCategoriaDesdeNombre(categoriaSeleccionada);

                // Ahora, busca el inventario del producto en función de la categoría y el nombre del producto
                string sql = "SELECT P.Inventario " +
                             "FROM Productos P " +
                             "INNER JOIN Categorias C ON P.IDCategoria = C.IDCategoria " +
                             "WHERE C.NombreCategoria = @Categoria AND P.Nombre = @Producto";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Categoria", categoriaSeleccionada);
                command.Parameters.AddWithValue("@Producto", productoSeleccionado);

                // Ejecuta la consulta y obtén el inventario del producto
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    inventarioActual = Convert.ToInt32(result);
                }
            }

            return inventarioActual;
        }










        private void regalias_Load(object sender, EventArgs e)
        {
            CargarCategoria();
        }
        private void CargarProductosPorCategoria(int categoriaid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT Nombre FROM Productos WHERE IDCategoria = @Categoria";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Categoria", categoriaid); // Usar la ID de categoría

                SqlDataReader reader = command.ExecuteReader();

                CmbProducto.Items.Clear(); // Limpiar el ComboBox de productos antes de cargar nuevos datos.

                while (reader.Read())
                {
                    CmbProducto.Items.Add(reader["Nombre"].ToString());
                }

                reader.Close();
            }
        }
        private void CargarCategoria()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT NombreCategoria FROM Categorias";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbcategoria.Items.Add(reader["NombreCategoria"].ToString());
                }

                reader.Close();
            }


        }
        private int ObtenerIDCategoriaDesdeNombre(string nombreCategoria)
        {
            int idCategoria = 0; // Valor predeterminado en caso de que no se encuentre la categoría

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT IDCategoria FROM Categorias WHERE NombreCategoria = @NombreCategoria";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@NombreCategoria", nombreCategoria);

                object result = command.ExecuteScalar(); // Ejecuta una consulta que devuelve un solo valor (la ID de categoría).

                if (result != null)
                {
                    idCategoria = Convert.ToInt32(result);
                }
            }

            return idCategoria;
        }

        private void cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoriaID = ObtenerIDCategoriaSeleccionada(cmbcategoria.Text);
            CargarProductosPorCategoria(categoriaID);
        }
        private int ObtenerIDCategoriaSeleccionada(string nombreCategoria)
        {
            string categoriaSeleccionada = cmbcategoria.SelectedItem.ToString();

            // Realiza una consulta SQL para obtener la ID de la categoría seleccionada desde la base de datos
            // (asegúrate de que esta consulta esté correcta en tu base de datos).
            int idCategoria = ObtenerIDCategoriaDesdeNombre(categoriaSeleccionada);

            return idCategoria;
        }
    }
}
