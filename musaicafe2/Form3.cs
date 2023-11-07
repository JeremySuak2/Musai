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
    public partial class Form3 : Form
    {

        
        private List<Producto> listaProductos;
        private DataGrid datagriselection;
        public Form3(List<Producto> productos)
        {

            InitializeComponent();

            dataGridView1 = new DataGridView();
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio Unitario", "Precio Unitario");
            dataGridView1.Columns.Add("Precio Total", "Precio Total");

            Controls.Add(dataGridView1);

            
         //    dataGridView1 = new DataGridView();
         //    dataGridView1.Columns.Add("Producto", "Producto");
         //    dataGridView1.Columns.Add("Cantidad", "Cantidad");
         //    Controls.Add(dataGridView1);
        }
        public void AgregarProducto(string nombreProducto)
        {
            bool productoEncontrado = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == nombreProducto)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    row.Cells["Cantidad"].Value = cantidadActual + 1;

                    productoEncontrado = true;

                    // Llama al método para calcular el precio total después de actualizar la cantidad
                    CalcularPrecioTotal(nombreProducto);

                    break;
                }
            }

            if (!productoEncontrado)
            {
                // Si el producto no se encontró en el bucle, agregar una nueva fila
                dataGridView1.Rows.Add(nombreProducto, 1); // Configuramos la cantidad inicial como 1

                // Llama al método para calcular el precio total después de agregar la fila
                CalcularPrecioTotal(nombreProducto);
            }
        }

        public void CalcularPrecioTotal(string nombreProducto)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == nombreProducto)
                {
                    // Obtén la cantidad y el precio unitario del producto
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["Precio"].Value);

                    // Calcula el precio total multiplicando cantidad por precio unitario
                    decimal precioTotal = cantidad * precioUnitario;

                    // Muestra el precio total en la columna "Precio Total"
                    row.Cells["Precio_Total"].Value = precioTotal;
                    break;
                }
            }
        }
        public void AgregarProducto(Producto producto)
        {
            bool productoEncontrado = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == producto.Nombre)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    row.Cells["Cantidad"].Value = cantidadActual + 1;

                    productoEncontrado = true;

                    // Llama al método para calcular el precio total después de actualizar la cantidad
                    CalcularPrecioTotal(producto.Nombre);

                    break;
                }
            }

            if (!productoEncontrado)
            {
                // Si el producto no se encontró en el bucle, agregar una nueva fila
                dataGridView1.Rows.Add(producto.Nombre, 1); // Configuramos la cantidad inicial como 1

                // Llama al método para calcular el precio total después de agregar la fila
                CalcularPrecioTotal(producto.Nombre);

                // Muestra el precio unitario en la columna "Precio Unitario"
                MostrarPrecioUnitario(producto.Nombre, producto.Precio);
            }
        }


        public void ActualizarPrecioTotal(string nombreProducto, int cantidad, decimal precioUnitario)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == nombreProducto)
                {
                    // Actualizar la cantidad en la columna "Cantidad"
                    row.Cells["Cantidad"].Value = cantidad;

                    // Calcular el precio total y mostrarlo en la columna "Precio Total"
                    decimal precioTotal = cantidad * precioUnitario;
                    row.Cells["Precio Total"].Value = precioTotal;
                    break;
                }
            }
        }

        public void ActualizarCantidadToña(int nuevaCantidad)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == "Toña")
                {
                    row.Cells["Cantidad"].Value = nuevaCantidad;
                    break;
                }
            }
        }
        public int ObtenerCantidadToña()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == "Toña")
                {
                    return Convert.ToInt32(row.Cells["Cantidad"].Value);
                }
            }

            return 0; 
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




        public Form3()


        {
           


            InitializeComponent();

        }
        //public DataGridView ObtenerDataGridView()
        //{
        //    return dataGridView1;
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

            // Realiza una consulta SQL para obtener los nombres de los meseros
            string query = "SELECT Nombre, Apellido FROM Meseros";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreMesero = reader["Nombre"].ToString();
                            string Apellido = reader["Apellido"].ToString();
                            string nombres;
                            nombres = nombreMesero + Apellido.ToString();
                            comboBox1.Items.Add(nombres);
                        }
                    }
                }





                label1.Text = " " + global.variable1 + "\r\n";
            }
        }

        private void btn_bebidas_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_anto_MouseEnter(object sender, EventArgs e)
        {
            btn_anto.Image = Properties.Resources.antojo_2_siu;
        }

        private void btn_anto_MouseLeave(object sender, EventArgs e)
        {
            btn_anto.Image = Properties.Resources.antojo_1_siu;

        }

        private void btn_anto_Click(object sender, EventArgs e)
        {

        }

        private void btn_comida_MouseEnter(object sender, EventArgs e)
        {
            btn_comida.Image = Properties.Resources.comida_2;
        }

        private void btn_comida_MouseLeave(object sender, EventArgs e)
        {
            btn_comida.Image = Properties.Resources.comida_1;

        }

        private void btn_music_MouseEnter(object sender, EventArgs e)
        {
            btn_music.Image = Properties.Resources.musica_21;
        }

        private void btn_music_MouseMove(object sender, MouseEventArgs e)
        {
            
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

        private void btn_cerveza_MouseEnter(object sender, EventArgs e)
        {
            btn_cerveza.Image = Properties.Resources.rojo_22;
        }

        private void btn_cerveza_MouseLeave(object sender, EventArgs e)
        {
            btn_cerveza.Image = Properties.Resources.rojo11;
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

        private void btn_regresar_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn_regresar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_cerveza_Click(object sender, EventArgs e)
        {
            
            Categoria ct = new Categoria();
            ct.Show();
            
            
            
            //productos pr = new productos();
           // pr.Show();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

            pictureBox2.Image = Properties.Resources._23456;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources._1234;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        //private void txt_configuracion_MouseLeave(object sender, EventArgs e)
        //{
        //    txt_configuracion.Image = Properties.Resources.agregar_1;
        //}

        private void txt_cambiarmesa_MouseEnter(object sender, EventArgs e)
        {
            txt_cambiarmesa.Image = Properties.Resources.cambiar2;
        }

        private void txt_cambiarmesa_MouseLeave(object sender, EventArgs e)
        {
            txt_cambiarmesa.Image = Properties.Resources.cambiar1;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.limpar2;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.limpar1;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
           //textBox1.Text = "              Nombre Cliente";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
           // textBox1.Text = " ";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //textBox1.Text = " clienrte ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_cambiarmesa_Click(object sender, EventArgs e)
        {
            CambiarMesa cm = new CambiarMesa();
            cm.Show();
        }

        private void txt_configuracion_Click(object sender, EventArgs e)
        {
            productos prd = new productos();
            prd.Show();
        }

        private void textBox1_MouseEnter_1(object sender, EventArgs e)
        {
           // textBox1.Text = "Inserte Cliente";

        }

        private void textBox1_MouseEnter_2(object sender, EventArgs e)
        {
            //textBox1.Text = "inserte gay";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void txt_NombreCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_NombreCliente_Click(object sender, EventArgs e)
        {
            txt_NombreCliente.Clear();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha impreso. Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ActualizarCantidadEnForm3(string nombreProducto, int cantidad)
        {
            ActualizarCantidad(nombreProducto, cantidad);
        }

        public void ActualizarCantidad(string nombreProducto, int cantidad)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == nombreProducto)
                {
                    row.Cells["Cantidad"].Value = cantidad;
                    decimal precioUnitario = ObtenerPrecioProducto(nombreProducto);

                    if (precioUnitario > 0)
                    {
                        decimal precioTotal = cantidad * precioUnitario;
                        row.Cells["Precio_Total"].Value = precioTotal;
                    }
                    else
                    {
                        row.Cells["Precio_Total"].Value = "N/A";
                    }
                }
            }
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

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@NombreProducto", nombreProducto);

                    // Ejecuta la consulta y obtén el precio del producto
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        precio = Convert.ToDecimal(result);
                    }
                }
            }

            return precio;
        }
        public decimal CalcularSumaPrecioTotal()
        {
            decimal sumaPrecioTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Precio_Total"].Value != null)
                {
                    sumaPrecioTotal += Convert.ToDecimal(row.Cells["Precio_Total"].Value);
                }
            }

            return sumaPrecioTotal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarSumaPrecioTotalEnTextBox();
        }
        public void MostrarSumaPrecioTotalEnTextBox()
        {
            decimal po;
            decimal sumaPrecioTotal = CalcularSumaPrecioTotal(); // Calcula la suma
            po = sumaPrecioTotal / 10;
            decimal total = po + sumaPrecioTotal;
            // Muestra la suma en un TextBox
            textBox3.Text = "C$ "+sumaPrecioTotal.ToString();
            textBox2.Text = "C$" + po.ToString();
            textBox1.Text = "C$" + total.ToString();
            
        }

        private void btn_bebidas_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Verificar que la fila tenga datos válidos
                if (selectedRow.Cells["Producto"].Value != null && selectedRow.Cells["Precio"].Value != null)
                {
                    string nombreProducto = selectedRow.Cells["Producto"].Value.ToString();
                    decimal precio = Convert.ToDecimal(selectedRow.Cells["Precio"].Value);

                    // Obtener la cantidad a eliminar (puedes usar un cuadro de diálogo o un control para ingresar la cantidad)
                    int cantidadAEliminar = obtenercantidadeliminar();

                    // Verificar si la cantidad a eliminar es válida
                    if (cantidadAEliminar > 0)
                    {
                        // Actualizar la cantidad en el DataGridView restando la cantidad a eliminar
                        int cantidadActual = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);
                        int nuevaCantidad = cantidadActual - cantidadAEliminar;

                        // Asegurarse de que la cantidad no sea negativa
                        if (nuevaCantidad < 0)
                        {
                            nuevaCantidad = 0; // No permitir cantidades negativas
                        }

                        selectedRow.Cells["Cantidad"].Value = nuevaCantidad;

                        // Calcular el nuevo precio total
                        decimal nuevoPrecioTotal = nuevaCantidad * precio;
                        selectedRow.Cells["Precio"].Value = nuevoPrecioTotal;
                    }
                }
            }
        }
        private int obtenercantidadeliminar()
        {
            using (InputDialogForms input = new InputDialogForms())
            {
                if (input.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(input.InputValue,out int cantidadEliminar))
                    {
                        return cantidadEliminar;

                    }


                }


            }


            return 0;
        }
    }
}
