using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Proyecto_Base_de_datos
{
    public partial class FormProductos : Form
    {
        Computer mycomputer = new Computer();
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormSurtir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet1.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter1.Fill(this.cafeDataSet1.Productos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Guardar Cambios?", "Mensage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.productosTableAdapter1.Update(cafeDataSet1.Productos);             
                dataGridView1.Refresh();
                MessageBox.Show("Tabla Actualizada");
                Program.FormSurtir = new FormProductos();
                Program.FormSurtir.Show();
                this.Close();


            }
        }

        private void btncldEliminar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string copia ;
                ofdcldImagen.ShowDialog();
                if (ofdcldImagen.FileName != null)
                {
                    senderGrid.CurrentCell.Value = Path.GetFileName(ofdcldImagen.FileName);
                    copia = @"" + Directory.GetCurrentDirectory() + "\\Imagenes\\" + ofdcldImagen.FileName.Substring(ofdcldImagen.FileName.LastIndexOf(@"\"));
                    mycomputer.FileSystem.CopyFile(ofdcldImagen.FileName, copia);
                    //pbcldNuevoFoto.Image = Image.FromFile(ofdcldImagen.FileName);
                }
            }
        }

        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            if (Program.rol == "Cajero")
            {
                if (Program.formLogin == null)
                    Program.formLogin = new FormLogin();
                Program.formLogin.Show();
                this.Hide();
            }
            else
            {
                if (Program.formAdministrador == null)
                    Program.formAdministrador = new FormAdministrador();
                Program.formAdministrador.Show();
                this.Hide();
            }
        }
    }
}
