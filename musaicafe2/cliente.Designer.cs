namespace capaDominio
{
    partial class cliente
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
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_DniCliente = new System.Windows.Forms.Label();
            this.lbl_mesa = new System.Windows.Forms.Label();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(333, 44);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(95, 13);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Registro de cliente";
            // 
            // lbl_DniCliente
            // 
            this.lbl_DniCliente.AutoSize = true;
            this.lbl_DniCliente.Location = new System.Drawing.Point(151, 110);
            this.lbl_DniCliente.Name = "lbl_DniCliente";
            this.lbl_DniCliente.Size = new System.Drawing.Size(26, 13);
            this.lbl_DniCliente.TabIndex = 1;
            this.lbl_DniCliente.Text = "DNI";
            // 
            // lbl_mesa
            // 
            this.lbl_mesa.AutoSize = true;
            this.lbl_mesa.Location = new System.Drawing.Point(151, 201);
            this.lbl_mesa.Name = "lbl_mesa";
            this.lbl_mesa.Size = new System.Drawing.Size(33, 13);
            this.lbl_mesa.TabIndex = 3;
            this.lbl_mesa.Text = "Mesa";
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(151, 155);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombreCliente.TabIndex = 4;
            this.lbl_nombreCliente.Text = "Nombre";
            this.lbl_nombreCliente.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.Location = new System.Drawing.Point(154, 246);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarCliente.TabIndex = 5;
            this.btn_agregarCliente.Text = "Agregar";
            this.btn_agregarCliente.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 669);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_agregarCliente);
            this.Controls.Add(this.lbl_nombreCliente);
            this.Controls.Add(this.lbl_mesa);
            this.Controls.Add(this.lbl_DniCliente);
            this.Controls.Add(this.lbl_cliente);
            this.Name = "cliente";
            this.Text = "cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_DniCliente;
        private System.Windows.Forms.Label lbl_mesa;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}