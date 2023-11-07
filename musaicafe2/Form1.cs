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
    public partial class Form1 : Form
    {
        bool inicio = true;
        private string connectionString = "Data Source=(local);Initial Catalog=servicios;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txt_IdUsuario;
            txt_IdUsuario.Focus();
            txt_Nombre.Text = "Musai cafe";
            bool inicio = true;


        }
        // databasemusai1DataContext db = new databasemusai1DataContext();



        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Nombre.Visible = true;
           
            BDServicos c= new BDServicos();





        }

        private void label1_Click(object sender, EventArgs e)
        {
            txt_Nombre.BringToFront();
            txt_Nombre.Visible = true;

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            //label1.ForeColor = Color.FromArgb(17, 121, 105);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            // label1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            txt_Nombre.BackColor = Color.FromArgb(246, 209, 209);



        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int idusu = int.Parse(txt_IdUsuario.Text);
                string nomusu = txt_Nombre.Text;
                //var st = new tbl_usuario
                // {
                //  id_usuario = idusu,
                //   nombre_usuario = nomusu,
                //  };
                // db.tbl_usuario.InsertOnSubmit(st);
                // MessageBox.Show("ahora tengo el poder  absoluto y me la pelas");



                //===================================================//

                new principal().Show();
            }
        }

        private void p(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

            txt_Nombre.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            txt_Nombre.BackColor = Color.FromArgb(246, 209, 209);
        }

       

        private void Textbox1_Load(object sender, EventArgs e)
        {
            txt_Nombre.BackColor = Color.FromArgb(246, 209, 209);
        }

        private void Textbox1_MouseEnter_1(object sender, EventArgs e)
        {
            txt_Nombre.BackColor = Color.FromArgb(246, 209, 209);
        }

        private void Textbox1_MouseLeave_1(object sender, EventArgs e)
        {
            txt_Nombre.BackColor = Color.FromArgb(246, 209, 209);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private bool VaridarCampos()
        {
            bool ok = true;
            if (txt_Nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txt_Nombre, "Ingresar Usuario");


            }
            if (txt_IdUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txt_IdUsuario, "Ingrese Id");
            }


            return ok;
        }

        private void BorraMensajesError()
        {
            errorProvider1.SetError(txt_Nombre, "");
            errorProvider1.SetError(txt_IdUsuario, "");

        }



        private void textBox1_MouseEnter_2(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.FromArgb(239, 239, 239);
            //***Ingrese usuario
            // txt_Nombre.Text = "        Inserte usuario";


        }

        private void textBox1_MouseLeave_2(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.FromArgb(255, 255, 255);

            //**************leave
            //txt_Nombre.Text = " ";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (txt_Nombre.Text.Length > 0 && txt_IdUsuario.Text.Length > 0)
            {
                BorraMensajesError();
                if (VaridarCampos())

                    global.variable1 = txt_Nombre.Text;
                if ((int)e.KeyChar == (int)Keys.Enter)
                {

                    principal principal = new principal();
                    principal.Show();
                }
            }






        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //txt_Nombre.Clear();
        }

        private void tm_Tiempo_Tick(object sender, EventArgs e)
        {
            tbl_Hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void txt_IdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_IdUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txt_IdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_IdUsuario_KeyDown(object sender, KeyEventArgs e)
        {


            if (txt_IdUsuario.Text.Length > 0)
            {
                BorraMensajesError();
                VaridarCampos();
                if (e.KeyCode == Keys.Enter)
                {
                    txt_Nombre.Focus();
                }
            }
        }

        private void txt_IdUsuario_MouseEnter(object sender, EventArgs e)
        {
            //txt_IdUsuario.Text = "           Inserte ID";
        }

        private void txt_IdUsuario_MouseLeave(object sender, EventArgs e)
        {
            // txt_IdUsuario.Text = " ";
        }

        private void txt_IdUsuario_Click(object sender, EventArgs e)
        {
            //txt_IdUsuario.Clear();
        }

        


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            configuración c = new configuración();
            c.Show();
        }

        private void txt_IdUsuario_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txt_IdUsuario.Text, out num))
            {
                errorProvider1.SetError(txt_IdUsuario, "Ingrese Valor Numero");


            }
            else
            {
                errorProvider1.SetError(txt_IdUsuario, "");

            }
        }

        private void txt_IdUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();

            e.KeyChar = Convert.ToChar(val.SoloNumero(e.KeyChar));
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txt_Nombre.Text ="Musai Cafe";
            string pin = txt_IdUsuario.Text;

            
            bool credencialesValidas = ValidarCredenciales(nombreUsuario, pin);
            if (credencialesValidas)
            {
                principal mainForm = new principal();
                mainForm.Show(); 
                this.Hide();     
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_IdUsuario.Clear();
            }
        }

        // Método para validar las credenciales
        private bool ValidarCredenciales(string nombreUsuario, string pin)
        {
            // Realiza la validación de las credenciales aquí, por ejemplo, consulta la base de datos.
            // Devuelve true si las credenciales son correctas, de lo contrario, devuelve false.
            // Este es solo un ejemplo de implementación.
            return (nombreUsuario == "Musai Cafe" && pin == "2003");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "1";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "1";
                inicio = false;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "2";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "2";
                inicio = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "3";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "3";
                inicio = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "4";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "4";
                inicio = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "5";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "5";
                inicio = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "6";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "6";
                inicio = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "7";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "7";
                inicio = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "8";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "8";
                inicio = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "9";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "9";
                inicio = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.Text = "0";
                inicio = false;
            }
            else
            {
                txt_IdUsuario.Text = txt_IdUsuario.Text + "0";
                inicio = false;
            }
        }
    }














}





    


      


