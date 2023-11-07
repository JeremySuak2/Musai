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
    public partial class VentaRapidas : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";
        public VentaRapidas()
        {
            InitializeComponent();
        }

        private void VentaRapidas_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            dataGridView1.Columns.Add("Nombre", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            //dataGridView1.Columns.Add("Precio Unitario","");
            dataGridView1.Columns.Add("Precio", "Precio Total");

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
        private void CargarProductosPorCategoria(int categoriaid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT Nombre FROM Productos WHERE IDCategoria = @Categoria";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Categoria", categoriaid); // Usar la ID de categoría

                SqlDataReader reader = command.ExecuteReader();

                cmbProductos.Items.Clear(); // Limpiar el ComboBox de productos antes de cargar nuevos datos.

                while (reader.Read())
                {
                    cmbProductos.Items.Add(reader["Nombre"].ToString());
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
                    cmbCategoria.Items.Add(reader["NombreCategoria"].ToString());
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
        private decimal ObtenerPrecioProducto(string nombreProducto)
        {
            decimal precio = 0; // Valor predeterminado en caso de que el producto no se encuentre

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crea una consulta SQL para obtener el precio del producto por su nombre
                string sql = "SELECT Precio FROM Productos WHERE Nombre = @NombreProducto";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@NombreProducto", nombreProducto);

                // Ejecuta la consulta y obtén el precio del producto
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    precio = Convert.ToDecimal(result);
                }
            }

            return precio;
        }





        private int ObtenerIDCategoriaSeleccionada(string nombreCategoria)
        {
            string categoriaSeleccionada = cmbCategoria.SelectedItem.ToString();

            // Realiza una consulta SQL para obtener la ID de la categoría seleccionada desde la base de datos
            // (asegúrate de que esta consulta esté correcta en tu base de datos).
            int idCategoria = ObtenerIDCategoriaDesdeNombre(categoriaSeleccionada);

            return idCategoria;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoriaID = ObtenerIDCategoriaSeleccionada(cmbCategoria.Text);
            CargarProductosPorCategoria(categoriaID);
        }
        private void CargarProductoSeleccionado(string nombreProducto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT Nombre, Precio FROM Productos WHERE Nombre = @NombreProducto";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    decimal precioUnitario = (decimal)reader["Precio"];
                    // Agrega una nueva fila al DataGridView con el nombre del producto, cantidad (inicialmente 1), precio unitario y precio total.
                    dataGridView1.Rows.Add(reader["Nombre"], 1, precioUnitario, precioUnitario);
                }

                reader.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cmbProductos.Text;
            int cantidad = (int)numericUpDown1.Value;

            if (cantidad > 0)
            {
                bool productoExistente = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Nombre"].Value != null && row.Cells["Nombre"].Value.ToString() == productoSeleccionado)
                    {
                        int cantidadExistente = (int)row.Cells["Cantidad"].Value;

                        if (cantidadExistente + cantidad > 1)
                        {
                            // Calcular el precio total si la cantidad es mayor que 1
                            decimal precio = ObtenerPrecioProducto(productoSeleccionado);
                            decimal precioTotal = precio * (cantidadExistente + cantidad);

                            row.Cells["Cantidad"].Value = cantidadExistente + cantidad;
                            row.Cells["Precio"].Value = precioTotal;
                        }
                        else
                        {
                            // Si la cantidad es 1, mantener el precio unitario como precio total
                            decimal precio = (decimal)row.Cells["Precio"].Value;
                            row.Cells["Cantidad"].Value = cantidadExistente + cantidad;
                            row.Cells["Precio"].Value = precio;
                        }

                        productoExistente = true;
                        break;
                    }
                }

                if (!productoExistente)
                {
                    decimal precio = ObtenerPrecioProducto(productoSeleccionado);

                    if (precio > 0)
                    {
                        decimal precioTotal = precio * cantidad;
                        dataGridView1.Rows.Add(productoSeleccionado, cantidad, precioTotal);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el precio del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    decimal total = CalcularTotalPreciosTotales();
                    textBox1.Text = total.ToString();
                    cmbProductos.SelectedIndex = -1;
                    numericUpDown1.Value = 1;
                }
            }
            else
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private decimal CalcularTotalPreciosTotales()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal precioTotal))
                {
                    total += precioTotal;
                }
            }
            return total;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
