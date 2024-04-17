using System;
using System.Windows.Forms;

namespace Proyecto_Base_de_datos
{
    public partial class FormCarga : Form
    {
        int cont = 0;
        public FormCarga()
        {
            InitializeComponent();

        }

        private void timerCLD_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            cont= cont+2;

            if (cont == 110)
            {
                this.Hide();
                Program.formLogin = new FormLogin();
                Program.formLogin.Show();
            }
        }
    }
}
