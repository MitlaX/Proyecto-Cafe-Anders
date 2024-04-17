namespace Proyecto_Base_de_datos
{
    partial class FormVenta
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCLDMonto = new System.Windows.Forms.MaskedTextBox();
            this.btnResetearCLD = new System.Windows.Forms.Button();
            this.tbCLDCambio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFacturarCLD = new System.Windows.Forms.Button();
            this.btnEliminarCLD = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalCLD = new System.Windows.Forms.Label();
            this.lblIvaCLD = new System.Windows.Forms.Label();
            this.lblSubTotalCLD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Proyecto_Base_de_datos.CafeDataSet();
            this.lblPrecioA6CLD = new System.Windows.Forms.Label();
            this.lblPrecioA3CLD = new System.Windows.Forms.Label();
            this.lblPrecioA5CLD = new System.Windows.Forms.Label();
            this.lblPrecioA2CLD = new System.Windows.Forms.Label();
            this.lblPrecioA4CLD = new System.Windows.Forms.Label();
            this.lblPrecioA1CLD = new System.Windows.Forms.Label();
            this.lblNameA6CLD = new System.Windows.Forms.Label();
            this.lblNameA5CLD = new System.Windows.Forms.Label();
            this.lblNameA3CLD = new System.Windows.Forms.Label();
            this.lblNameA4CLD = new System.Windows.Forms.Label();
            this.lblNameA2CLD = new System.Windows.Forms.Label();
            this.lblNameA1CLD = new System.Windows.Forms.Label();
            this.btcldBebidasC = new System.Windows.Forms.Button();
            this.btcldBebidasF = new System.Windows.Forms.Button();
            this.btcldPostrea = new System.Windows.Forms.Button();
            this.ticketTableAdapter = new Proyecto_Base_de_datos.CafeDataSetTableAdapters.ticketTableAdapter();
            this.btnBackCLD = new System.Windows.Forms.Button();
            this.pBoxA1CLD = new System.Windows.Forms.PictureBox();
            this.pBoxA2CLD = new System.Windows.Forms.PictureBox();
            this.pBoxA4CLD = new System.Windows.Forms.PictureBox();
            this.pBoxA5CLD = new System.Windows.Forms.PictureBox();
            this.pBoxA3CLD = new System.Windows.Forms.PictureBox();
            this.pBoxA6CLD = new System.Windows.Forms.PictureBox();
            this.btncldSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numCLD = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA1CLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA2CLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA4CLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA5CLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA3CLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA6CLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCLD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 87);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Base_de_datos.Properties.Resources.taza_cafe;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cafe\r\nAnders\r\n\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tbCLDMonto);
            this.panel3.Controls.Add(this.btnResetearCLD);
            this.panel3.Controls.Add(this.tbCLDCambio);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnFacturarCLD);
            this.panel3.Controls.Add(this.btnEliminarCLD);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblTotalCLD);
            this.panel3.Controls.Add(this.lblIvaCLD);
            this.panel3.Controls.Add(this.lblSubTotalCLD);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(586, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 739);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 640);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "$";
            // 
            // tbCLDMonto
            // 
            this.tbCLDMonto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbCLDMonto.Location = new System.Drawing.Point(207, 640);
            this.tbCLDMonto.Name = "tbCLDMonto";
            this.tbCLDMonto.Size = new System.Drawing.Size(144, 29);
            this.tbCLDMonto.TabIndex = 73;
            // 
            // btnResetearCLD
            // 
            this.btnResetearCLD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetearCLD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(207)))), ((int)(((byte)(182)))));
            this.btnResetearCLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetearCLD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetearCLD.ForeColor = System.Drawing.Color.Black;
            this.btnResetearCLD.Location = new System.Drawing.Point(289, 437);
            this.btnResetearCLD.Name = "btnResetearCLD";
            this.btnResetearCLD.Size = new System.Drawing.Size(89, 27);
            this.btnResetearCLD.TabIndex = 71;
            this.btnResetearCLD.Text = "Terminar";
            this.btnResetearCLD.UseVisualStyleBackColor = false;
            this.btnResetearCLD.Click += new System.EventHandler(this.btnResetearCLD_Click);
            // 
            // tbCLDCambio
            // 
            this.tbCLDCambio.Enabled = false;
            this.tbCLDCambio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbCLDCambio.Location = new System.Drawing.Point(207, 688);
            this.tbCLDCambio.Name = "tbCLDCambio";
            this.tbCLDCambio.Size = new System.Drawing.Size(144, 29);
            this.tbCLDCambio.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 687);
            this.label8.Margin = new System.Windows.Forms.Padding(1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 29);
            this.label8.TabIndex = 69;
            this.label8.Text = "Cambio";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 634);
            this.label7.Margin = new System.Windows.Forms.Padding(1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 67;
            this.label7.Text = "Monto Recibido";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 375);
            this.dataGridView1.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(202, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Usuario: ";
            // 
            // btnFacturarCLD
            // 
            this.btnFacturarCLD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFacturarCLD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(207)))), ((int)(((byte)(182)))));
            this.btnFacturarCLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturarCLD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturarCLD.ForeColor = System.Drawing.Color.Black;
            this.btnFacturarCLD.Location = new System.Drawing.Point(161, 437);
            this.btnFacturarCLD.Name = "btnFacturarCLD";
            this.btnFacturarCLD.Size = new System.Drawing.Size(89, 27);
            this.btnFacturarCLD.TabIndex = 61;
            this.btnFacturarCLD.Text = "Pagar";
            this.btnFacturarCLD.UseVisualStyleBackColor = false;
            this.btnFacturarCLD.Click += new System.EventHandler(this.btnFacturarCLD_Click);
            // 
            // btnEliminarCLD
            // 
            this.btnEliminarCLD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarCLD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(207)))), ((int)(((byte)(182)))));
            this.btnEliminarCLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCLD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCLD.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCLD.Location = new System.Drawing.Point(21, 437);
            this.btnEliminarCLD.Name = "btnEliminarCLD";
            this.btnEliminarCLD.Size = new System.Drawing.Size(89, 27);
            this.btnEliminarCLD.TabIndex = 62;
            this.btnEliminarCLD.Text = "Eliminar";
            this.btnEliminarCLD.UseVisualStyleBackColor = false;
            this.btnEliminarCLD.Click += new System.EventHandler(this.btnEliminarCLD_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(51, 556);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 2);
            this.panel4.TabIndex = 60;
            // 
            // lblTotalCLD
            // 
            this.lblTotalCLD.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCLD.ForeColor = System.Drawing.Color.White;
            this.lblTotalCLD.Location = new System.Drawing.Point(247, 557);
            this.lblTotalCLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblTotalCLD.Name = "lblTotalCLD";
            this.lblTotalCLD.Size = new System.Drawing.Size(131, 29);
            this.lblTotalCLD.TabIndex = 53;
            this.lblTotalCLD.Text = "--";
            this.lblTotalCLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIvaCLD
            // 
            this.lblIvaCLD.BackColor = System.Drawing.Color.Transparent;
            this.lblIvaCLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIvaCLD.ForeColor = System.Drawing.Color.White;
            this.lblIvaCLD.Location = new System.Drawing.Point(253, 511);
            this.lblIvaCLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblIvaCLD.Name = "lblIvaCLD";
            this.lblIvaCLD.Size = new System.Drawing.Size(131, 29);
            this.lblIvaCLD.TabIndex = 54;
            this.lblIvaCLD.Text = "--";
            this.lblIvaCLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTotalCLD
            // 
            this.lblSubTotalCLD.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotalCLD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalCLD.ForeColor = System.Drawing.Color.White;
            this.lblSubTotalCLD.Location = new System.Drawing.Point(253, 480);
            this.lblSubTotalCLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblSubTotalCLD.Name = "lblSubTotalCLD";
            this.lblSubTotalCLD.Size = new System.Drawing.Size(131, 29);
            this.lblSubTotalCLD.TabIndex = 55;
            this.lblSubTotalCLD.Text = "--";
            this.lblSubTotalCLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubTotalCLD.Click += new System.EventHandler(this.lblSubTotalCLD_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 562);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 511);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "IVA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Sub Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "CafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPrecioA6CLD
            // 
            this.lblPrecioA6CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioA6CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA6CLD.Location = new System.Drawing.Point(403, 635);
            this.lblPrecioA6CLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblPrecioA6CLD.Name = "lblPrecioA6CLD";
            this.lblPrecioA6CLD.Size = new System.Drawing.Size(128, 17);
            this.lblPrecioA6CLD.TabIndex = 83;
            this.lblPrecioA6CLD.Text = "--";
            this.lblPrecioA6CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecioA3CLD
            // 
            this.lblPrecioA3CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioA3CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA3CLD.Location = new System.Drawing.Point(407, 425);
            this.lblPrecioA3CLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblPrecioA3CLD.Name = "lblPrecioA3CLD";
            this.lblPrecioA3CLD.Size = new System.Drawing.Size(124, 17);
            this.lblPrecioA3CLD.TabIndex = 81;
            this.lblPrecioA3CLD.Text = "--";
            this.lblPrecioA3CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecioA5CLD
            // 
            this.lblPrecioA5CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioA5CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA5CLD.Location = new System.Drawing.Point(226, 635);
            this.lblPrecioA5CLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblPrecioA5CLD.Name = "lblPrecioA5CLD";
            this.lblPrecioA5CLD.Size = new System.Drawing.Size(128, 17);
            this.lblPrecioA5CLD.TabIndex = 80;
            this.lblPrecioA5CLD.Text = "--";
            this.lblPrecioA5CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecioA2CLD
            // 
            this.lblPrecioA2CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioA2CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA2CLD.Location = new System.Drawing.Point(226, 425);
            this.lblPrecioA2CLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblPrecioA2CLD.Name = "lblPrecioA2CLD";
            this.lblPrecioA2CLD.Size = new System.Drawing.Size(128, 17);
            this.lblPrecioA2CLD.TabIndex = 79;
            this.lblPrecioA2CLD.Text = "--";
            this.lblPrecioA2CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecioA4CLD
            // 
            this.lblPrecioA4CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioA4CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA4CLD.Location = new System.Drawing.Point(44, 635);
            this.lblPrecioA4CLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblPrecioA4CLD.Name = "lblPrecioA4CLD";
            this.lblPrecioA4CLD.Size = new System.Drawing.Size(128, 17);
            this.lblPrecioA4CLD.TabIndex = 78;
            this.lblPrecioA4CLD.Text = "--";
            this.lblPrecioA4CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecioA1CLD
            // 
            this.lblPrecioA1CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioA1CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA1CLD.Location = new System.Drawing.Point(44, 425);
            this.lblPrecioA1CLD.Margin = new System.Windows.Forms.Padding(1);
            this.lblPrecioA1CLD.Name = "lblPrecioA1CLD";
            this.lblPrecioA1CLD.Size = new System.Drawing.Size(128, 17);
            this.lblPrecioA1CLD.TabIndex = 77;
            this.lblPrecioA1CLD.Text = "--";
            this.lblPrecioA1CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameA6CLD
            // 
            this.lblNameA6CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblNameA6CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameA6CLD.ForeColor = System.Drawing.Color.Gray;
            this.lblNameA6CLD.Location = new System.Drawing.Point(403, 613);
            this.lblNameA6CLD.Name = "lblNameA6CLD";
            this.lblNameA6CLD.Size = new System.Drawing.Size(128, 21);
            this.lblNameA6CLD.TabIndex = 76;
            this.lblNameA6CLD.Text = "--";
            this.lblNameA6CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameA5CLD
            // 
            this.lblNameA5CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblNameA5CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameA5CLD.ForeColor = System.Drawing.Color.Gray;
            this.lblNameA5CLD.Location = new System.Drawing.Point(226, 613);
            this.lblNameA5CLD.Name = "lblNameA5CLD";
            this.lblNameA5CLD.Size = new System.Drawing.Size(128, 21);
            this.lblNameA5CLD.TabIndex = 82;
            this.lblNameA5CLD.Text = "--";
            this.lblNameA5CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameA3CLD
            // 
            this.lblNameA3CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblNameA3CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameA3CLD.ForeColor = System.Drawing.Color.Gray;
            this.lblNameA3CLD.Location = new System.Drawing.Point(406, 403);
            this.lblNameA3CLD.Name = "lblNameA3CLD";
            this.lblNameA3CLD.Size = new System.Drawing.Size(128, 21);
            this.lblNameA3CLD.TabIndex = 75;
            this.lblNameA3CLD.Text = "--";
            this.lblNameA3CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameA4CLD
            // 
            this.lblNameA4CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblNameA4CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameA4CLD.ForeColor = System.Drawing.Color.Gray;
            this.lblNameA4CLD.Location = new System.Drawing.Point(44, 613);
            this.lblNameA4CLD.Name = "lblNameA4CLD";
            this.lblNameA4CLD.Size = new System.Drawing.Size(128, 21);
            this.lblNameA4CLD.TabIndex = 74;
            this.lblNameA4CLD.Text = "--";
            this.lblNameA4CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameA2CLD
            // 
            this.lblNameA2CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblNameA2CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameA2CLD.ForeColor = System.Drawing.Color.Gray;
            this.lblNameA2CLD.Location = new System.Drawing.Point(226, 403);
            this.lblNameA2CLD.Name = "lblNameA2CLD";
            this.lblNameA2CLD.Size = new System.Drawing.Size(128, 21);
            this.lblNameA2CLD.TabIndex = 73;
            this.lblNameA2CLD.Text = "--";
            this.lblNameA2CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameA1CLD
            // 
            this.lblNameA1CLD.BackColor = System.Drawing.Color.Transparent;
            this.lblNameA1CLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameA1CLD.ForeColor = System.Drawing.Color.Gray;
            this.lblNameA1CLD.Location = new System.Drawing.Point(44, 403);
            this.lblNameA1CLD.Name = "lblNameA1CLD";
            this.lblNameA1CLD.Size = new System.Drawing.Size(128, 21);
            this.lblNameA1CLD.TabIndex = 72;
            this.lblNameA1CLD.Text = "--";
            this.lblNameA1CLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btcldBebidasC
            // 
            this.btcldBebidasC.BackColor = System.Drawing.Color.LightGray;
            this.btcldBebidasC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcldBebidasC.Location = new System.Drawing.Point(44, 196);
            this.btcldBebidasC.Name = "btcldBebidasC";
            this.btcldBebidasC.Size = new System.Drawing.Size(128, 52);
            this.btcldBebidasC.TabIndex = 84;
            this.btcldBebidasC.Tag = "1";
            this.btcldBebidasC.Text = "Bebidas Calientes";
            this.btcldBebidasC.UseVisualStyleBackColor = false;
            this.btcldBebidasC.Click += new System.EventHandler(this.btcldBebidasC_Click);
            // 
            // btcldBebidasF
            // 
            this.btcldBebidasF.BackColor = System.Drawing.Color.LightGray;
            this.btcldBebidasF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcldBebidasF.Location = new System.Drawing.Point(226, 203);
            this.btcldBebidasF.Name = "btcldBebidasF";
            this.btcldBebidasF.Size = new System.Drawing.Size(128, 38);
            this.btcldBebidasF.TabIndex = 85;
            this.btcldBebidasF.Tag = "2";
            this.btcldBebidasF.Text = "Bebidas Frias";
            this.btcldBebidasF.UseVisualStyleBackColor = false;
            this.btcldBebidasF.Click += new System.EventHandler(this.btcldBebidasC_Click);
            // 
            // btcldPostrea
            // 
            this.btcldPostrea.BackColor = System.Drawing.Color.LightGray;
            this.btcldPostrea.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcldPostrea.Location = new System.Drawing.Point(403, 203);
            this.btcldPostrea.Name = "btcldPostrea";
            this.btcldPostrea.Size = new System.Drawing.Size(128, 38);
            this.btcldPostrea.TabIndex = 86;
            this.btcldPostrea.Tag = "3";
            this.btcldPostrea.Text = "Postres";
            this.btcldPostrea.UseVisualStyleBackColor = false;
            this.btcldPostrea.Click += new System.EventHandler(this.btcldBebidasC_Click);
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // btnBackCLD
            // 
            this.btnBackCLD.BackColor = System.Drawing.Color.Transparent;
            this.btnBackCLD.BackgroundImage = global::Proyecto_Base_de_datos.Properties.Resources.Back;
            this.btnBackCLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackCLD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(90)))), ((int)(((byte)(70)))));
            this.btnBackCLD.FlatAppearance.BorderSize = 0;
            this.btnBackCLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCLD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackCLD.Location = new System.Drawing.Point(44, 682);
            this.btnBackCLD.Name = "btnBackCLD";
            this.btnBackCLD.Size = new System.Drawing.Size(100, 40);
            this.btnBackCLD.TabIndex = 65;
            this.btnBackCLD.UseVisualStyleBackColor = false;
            this.btnBackCLD.Click += new System.EventHandler(this.btnBackCLD_Click);
            // 
            // pBoxA1CLD
            // 
            this.pBoxA1CLD.BackColor = System.Drawing.Color.Transparent;
            this.pBoxA1CLD.Location = new System.Drawing.Point(44, 272);
            this.pBoxA1CLD.Name = "pBoxA1CLD";
            this.pBoxA1CLD.Size = new System.Drawing.Size(128, 128);
            this.pBoxA1CLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxA1CLD.TabIndex = 66;
            this.pBoxA1CLD.TabStop = false;
            this.pBoxA1CLD.Tag = "0";
            this.pBoxA1CLD.Click += new System.EventHandler(this.pBoxA1CLD_Click);
            this.pBoxA1CLD.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxA2CLD_Paint);
            // 
            // pBoxA2CLD
            // 
            this.pBoxA2CLD.BackColor = System.Drawing.Color.Transparent;
            this.pBoxA2CLD.Location = new System.Drawing.Point(226, 272);
            this.pBoxA2CLD.Name = "pBoxA2CLD";
            this.pBoxA2CLD.Size = new System.Drawing.Size(128, 128);
            this.pBoxA2CLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxA2CLD.TabIndex = 71;
            this.pBoxA2CLD.TabStop = false;
            this.pBoxA2CLD.Tag = "1";
            this.pBoxA2CLD.Click += new System.EventHandler(this.pBoxA1CLD_Click);
            this.pBoxA2CLD.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxA2CLD_Paint);
            // 
            // pBoxA4CLD
            // 
            this.pBoxA4CLD.BackColor = System.Drawing.Color.Transparent;
            this.pBoxA4CLD.Location = new System.Drawing.Point(44, 482);
            this.pBoxA4CLD.Name = "pBoxA4CLD";
            this.pBoxA4CLD.Size = new System.Drawing.Size(128, 128);
            this.pBoxA4CLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxA4CLD.TabIndex = 67;
            this.pBoxA4CLD.TabStop = false;
            this.pBoxA4CLD.Tag = "3";
            this.pBoxA4CLD.Click += new System.EventHandler(this.pBoxA1CLD_Click);
            this.pBoxA4CLD.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxA2CLD_Paint);
            // 
            // pBoxA5CLD
            // 
            this.pBoxA5CLD.BackColor = System.Drawing.Color.Transparent;
            this.pBoxA5CLD.Location = new System.Drawing.Point(226, 482);
            this.pBoxA5CLD.Name = "pBoxA5CLD";
            this.pBoxA5CLD.Size = new System.Drawing.Size(128, 128);
            this.pBoxA5CLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxA5CLD.TabIndex = 68;
            this.pBoxA5CLD.TabStop = false;
            this.pBoxA5CLD.Tag = "4";
            this.pBoxA5CLD.Click += new System.EventHandler(this.pBoxA1CLD_Click);
            this.pBoxA5CLD.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxA2CLD_Paint);
            // 
            // pBoxA3CLD
            // 
            this.pBoxA3CLD.BackColor = System.Drawing.Color.Transparent;
            this.pBoxA3CLD.Location = new System.Drawing.Point(403, 272);
            this.pBoxA3CLD.Name = "pBoxA3CLD";
            this.pBoxA3CLD.Size = new System.Drawing.Size(128, 128);
            this.pBoxA3CLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxA3CLD.TabIndex = 69;
            this.pBoxA3CLD.TabStop = false;
            this.pBoxA3CLD.Tag = "2";
            this.pBoxA3CLD.Click += new System.EventHandler(this.pBoxA1CLD_Click);
            this.pBoxA3CLD.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxA2CLD_Paint);
            // 
            // pBoxA6CLD
            // 
            this.pBoxA6CLD.BackColor = System.Drawing.Color.Transparent;
            this.pBoxA6CLD.Location = new System.Drawing.Point(403, 482);
            this.pBoxA6CLD.Name = "pBoxA6CLD";
            this.pBoxA6CLD.Size = new System.Drawing.Size(128, 128);
            this.pBoxA6CLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxA6CLD.TabIndex = 70;
            this.pBoxA6CLD.TabStop = false;
            this.pBoxA6CLD.Tag = "5";
            this.pBoxA6CLD.Click += new System.EventHandler(this.pBoxA1CLD_Click);
            this.pBoxA6CLD.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxA2CLD_Paint);
            // 
            // btncldSalir
            // 
            this.btncldSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btncldSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncldSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncldSalir.FlatAppearance.BorderSize = 0;
            this.btncldSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncldSalir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncldSalir.ForeColor = System.Drawing.Color.White;
            this.btncldSalir.Location = new System.Drawing.Point(485, 692);
            this.btncldSalir.Name = "btncldSalir";
            this.btncldSalir.Size = new System.Drawing.Size(49, 30);
            this.btncldSalir.TabIndex = 87;
            this.btncldSalir.Text = "Salir";
            this.btncldSalir.UseVisualStyleBackColor = false;
            this.btncldSalir.Click += new System.EventHandler(this.btncldSalir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(400, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "Cantidad";
            // 
            // numCLD
            // 
            this.numCLD.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCLD.Location = new System.Drawing.Point(496, 128);
            this.numCLD.Name = "numCLD";
            this.numCLD.Size = new System.Drawing.Size(35, 27);
            this.numCLD.TabIndex = 89;
            this.numCLD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 737);
            this.Controls.Add(this.numCLD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncldSalir);
            this.Controls.Add(this.btcldPostrea);
            this.Controls.Add(this.btnBackCLD);
            this.Controls.Add(this.btcldBebidasF);
            this.Controls.Add(this.btcldBebidasC);
            this.Controls.Add(this.lblPrecioA6CLD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPrecioA3CLD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPrecioA5CLD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPrecioA2CLD);
            this.Controls.Add(this.lblPrecioA1CLD);
            this.Controls.Add(this.lblPrecioA4CLD);
            this.Controls.Add(this.pBoxA1CLD);
            this.Controls.Add(this.pBoxA2CLD);
            this.Controls.Add(this.lblNameA6CLD);
            this.Controls.Add(this.pBoxA4CLD);
            this.Controls.Add(this.lblNameA5CLD);
            this.Controls.Add(this.pBoxA5CLD);
            this.Controls.Add(this.lblNameA3CLD);
            this.Controls.Add(this.pBoxA3CLD);
            this.Controls.Add(this.lblNameA4CLD);
            this.Controls.Add(this.pBoxA6CLD);
            this.Controls.Add(this.lblNameA2CLD);
            this.Controls.Add(this.lblNameA1CLD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA1CLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA2CLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA4CLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA5CLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA3CLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA6CLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCLD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBackCLD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFacturarCLD;
        private System.Windows.Forms.Button btnEliminarCLD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalCLD;
        private System.Windows.Forms.Label lblIvaCLD;
        private System.Windows.Forms.Label lblSubTotalCLD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecioA6CLD;
        private System.Windows.Forms.Label lblPrecioA3CLD;
        private System.Windows.Forms.Label lblPrecioA5CLD;
        private System.Windows.Forms.Label lblPrecioA2CLD;
        private System.Windows.Forms.Label lblPrecioA4CLD;
        private System.Windows.Forms.Label lblPrecioA1CLD;
        private System.Windows.Forms.Label lblNameA6CLD;
        private System.Windows.Forms.Label lblNameA5CLD;
        private System.Windows.Forms.Label lblNameA3CLD;
        private System.Windows.Forms.Label lblNameA4CLD;
        private System.Windows.Forms.Label lblNameA2CLD;
        private System.Windows.Forms.Label lblNameA1CLD;
        private System.Windows.Forms.PictureBox pBoxA6CLD;
        private System.Windows.Forms.PictureBox pBoxA3CLD;
        private System.Windows.Forms.PictureBox pBoxA5CLD;
        private System.Windows.Forms.PictureBox pBoxA4CLD;
        private System.Windows.Forms.PictureBox pBoxA2CLD;
        private System.Windows.Forms.PictureBox pBoxA1CLD;
        private System.Windows.Forms.Button btcldBebidasC;
        private System.Windows.Forms.Button btcldBebidasF;
        private System.Windows.Forms.Button btcldPostrea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbCLDCambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private CafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private CafeDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.Button btnResetearCLD;
        private System.Windows.Forms.Button btncldSalir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numCLD;
        private System.Windows.Forms.MaskedTextBox tbCLDMonto;
    }
}