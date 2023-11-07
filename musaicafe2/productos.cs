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
using System.Data.Sql;

namespace capaDominio
{
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }



         //   SqlConnection conexion = new SqlConnection("server=45LAB3PC06\\SA; database_musai_cafe;integrated security=true");

            int nombreBoton = 0;
            int cantidadMesas = 0;
            int numerosproducto = 0;
            Control[] mesas = new Control[100];
            string Mesa_aEliminar = "";
        


        private void productos_Load(object sender, EventArgs e)
        {
            // Configura la cadena de conexión
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una lista para almacenar los nombres de las categorías
            List<string> categorias = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los nombres de las categorías
                    string sql = "SELECT NombreCategoria FROM Categorias";

                    // Crea un objeto SqlCommand con la consulta SQL y la conexión
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Ejecuta la consulta SQL y lee los nombres de las categorías
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nombreCategoria = reader.GetString(0);
                                categorias.Add(nombreCategoria);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la lista de categorías al ComboBox
            comboBox1.DataSource = categorias;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public string numeroproducto { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._23456;
        }

        private int ObtenerIDCategoriaDesdeNombre(string nombreCategoria)
        {
            int categoriaID = -1; // Valor predeterminado en caso de que no se encuentre la categoría

            // Configura la cadena de conexión
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para buscar el ID de la categoría por nombre
                    string sql = "SELECT IDCategoria FROM Categorias WHERE NombreCategoria = @NombreCategoria";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Asigna el valor del parámetro de la consulta
                        command.Parameters.AddWithValue("@NombreCategoria", nombreCategoria);

                        // Ejecuta la consulta SQL y obtiene el resultado (el ID de la categoría)
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            categoriaID = Convert.ToInt32(result); // Convierte el resultado a entero
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores (puedes mostrar un mensaje de error o registrar el error)
                    Console.WriteLine("Error al obtener el ID de la categoría: " + ex.Message);
                }
            }

            return categoriaID;
        }


        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1234;
        }

        

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
           
        }
        private void AgregarProducto()
        {
            // Obtén los valores de los controles (nombre, categoría, precio, cantidad)
            string nombreProducto = texbox_IngresarNombre.Text;
            string categoriaNombre = comboBox1.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtInvetario.Text);

            // Configura la cadena de conexión
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Obtén el ID de la categoría a partir del nombre
                    int categoriaID = ObtenerIDCategoriaDesdeNombre(categoriaNombre);

                    // Crea la consulta SQL INSERT para agregar el producto
                    string sql = "INSERT INTO Productos (Nombre, IDCategoria, Precio, Inventario) VALUES (@Nombre, @IDCategoria, @Precio, @Cantidad)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Asigna los valores de los parámetros de la consulta
                        command.Parameters.AddWithValue("@Nombre", nombreProducto);
                        command.Parameters.AddWithValue("@IDCategoria", categoriaID);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);

                        // Ejecuta la consulta SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }








    }

}

