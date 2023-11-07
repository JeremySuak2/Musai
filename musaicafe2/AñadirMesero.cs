using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace capaDominio
{
    public partial class AñadirMesero : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";

        public AñadirMesero()
        {
            InitializeComponent();
        }

        private void AñadirMesero_Load(object sender, EventArgs e)
        {
            CargarMeserosEnDataGridView();
        }

        private void CargarMeserosEnDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT ID, Nombre, Apellido FROM Meseros";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Enlaza el DataTable con el DataGridView
                dataGridView1.DataSource = dataTable;

                // Configura las columnas como no visibles si no deseas mostrarlas
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string nombre = textBox1.Text;
            //string apellido = textBox2.Text;

            //// Llama a una función que inserte estos valores en la base de datos
            //InsertarMeseroEnBaseDeDatos(nombre, apellido);
        }

        private void InsertarMeseroEnBaseDeDatos(string nombre, string apellido)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea la consulta SQL INSERT para agregar el mesero
                    string sql = "INSERT INTO Meseros (Nombre, Apellido) VALUES (@Nombre, @Apellido)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Asigna los valores de los parámetros de la consulta
                        //command.Parameters.AddWithValue("ID", ID);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);


                        // Ejecuta la consulta SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mesero agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarMeserosEnDataGridView(); // Vuelve a cargar la lista de meseros
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el mesero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el mesero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el ID del mesero seleccionado
                int idMesero = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Ejecuta la consulta SQL para eliminar el mesero
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Meseros WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", idMesero);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Mesero eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMeserosEnDataGridView(); // Vuelve a cargar la lista de meseros
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el mesero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un mesero antes de eliminarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }







            //Form4 po = new Form4();
            //po.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
           // int Id = Convert.ToInt32(textBox3.Text);

            // Llama a una función que inserte estos valores en la base de datos
            InsertarMeseroEnBaseDeDatos(nombre, apellido);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            // int Id = Convert.ToInt32(textBox3.Text);

            // Llama a una función que inserte estos valores en la base de datos
            InsertarMeseroEnBaseDeDatos(nombre, apellido);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el ID del mesero seleccionado
                int idMesero = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Ejecuta la consulta SQL para eliminar el mesero
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Meseros WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", idMesero);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Mesero eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMeserosEnDataGridView(); // Vuelve a cargar la lista de meseros
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el mesero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un mesero antes de eliminarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
