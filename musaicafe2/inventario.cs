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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.agregar_button2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.agregar_botton;
        }

        private void btn_cerveza_MouseEnter(object sender, EventArgs e)
        {
            btn_cerveza.Image = Properties.Resources.rojo_22;
        }

        private void btn_cerveza_MouseLeave(object sender, EventArgs e)
        {
            btn_cerveza.Image = Properties.Resources.rojo11;
        }

        private void btn_comida_MouseEnter(object sender, EventArgs e)
        {
            btn_comida.Image = Properties.Resources.comida_2;
        }

        private void btn_comida_MouseLeave(object sender, EventArgs e)
        {
            btn_comida.Image = Properties.Resources.comida_1;

        }

        private void btn_anto_MouseEnter(object sender, EventArgs e)
        {
            btn_anto.Image = Properties.Resources.antojo_2_siu;
        }

        private void btn_anto_MouseLeave(object sender, EventArgs e)
        {
            btn_anto.Image = Properties.Resources.antojo_1_siu;
        }

        private void btn_bebidas_MouseEnter(object sender, EventArgs e)
        {
            btn_bebidas.Image = Properties.Resources.azul2;
        }

        private void btn_bebidas_MouseLeave(object sender, EventArgs e)
        {
            btn_bebidas.Image = Properties.Resources.azul1;
        }

        private void btn_cocteles_MouseEnter(object sender, EventArgs e)
        {
            btn_cocteles.Image = Properties.Resources.morado2;
        }

        private void btn_cocteles_MouseLeave(object sender, EventArgs e)
        {
            btn_cocteles.Image = Properties.Resources.morado1;

        }

        private void btn_music_MouseEnter(object sender, EventArgs e)
        {
            btn_music.Image = Properties.Resources.musica_21;
        }

        private void btn_music_MouseLeave(object sender, EventArgs e)
        {
            btn_music.Image = Properties.Resources.musica_11;
        }

        private void btn_ciga_MouseEnter(object sender, EventArgs e)
        {
            btn_ciga.Image = Properties.Resources.ciga2;
        }

        private void btn_ciga_MouseLeave(object sender, EventArgs e)
        {
            btn_ciga.Image = Properties.Resources.ciga1;
        }

        private void txt_configuracion_MouseEnter(object sender, EventArgs e)
        {
            txt_configuracion.Image = Properties.Resources.agregar;
        }

        private void txt_configuracion_MouseLeave(object sender, EventArgs e)
        {
            txt_configuracion.Image = Properties.Resources.agregar_1;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerveza_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Cervezas'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;






        }

        private void inventario_Load(object sender, EventArgs e)
        {
           
            
        }

        private void CargarInventarioPorCategoria()
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
                    string sql = "SELECT C.NombreCategoria,P.Nombre, P.Inventario FROM Categorias as C inner join Productos as P on C.NombreCategoria=p.inventario";

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
            

        }

        private void btn_comida_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Comidas'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;






        }

        private void btn_anto_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Antojitos'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;






        }

        private void btn_bebidas_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Bebidas'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;






        }

        private void btn_cocteles_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Cocteles'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;






        }

        private void btn_music_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Musicas'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;

        }

        private void btn_ciga_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Cigarros'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Crea una tabla de datos para almacenar los resultados de la consulta
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL para obtener los productos de la categoría 1 y su inventario
                    string sql = "SELECT Productos.Nombre AS Producto, Productos.Inventario AS Inventario " +
                                 "FROM Productos " +
                                 "INNER JOIN Categorias ON Productos.IDCategoria = Categorias.IDCategoria " +
                                 "WHERE Categorias.NombreCategoria = 'Licores'"; // Cambia 'Categoria 1' al nombre de tu categoría
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Crea un adaptador de datos para llenar la tabla de datos con los resultados de la consulta
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos de la categoría 1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asigna la tabla de datos como origen de datos del DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void txt_configuracion_Click(object sender, EventArgs e)
        {
            AgregarProductoAInventario po = new AgregarProductoAInventario();
            po.Show();

        }
    }
    
    
    
    
}
