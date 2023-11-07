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
    public partial class Barra : Form
    {
        int nombreBoton = 0;
        int cantidadMesas = 0;
        int numerosMesas = 0;
        Control[] mesas = new Control[100];
        Control[] barra = new Control[20];
        string Mesa_aEliminar = "";
        public Barra()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn_barra = new Button();
            btn_barra.BackColor = System.Drawing.Color.Transparent;
            btn_barra.FlatAppearance.BorderSize = 0;
            btn_barra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_barra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_barra.ForeColor = System.Drawing.Color.White;
            btn_barra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_barra.Image = global::capaDominio.Properties.Resources.Barra2;
            //btn_mesas.Location = new System.Drawing.Point(153 + 21, 18);
            btn_barra.Name = "btn_barra" + numerosMesas;
            btn_barra.Size = new System.Drawing.Size(110, 120);
            btn_barra.TabIndex = 1;
            btn_barra.Text = "silla " + (numerosMesas + 1);
            // btnbarra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_barra.UseVisualStyleBackColor = false;
            //btn_mesas.Click += new System.EventHandler(this.button3_Click);
            btn_barra.MouseUp += new System.Windows.Forms.MouseEventHandler(BotonesMesaClickeadoXD);
            barra[numerosMesas] = btn_barra;

            numerosMesas++;
            flowLayoutPanel1.Controls.AddRange(barra);
        }
        private void BotonesMesaClickeadoXD(object sender, EventArgs e)
        {


            
                  
            
            
            Form3 p = new Form3();
            p.Show();

        }

        private void Barra_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
