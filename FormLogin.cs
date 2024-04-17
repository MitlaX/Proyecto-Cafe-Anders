using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Base_de_datos
{
    public partial class FormLogin : Form
    {
        string achivodb = ("Provider=Microsoft.Ace.OLEDB.12.0; Data Source=Cafe.accdb");
        OleDbConnection conector;
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder actualizardb;
        DataTable tabla;
        DataRow renglontabla;

        int contIntentos = 0;
        string idUsuario, usuario;
        bool encontrado = false;

        bool mostrar = true;
        public FormLogin()
        {
            InitializeComponent();
        }
        public void Hora()
        {
            DateTime time = DateTime.Now;
            DateTime dia = DateTime.Today.AddHours(12D);
            DateTime noche = DateTime.Today.AddHours(20D);
            if (time < dia)
                lblSaludoCLD.Text = "Buenos dias!";
            else if (time < noche)
                lblSaludoCLD.Text = "Buenas tardes!";
            else
                lblSaludoCLD.Text = "Buenas noches!";
        }
        public void conectar(string cmdQuery)
        {
            try
            {
                conector = new OleDbConnection(achivodb);
                conector.Open();
                adaptador = new OleDbDataAdapter(cmdQuery, conector);
                actualizardb = new OleDbCommandBuilder(adaptador);
                tabla = new DataTable();
                adaptador.Fill(tabla);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("archivo no encontrado");
            }
        }
        public void Comprueba()
        {
            conectar("SELECT id_usuario, usuario, contraseña FROM Usuarios");
            if (contIntentos <= 2) // Al tercer intento fallido se bloquea
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    renglontabla = tabla.Rows[i];
                    if (renglontabla["usuario"].ToString() == tBoxUsuarioCLD.Text && renglontabla["contraseña"].ToString() == tBoxPasswordCLD.Text)
                    {
                        encontrado = true;
                        idUsuario = renglontabla["id_usuario"].ToString();
                        usuario = renglontabla["usuario"].ToString();
                        break;
                    }
                }
                if (encontrado)
                {
                    contIntentos = 0;
                    Program.nombreUsuario = renglontabla["usuario"].ToString();
                    conectar("SELECT rol FROM Usuarios WHERE id_usuario =" + idUsuario + "");
                    renglontabla = tabla.Rows[0];
                    Program.rol = renglontabla["rol"].ToString();
                    switch (renglontabla["rol"].ToString())
                    {
                        case "administrador":
                            MessageBox.Show("Bienvenid@ " + usuario, "Administrador");
                            if (Program.formAdministrador == null)
                                Program.formAdministrador = new FormAdministrador();
                            Program.formAdministrador.Show();
                            this.Hide();
                            break;
                        case "cajero":
                            MessageBox.Show("Bienvenid@ " + usuario, "Cajero");
                            if (Program.formMenu == null)
                                Program.formMenu = new FormVenta();
                            Program.formMenu.Show();
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    tBoxUsuarioCLD.Clear();
                    tBoxPasswordCLD.Clear();
                    tBoxUsuarioCLD.Focus();
                    MessageBox.Show("Intenta de Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contIntentos++;
                }
            }
            else
            {
                MessageBox.Show("Intentos maximos alcanzados.", "Atencion!", MessageBoxButtons.OK);
                btnLoginCLD.Enabled = false;
            }
        }

        private void btnLoginCLD_Click(object sender, EventArgs e)
        {
            Comprueba();
        }

        private void btncldSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                Application.Exit();
        }

        private void pBoxMostrarCCM_Click(object sender, EventArgs e)
        {
            if (mostrar)
            {
                tBoxPasswordCLD.PasswordChar = '\0';
                mostrar = false;
            }

            else
                tBoxPasswordCLD.PasswordChar = '*';
        }
    }
}
