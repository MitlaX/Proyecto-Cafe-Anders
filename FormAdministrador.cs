using System;
using System.Windows.Forms;

namespace Proyecto_Base_de_datos
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            lblBienvenidaCLD.Text = "Bienvenid@ " + Program.nombreUsuario;
        }


        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            if (Program.formLogin == null)
                Program.formLogin = new FormLogin();
            Program.formLogin.Show();
            this.Hide();
        }

        private void pbAlimentosCLD_Click(object sender, EventArgs e)
        {
            if (Program.FormSurtir == null)
                Program.FormSurtir = new FormProductos();
            Program.FormSurtir.Show();
            this.Hide();
        }

        private void pbMenuCLD_Click(object sender, EventArgs e)
        {
            if (Program.formMenu == null)
                Program.formMenu = new FormVenta();
            Program.formMenu.Show();
            this.Hide();
        }

        private void pbEmpleadosCLD_Click(object sender, EventArgs e)
        {
            if (Program.formEmpleados == null)
                Program.formEmpleados = new FormEmpleados();
            Program.formEmpleados.Show();
            this.Hide();
        }

        private void btncldSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                Application.Exit();
        }
    }
}
