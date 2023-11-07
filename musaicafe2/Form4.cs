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
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=Servicios;Integrated Security=True;";
        public Form4()
        {
            InitializeComponent();
        }
        private void EliminarMesero_Load(object sender, EventArgs e)
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

        private void buttonEliminarMesero_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
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

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarMeserosEnDataGridView();
        }
    }
}

