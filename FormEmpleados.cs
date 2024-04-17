using System;
using System.Windows.Forms;

namespace Proyecto_Base_de_datos
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.cafeDataSet.Usuarios);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Guardar Cambios?", "Mensage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.usuariosTableAdapter.Update(cafeDataSet.Usuarios);
                dataGridView1.Refresh();
                MessageBox.Show("Tabla Actualizada");
                Program.formEmpleados = new FormEmpleados();
                Program.formEmpleados.Show();
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
        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            Program.formAdministrador = new FormAdministrador();
            Program.formAdministrador.Show();
            this.Hide();
        }
    }
}
