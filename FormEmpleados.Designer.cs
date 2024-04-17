namespace Proyecto_Base_de_datos
{
    partial class FormEmpleados
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
            this.btnBackCLD = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btncldEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet = new Proyecto_Base_de_datos.CafeDataSet();
            this.usuariosTableAdapter = new Proyecto_Base_de_datos.CafeDataSetTableAdapters.UsuariosTableAdapter();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.btnBackCLD.Location = new System.Drawing.Point(12, 363);
            this.btnBackCLD.Name = "btnBackCLD";
            this.btnBackCLD.Size = new System.Drawing.Size(100, 40);
            this.btnBackCLD.TabIndex = 75;
            this.btnBackCLD.UseVisualStyleBackColor = false;
            this.btnBackCLD.Click += new System.EventHandler(this.btnBackCLD_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(484, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 39);
            this.button3.TabIndex = 74;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncldEliminar
            // 
            this.btncldEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncldEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncldEliminar.Location = new System.Drawing.Point(330, 363);
            this.btncldEliminar.Name = "btncldEliminar";
            this.btncldEliminar.Size = new System.Drawing.Size(116, 39);
            this.btncldEliminar.TabIndex = 73;
            this.btncldEliminar.Text = "Eliminar";
            this.btncldEliminar.UseVisualStyleBackColor = true;
            this.btncldEliminar.Click += new System.EventHandler(this.btncldEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 339);
            this.dataGridView1.TabIndex = 72;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "CafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 420);
            this.Controls.Add(this.btnBackCLD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btncldEliminar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pr";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackCLD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncldEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private CafeDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
    }
}