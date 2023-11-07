namespace capaDominio
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_cambiarmesa = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_ciga = new System.Windows.Forms.Button();
            this.btn_music = new System.Windows.Forms.Button();
            this.btn_comida = new System.Windows.Forms.Button();
            this.btn_anto = new System.Windows.Forms.Button();
            this.btn_cocteles = new System.Windows.Forms.Button();
            this.btn_bebidas = new System.Windows.Forms.Button();
            this.btn_cerveza = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cambiarmesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreCliente.Location = new System.Drawing.Point(162, 43);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(170, 31);
            this.txt_NombreCliente.TabIndex = 18;
            this.txt_NombreCliente.Text = "Nombre Cliente";
            this.txt_NombreCliente.Click += new System.EventHandler(this.txt_NombreCliente_Click);
            this.txt_NombreCliente.TextChanged += new System.EventHandler(this.txt_NombreCliente_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Precio_Total});
            this.dataGridView1.Location = new System.Drawing.Point(162, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 389);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Precio_Total
            // 
            this.Precio_Total.HeaderText = "Precio Total";
            this.Precio_Total.Name = "Precio_Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaDominio.Properties.Resources.agregar_botton;
            this.pictureBox1.Location = new System.Drawing.Point(14, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_cambiarmesa
            // 
            this.txt_cambiarmesa.Image = global::capaDominio.Properties.Resources.cambiar1;
            this.txt_cambiarmesa.Location = new System.Drawing.Point(2, 25);
            this.txt_cambiarmesa.Name = "txt_cambiarmesa";
            this.txt_cambiarmesa.Size = new System.Drawing.Size(130, 74);
            this.txt_cambiarmesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txt_cambiarmesa.TabIndex = 15;
            this.txt_cambiarmesa.TabStop = false;
            this.txt_cambiarmesa.Click += new System.EventHandler(this.txt_cambiarmesa_Click);
            this.txt_cambiarmesa.MouseEnter += new System.EventHandler(this.txt_cambiarmesa_MouseEnter);
            this.txt_cambiarmesa.MouseLeave += new System.EventHandler(this.txt_cambiarmesa_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::capaDominio.Properties.Resources.limpar1;
            this.pictureBox3.Location = new System.Drawing.Point(4, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // btn_ciga
            // 
            this.btn_ciga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ciga.FlatAppearance.BorderSize = 0;
            this.btn_ciga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ciga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ciga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ciga.Image = global::capaDominio.Properties.Resources.ciga1;
            this.btn_ciga.Location = new System.Drawing.Point(141, 168);
            this.btn_ciga.Name = "btn_ciga";
            this.btn_ciga.Size = new System.Drawing.Size(125, 59);
            this.btn_ciga.TabIndex = 10;
            this.btn_ciga.UseVisualStyleBackColor = true;
            this.btn_ciga.MouseEnter += new System.EventHandler(this.btn_ciga_MouseEnter);
            this.btn_ciga.MouseLeave += new System.EventHandler(this.btn_ciga_MouseLeave);
            // 
            // btn_music
            // 
            this.btn_music.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_music.FlatAppearance.BorderSize = 0;
            this.btn_music.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_music.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_music.Image = global::capaDominio.Properties.Resources.musica_11;
            this.btn_music.Location = new System.Drawing.Point(13, 233);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(118, 59);
            this.btn_music.TabIndex = 6;
            this.btn_music.UseVisualStyleBackColor = true;
            this.btn_music.MouseEnter += new System.EventHandler(this.btn_music_MouseEnter);
            this.btn_music.MouseLeave += new System.EventHandler(this.btn_music_MouseLeave);
            this.btn_music.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_music_MouseMove);
            // 
            // btn_comida
            // 
            this.btn_comida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_comida.FlatAppearance.BorderSize = 0;
            this.btn_comida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_comida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_comida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comida.Image = global::capaDominio.Properties.Resources.comida_1;
            this.btn_comida.Location = new System.Drawing.Point(13, 106);
            this.btn_comida.Name = "btn_comida";
            this.btn_comida.Size = new System.Drawing.Size(118, 56);
            this.btn_comida.TabIndex = 5;
            this.btn_comida.UseVisualStyleBackColor = true;
            this.btn_comida.MouseEnter += new System.EventHandler(this.btn_comida_MouseEnter);
            this.btn_comida.MouseLeave += new System.EventHandler(this.btn_comida_MouseLeave);
            // 
            // btn_anto
            // 
            this.btn_anto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_anto.FlatAppearance.BorderSize = 0;
            this.btn_anto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_anto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_anto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anto.Image = global::capaDominio.Properties.Resources.antojo_1_siu;
            this.btn_anto.Location = new System.Drawing.Point(13, 168);
            this.btn_anto.Name = "btn_anto";
            this.btn_anto.Size = new System.Drawing.Size(118, 59);
            this.btn_anto.TabIndex = 4;
            this.btn_anto.UseVisualStyleBackColor = true;
            this.btn_anto.Click += new System.EventHandler(this.btn_anto_Click);
            this.btn_anto.MouseEnter += new System.EventHandler(this.btn_anto_MouseEnter);
            this.btn_anto.MouseLeave += new System.EventHandler(this.btn_anto_MouseLeave);
            // 
            // btn_cocteles
            // 
            this.btn_cocteles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cocteles.FlatAppearance.BorderSize = 0;
            this.btn_cocteles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cocteles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cocteles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cocteles.Image = global::capaDominio.Properties.Resources.morado1;
            this.btn_cocteles.Location = new System.Drawing.Point(138, 106);
            this.btn_cocteles.Name = "btn_cocteles";
            this.btn_cocteles.Size = new System.Drawing.Size(128, 56);
            this.btn_cocteles.TabIndex = 3;
            this.btn_cocteles.UseVisualStyleBackColor = true;
            this.btn_cocteles.MouseEnter += new System.EventHandler(this.btn_cocteles_MouseEnter);
            this.btn_cocteles.MouseLeave += new System.EventHandler(this.btn_cocteles_MouseLeave);
            // 
            // btn_bebidas
            // 
            this.btn_bebidas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bebidas.FlatAppearance.BorderSize = 0;
            this.btn_bebidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bebidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bebidas.Image = global::capaDominio.Properties.Resources.azul1;
            this.btn_bebidas.Location = new System.Drawing.Point(138, 37);
            this.btn_bebidas.Name = "btn_bebidas";
            this.btn_bebidas.Size = new System.Drawing.Size(128, 60);
            this.btn_bebidas.TabIndex = 2;
            this.btn_bebidas.UseVisualStyleBackColor = true;
            this.btn_bebidas.Click += new System.EventHandler(this.btn_bebidas_Click_1);
            this.btn_bebidas.MouseEnter += new System.EventHandler(this.btn_bebidas_MouseEnter);
            this.btn_bebidas.MouseLeave += new System.EventHandler(this.btn_bebidas_MouseLeave);
            // 
            // btn_cerveza
            // 
            this.btn_cerveza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerveza.FlatAppearance.BorderSize = 0;
            this.btn_cerveza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerveza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerveza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerveza.Image = global::capaDominio.Properties.Resources.rojo11;
            this.btn_cerveza.Location = new System.Drawing.Point(13, 37);
            this.btn_cerveza.Name = "btn_cerveza";
            this.btn_cerveza.Size = new System.Drawing.Size(118, 60);
            this.btn_cerveza.TabIndex = 1;
            this.btn_cerveza.UseVisualStyleBackColor = true;
            this.btn_cerveza.Click += new System.EventHandler(this.btn_cerveza_Click);
            this.btn_cerveza.MouseEnter += new System.EventHandler(this.btn_cerveza_MouseEnter);
            this.btn_cerveza.MouseLeave += new System.EventHandler(this.btn_cerveza_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::capaDominio.Properties.Resources._1234;
            this.pictureBox2.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 29);
            this.textBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 49);
            this.button2.TabIndex = 24;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btn_comida);
            this.groupBox1.Controls.Add(this.btn_anto);
            this.groupBox1.Controls.Add(this.btn_cocteles);
            this.groupBox1.Controls.Add(this.btn_ciga);
            this.groupBox1.Controls.Add(this.btn_bebidas);
            this.groupBox1.Controls.Add(this.btn_cerveza);
            this.groupBox1.Controls.Add(this.btn_music);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(611, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 318);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(611, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 140);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(129, 23);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 29);
            this.textBox3.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "SubTotal:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(129, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 29);
            this.textBox2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "IVA:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.txt_cambiarmesa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 433);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funciones";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(16, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 45);
            this.button4.TabIndex = 26;
            this.button4.Text = "Eliminar Producto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 45);
            this.button3.TabIndex = 25;
            this.button3.Text = "Juntar Mesas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(131)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(912, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cambiarmesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerveza;
        private System.Windows.Forms.Button btn_bebidas;
        private System.Windows.Forms.Button btn_cocteles;
        private System.Windows.Forms.Button btn_anto;
        private System.Windows.Forms.Button btn_comida;
        private System.Windows.Forms.Button btn_music;
        private System.Windows.Forms.Button btn_ciga;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox txt_cambiarmesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Total;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}