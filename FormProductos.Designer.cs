namespace Proyecto_Base_de_datos
{
    partial class FormProductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet1 = new Proyecto_Base_de_datos.CafeDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.productosTableAdapter1 = new Proyecto_Base_de_datos.CafeDataSetTableAdapters.ProductosTableAdapter();
            this.btncldEliminar = new System.Windows.Forms.Button();
            this.ofdcldImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnBackCLD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.productosBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 339);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RutaImagen";
            this.dataGridViewTextBoxColumn5.HeaderText = "RutaImagen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.cafeDataSet1;
            // 
            // cafeDataSet1
            // 
            this.cafeDataSet1.DataSetName = "CafeDataSet";
            this.cafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(693, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 39);
            this.button3.TabIndex = 70;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // btncldEliminar
            // 
            this.btncldEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncldEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncldEliminar.Location = new System.Drawing.Point(556, 378);
            this.btncldEliminar.Name = "btncldEliminar";
            this.btncldEliminar.Size = new System.Drawing.Size(116, 39);
            this.btncldEliminar.TabIndex = 69;
            this.btncldEliminar.Text = "Eliminar";
            this.btncldEliminar.UseVisualStyleBackColor = true;
            this.btncldEliminar.Click += new System.EventHandler(this.btncldEliminar_Click);
            // 
            // ofdcldImagen
            // 
            this.ofdcldImagen.FileName = "openFileDialog1";
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
            this.btnBackCLD.Location = new System.Drawing.Point(12, 377);
            this.btnBackCLD.Name = "btnBackCLD";
            this.btnBackCLD.Size = new System.Drawing.Size(100, 40);
            this.btnBackCLD.TabIndex = 71;
            this.btnBackCLD.UseVisualStyleBackColor = false;
            this.btnBackCLD.Click += new System.EventHandler(this.btnBackCLD_Click);
            // 
            // FormSurtir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 429);
            this.Controls.Add(this.btnBackCLD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btncldEliminar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSurtir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSurtir";
            this.Load += new System.EventHandler(this.FormSurtir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private CafeDataSet cafeDataSet;
        private CafeDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaImagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private CafeDataSet cafeDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private CafeDataSetTableAdapters.ProductosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.Button btncldEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.OpenFileDialog ofdcldImagen;
        private System.Windows.Forms.Button btnBackCLD;
    }
}