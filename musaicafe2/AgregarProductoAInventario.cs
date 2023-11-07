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
    public partial class AgregarProductoAInventario : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";
        public AgregarProductoAInventario()
        {
            InitializeComponent();
        }

            private void AgregarProductoAInventario_Load(object sender, EventArgs e)
            {


                CargarCategoria();



            }
            private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
            {
                int categoriaID = ObtenerIDCategoriaSeleccionada(comboBox1.Text);
                CargarProductosPorCategoria(categoriaID);


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

                    comboBox2.Items.Clear(); // Limpiar el ComboBox de productos antes de cargar nuevos datos.

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["Nombre"].ToString());
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
                        comboBox1.Items.Add(reader["NombreCategoria"].ToString());
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
            private void MostrarMensajeDebug(string mensaje)
        {
            // Agregar el mensaje al control richTextBoxDebug
            richTextBox1.AppendText(mensaje + Environment.NewLine);

            // Desplazar el cursor al final del texto para mostrar el último mensaje
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        private int ObtenerIDCategoriaSeleccionada(string nombreCategoria)
        {
            string categoriaSeleccionada = comboBox1.SelectedItem.ToString();

            // Realiza una consulta SQL para obtener la ID de la categoría seleccionada desde la base de datos
            // (asegúrate de que esta consulta esté correcta en tu base de datos).
            int idCategoria = ObtenerIDCategoriaDesdeNombre(categoriaSeleccionada);

            return idCategoria;
        }




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoriaSeleccionada = comboBox1.SelectedItem.ToString();
            string productoSeleccionado = comboBox2.SelectedItem.ToString();
            int cantidadAgregada = int.Parse(textBox1.Text);
            // Establece la cadena de conexión a tu base de datos
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Realiza una consulta SQL para actualizar el inventario del producto
                string sql = "UPDATE Productos SET Inventario = Inventario + @Cantidad " +
                     "WHERE Nombre = @Producto AND IDCategoria = (SELECT IDCategoria FROM Categorias WHERE NombreCategoria = @Categoria)";



                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Cantidad", cantidadAgregada);
                    command.Parameters.AddWithValue("@Producto", productoSeleccionado);
                    command.Parameters.AddWithValue("@Categoria", categoriaSeleccionada);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Inventario actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoriaID = ObtenerIDCategoriaSeleccionada(comboBox1.Text);
            CargarProductosPorCategoria(categoriaID);

















        }
    }
}
