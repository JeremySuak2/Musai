namespace capaDominio
{
    partial class productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_AgregarProducto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtInvetario = new System.Windows.Forms.TextBox();
            this.texbox_IngresarNombre = new System.Windows.Forms.TextBox();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AgregarProducto
            // 
            this.lbl_AgregarProducto.AutoSize = true;
            this.lbl_AgregarProducto.Location = new System.Drawing.Point(226, 19);
            this.lbl_AgregarProducto.Name = "lbl_AgregarProducto";
            this.lbl_AgregarProducto.Size = new System.Drawing.Size(90, 13);
            this.lbl_AgregarProducto.TabIndex = 0;
            this.lbl_AgregarProducto.Text = "Agregar Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaDominio.Properties.Resources._1234;
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtInvetario);
            this.panel1.Controls.Add(this.texbox_IngresarNombre);
            this.panel1.Controls.Add(this.btn_AgregarProducto);
            this.panel1.Controls.Add(this.lbl_precio);
            this.panel1.Controls.Add(this.lbl_stock);
            this.panel1.Controls.Add(this.lbl_categoria);
            this.panel1.Controls.Add(this.lbl_NombreProducto);
            this.panel1.Location = new System.Drawing.Point(41, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 334);
            this.panel1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(344, 126);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 19;
            // 
            // txtInvetario
            // 
            this.txtInvetario.Location = new System.Drawing.Point(126, 122);
            this.txtInvetario.Name = "txtInvetario";
            this.txtInvetario.Size = new System.Drawing.Size(121, 20);
            this.txtInvetario.TabIndex = 18;
            // 
            // texbox_IngresarNombre
            // 
            this.texbox_IngresarNombre.Location = new System.Drawing.Point(126, 45);
            this.texbox_IngresarNombre.Name = "texbox_IngresarNombre";
            this.texbox_IngresarNombre.Size = new System.Drawing.Size(121, 20);
            this.texbox_IngresarNombre.TabIndex = 17;
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(60, 196);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(119, 32);
            this.btn_AgregarProducto.TabIndex = 16;
            this.btn_AgregarProducto.Text = "agregar";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(301, 129);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_precio.TabIndex = 15;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(60, 122);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(33, 13);
            this.lbl_stock.TabIndex = 14;
            this.lbl_stock.Text = "stock";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(60, 84);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_categoria.TabIndex = 13;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(57, 45);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(44, 13);
            this.lbl_NombreProducto.TabIndex = 12;
            this.lbl_NombreProducto.Text = "Nombre";
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(581, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_AgregarProducto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productos";
            this.Load += new System.EventHandler(this.productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AgregarProducto;
      //  private database_musai_cafeDataSet database_musai_cafeDataSet1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtInvetario;
        private System.Windows.Forms.TextBox texbox_IngresarNombre;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_NombreProducto;

    }
}