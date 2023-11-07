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
    public partial class configuración : Form
    {
        public configuración()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._23456;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1234;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.mesero2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.mesero1;
        }

        private void txt_AñadirMesero_MouseEnter(object sender, EventArgs e)
        {
            txt_AñadirMesero.Image = Properties.Resources.inventario2;
        }

        private void txt_AñadirMesero_MouseLeave(object sender, EventArgs e)
        {
            txt_AñadirMesero.Image = Properties.Resources.inventario1;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.contactanos2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.contactanos1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
          
        }

        private void configuración_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show (" jeremybaltodanomemi@gmail.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AñadirMesero ad  =  new AñadirMesero();
            ad.Show();
        }

        private void txt_AñadirMesero_Click(object sender, EventArgs e)
        {
            inventario iv = new inventario();
            iv.Show();
            
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.agregarproducto22;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            productos prd = new productos();
            prd.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.inventario11_copia;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           // button1.BackColor = Color.FromArgb(255, 255, 255);
            txt_OpenFile.BringToFront();
            //button1.Visible = false;



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_OpenFile.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_OpenFile.BringToFront();
            //button1.Visible = false;



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_OpenFile.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.AGregar_Datos1;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.AGregar_Datos22;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.Agregar_Categoria1;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.Agregar_Categoria2;
        }
    }
    
}
