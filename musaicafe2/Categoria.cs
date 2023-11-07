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
    public partial class Categoria : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";
        private int cantidadClicks = 0;

        private Form3 form3;
        List<Precios_cliente> precios = new List<Precios_cliente>();
        private Control[] mesas;
        public Categoria()

        {
            InitializeComponent();
            
            panelProductos = new System.Windows.Forms.Panel();
            // Configura las propiedades del panel si es necesario
            // Agrega el panel al formulario o a otro control contenedor
            this.Controls.Add(panelProductos);

        }

        private void Categoria_Load(object sender, System.EventArgs e)
        {
            // Configura la conexión a la base de datos (paso 1)
           


        }
        

        public void ActualizarCantidadEnForm3(int cantidad)
        {
            // Suponemos que la fila de "Toña" se encuentra en la primera posición (índice 0)
            if (dataGridView1.Rows.Count > 0)
            {
                // Actualizamos la cantidad en la celda correspondiente
                dataGridView1.Rows[0].Cells["Cantidad"].Value = cantidad;

                // Obtenemos el precio unitario de "Toña" de la base de datos
                decimal precioUnitario = ObtenerPrecioProducto("Toña");

                if (precioUnitario > 0)
                {
                    // Calculamos el precio total
                    decimal precioTotal = cantidad * precioUnitario;

                    // Mostramos el precio total en la columna "Precio Total" de la fila "Toña"
                    dataGridView1.Rows[0].Cells["Precio Total"].Value = precioTotal;
                }
                else
                {
                    // Manejar un caso en el que no se pudo obtener el precio unitario
                    dataGridView1.Rows[0].Cells["Precio Total"].Value = "N/A";
                }
            }
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private Producto ObtenerProductoTonaDesdeBD()
        {
            Producto productoTona = null; // Inicializamos como nulo en caso de que no se encuentre el producto

            // Configura la conexión a la base de datos
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crea la consulta SQL para recuperar el producto "Toña"
                string sql = "SELECT  Nombre, Precio FROM Productos WHERE Nombre = 'Toña'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Si se encuentra el producto "Toña" en la base de datos, crea un objeto Producto
                            productoTona = new Producto
                            {
                                Nombre = reader.GetString(1),
                                Cantidad = reader.GetInt32(2),
                                Precio = reader.GetDecimal(3)
                            };
                        }
                    }
                }
            }

            return productoTona;

        }
        public int ObtenerCantidadToña()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value.ToString() == "Toña")
                {
                    return Convert.ToInt32(row.Cells["Cantidad"].Value);
                }
            }

            return 0; // Retornar 0 si "Toña" no se encuentra en el DataGridView
        }
        private Form3 ObtenerFormularioOtroExistente()
        {
          
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form3 formularioOtro)
                {
                    return formularioOtro;
                }
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void mesasMouseClick(object sender, MouseEventArgs e)
        {

        }
                  
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AgregarProductoAForm3("Toña");
        }
        private Form3 ObtenerOAbrirForm3()
        {
            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();

            if (form3 != null)
            {
                // Si Form3 está abierto, lo retornamos
                return form3;
            }
            else
            {
                // Si Form3 no está abierto, lo creamos y lo mostramos
                Form3 nuevoForm3 = new Form3();
                nuevoForm3.Show();
                return nuevoForm3;
            }
        }
        

            
        

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.toña1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.toña2;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AgregarProductoAForm3("Frost");
        }

       
        

        private Form3 ObtenerFormularioForm3()
        {
            // Recorre los formularios abiertos para buscar Form3
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form3 formulario)
                {
                    return formulario;
                }
            }

            // Si no se encontró Form3, devuelve null
            return null;
        }
       
        
       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AgregarProductoAForm3("Clasica");
        }
        
        //Prueba de eliminar codigos 
        // Simplicado la busqueda de productos
        private Producto ObtenerProductosDesdeBD(string nombreProducto)
        {
            Producto producto = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Nombre, Precio FROM Productos WHERE Nombre = @Nombre";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreProducto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto = new Producto
                            {
                                Nombre = reader.GetString(0),
                                Precio = reader.GetDecimal(1)
                            };
                        }
                    }
                }
            }

            return producto;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AgregarProductoAForm3("Sol");
            
            
            
        }
        private void AgregarProductoAForm3(string nombreProducto)
        {
            Producto producto = ObtenerProductosDesdeBD(nombreProducto);

            if (producto != null)
            {
                Form3 form3 = ObtenerOAbrirForm3();

                if (form3 != null)
                {
                    // Asegúrate de configurar la cantidad inicial en 1
                    producto.Cantidad = 1;

                    form3.AgregarProducto(producto);

                    // Añadir el precio unitario al precio total y mostrarlo en el DataGridView
                    MostrarPrecioUnitariosEnForm3(form3, nombreProducto, producto.Precio);
                }
                else
                {
                    MessageBox.Show("Form3 no se ha inicializado.");
                }
            }
            else
            {
                MessageBox.Show($"No se encontró el producto {nombreProducto} en la base de datos.");
            }
        }
        private void MostrarPrecioUnitariosEnForm3(Form3 form3, string nombreProducto, decimal precioUnitario)
        {
            decimal precioTotal = precioUnitario; // Inicialmente, el precio total es igual al precio unitario

            // Verificar si ya existe el producto en el DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == nombreProducto)
                {
                    // Agregar el precio unitario al precio total existente
                    precioTotal += Convert.ToDecimal(row.Cells["Precio_Total"].Value);
                    break;
                }
            }

            // Actualizar o agregar el precio total en el DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == nombreProducto)
                {
                    // Actualizar el precio total
                    row.Cells["Precio_Total"].Value = precioTotal;
                    break;
                }
            }


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AgregarProductoAForm3("Heineken");
            
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AgregarProductoAForm3("Miller");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AgregarProductoAForm3("Seleccion Maestra");
        }
        private decimal ObtenerPrecioProducto(string nombreProducto)
        {
            decimal precio = 0; // Valor predeterminado en caso de que el producto no se encuentre

            // Configura la conexión a la base de datos
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

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
        public void MostrarPrecioUnitario(string nombreProducto, decimal precioUnitario)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == nombreProducto)
                {
                    // Si el producto ya existe, muestra el precio unitario en la columna "Precio Unitario"
                    row.Cells["Precio"].Value = precioUnitario;
                    break;
                }
            }
        }


    }

}


