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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog importOpenFileDialog = new OpenFileDialog();
            DialogResult importDialogResult = importOpenFileDialog.ShowDialog();



            string xmlFileName = importOpenFileDialog.FileName;
        }
    }
}
