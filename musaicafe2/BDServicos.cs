using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace capaDominio
{
    public class BDServicos
    {
       
        SqlConnection mng; 
        
        public BDServicos()
        {
            try 
            {
                mng = new SqlConnection("Data Source=.;Initial Catalog=Servicios;Integrated Security=True;");

                //mng = new SqlConnection("Data source = .;Initial catalog=Servicios.dbo");
                mng.Open();
                MessageBox.Show("Conexion exitosa ","Exito al conectar",MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR"+ex.Message,"Fallo al conectar",MessageBoxButtons.OK);
            }
            finally
            {
                // Asegurarse de cerrar la conexión en el bloque finally.
                if (mng != null && mng.State == System.Data.ConnectionState.Open)
                {
                    mng.Close();
                }

            }

        }
        public void InsertarUsuario(string nombreUsuario, string pin)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (NombreUsuario, Pin) VALUES (@NombreUsuario, @Pin)", mng))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Pin", pin);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario agregado correctamente", "Éxito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }




    }
}
