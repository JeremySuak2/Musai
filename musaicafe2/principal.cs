 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDominio
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }
        int nombreBoton = 0;
        int cantidadMesas = 0;
        int numerosMesas = 0;
        Control[] mesas = new Control[100];
        Control[] barra = new Control[20];
        string Mesa_aEliminar = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {                            
            Button btn_mesas = new Button();
            btn_mesas.BackColor = System.Drawing.Color.White;
            btn_mesas.FlatAppearance.BorderSize = 0;
            btn_mesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_mesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_mesas.Image = global::capaDominio.Properties.Resources.Sin_título_3;
            //btn_mesas.Location = new System.Drawing.Point(153 + 21, 18);
            btn_mesas.Name = "btn_Mesa" + numerosMesas;
            btn_mesas.Size = new System.Drawing.Size(153, 157);
            btn_mesas.TabIndex = 1;
            btn_mesas.Text = "MESA " + (numerosMesas + 1);
            btn_mesas.UseVisualStyleBackColor = false;
            //btn_mesas.Click += new System.EventHandler(this.button3_Click);
            btn_mesas.MouseUp += new System.Windows.Forms.MouseEventHandler(mesasMouseClick);
            mesas[numerosMesas] = btn_mesas;
            numerosMesas++;
            flowLayoutPanel1.Controls.AddRange(mesas);
            //Form3 gestionMesaForm = new Form3();
            //gestionMesaForm.ShowDialog();
        }
        private void BotonesMesaClickeadoXD(object sender, EventArgs e)
        {


            
                  
            
            
            Form3 p = new Form3();
            p.Show();

        }

        private void principal_Load(object sender, EventArgs e)
        {
            label1.Text = " " + global.variable1 + "\r\n";


            Button btn_mesas = new Button();
            btn_mesas.BackColor = System.Drawing.Color.White;
            btn_mesas.FlatAppearance.BorderSize = 0;
            btn_mesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_mesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_mesas.Image = global::capaDominio.Properties.Resources.Sin_título_3;
            //btn_mesas.Location = new System.Drawing.Point(153 + 21, 18);
            btn_mesas.Name = "btn_Mesa" + numerosMesas;
            btn_mesas.Size = new System.Drawing.Size(153, 157);
            btn_mesas.TabIndex = 1;
            btn_mesas.Text = "MESA " + (numerosMesas + 1);
            btn_mesas.UseVisualStyleBackColor = false;
            //btn_mesas.Click += new System.EventHandler(this.button3_Click);
            btn_mesas.MouseUp += new System.Windows.Forms.MouseEventHandler(mesasMouseClick);
            mesas[numerosMesas] = btn_mesas;
            numerosMesas++;
            flowLayoutPanel1.Controls.AddRange(mesas);













        }

        private void mesasMouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                contextMenuStrip1.Show(ptLowerLeft);
                Mesa_aEliminar = btnSender.Name;
            }
            else
            {
                Form3 p = new Form3();
                p.Show();

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "quitarMesa")
            {
                if (mesas.Any(a => a.Name == Mesa_aEliminar))
                {
                    //panelComandas.Controls.AddRange(mesas);
                    Button btnEliminar = (Button)mesas.Where(a => a.Name == Mesa_aEliminar).First();
                    numerosMesas--;

                    //*********
                    Control[] temp = new Control[100];
                    int ii = 0;
                    foreach (Button botones in mesas)
                    {
                        if (botones != btnEliminar)
                        {

                            temp[ii] = botones;
                            ii++;
                        }
                    }
                    for (int i = 0; i < temp.Length; i++)
                    {
                        mesas[i] = temp[i];

                    }

           
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.AddRange(mesas);
                   // MessageBox.Show(btnEliminar.Name);
                  
              

                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_AñadirMesa_MouseClick(object sender, MouseEventArgs e)
        {
       

            

            
                

            
         

            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            btn_AñadirMesa.Image = Properties.Resources._121;
            timer1.Stop();
        }

        private void btn_AñadirMesa_MouseEnter(object sender, EventArgs e)
        {
            btn_AñadirMesa.Image = Properties.Resources.añadir2;
        }

        private void btn_AñadirMesa_MouseLeave(object sender, EventArgs e)
        {
            btn_AñadirMesa.Image = Properties.Resources.añadir1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            regalias po = new regalias();
            po.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentaRapidas po = new VentaRapidas();
            po.Show();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.engranaje2;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            configuración c = new configuración();
            c.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.engranaje1;
        }

        private void btnBarra_Click(object sender, EventArgs e)
        {
            Barra po = new Barra();
            po.Show();

        }
    }
}


    
