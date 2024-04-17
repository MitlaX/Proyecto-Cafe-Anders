using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Base_de_datos
{
    public partial class FormVenta : Form
    {
        string achivodb = ("Provider=Microsoft.Ace.OLEDB.12.0; Data Source=Cafe.accdb");
        OleDbConnection conector;
        OleDbDataAdapter adaptador;
        OleDbCommandBuilder actualizardb;
        Button lastButtonClicked = new Button();
        public FormVenta()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

            NewSale();
            btcldBebidasC_Click(btcldBebidasC, null);
            label4.Text = "Usuario: " + Program.nombreUsuario;
            DateTime today = DateTime.Today;
            label6.Text = "Fecha: " + today.ToShortDateString();
        }
        public DataTable conectar(string cmdQuery)
        {
            DataTable table = new DataTable();
            try
            {

                conector = new OleDbConnection(achivodb);
                conector.Open();
                adaptador = new OleDbDataAdapter(cmdQuery, conector);
                actualizardb = new OleDbCommandBuilder(adaptador);

                adaptador.Fill(table);

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("archivo no encontrado");
            }
            return table;
        }

        public int UpdateDB(string SqlText)
        {
            OleDbConnection connect = new OleDbConnection(achivodb);

            OleDbCommand command = new OleDbCommand(SqlText, connect);
            int ra = 0;

            try
            {
                connect.Open();
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.Source);
            }
            try
            {
                ra = command.ExecuteNonQuery();
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.Source);
            }
            finally
            {
                connect.Close();
            }
            return ra;
        }

        public object ExecuteScalarDB(string SqlText)
        {
            OleDbConnection connect = new OleDbConnection(achivodb);

            OleDbCommand command = new OleDbCommand(SqlText, connect);
            object ra = 0;

            try
            {
                connect.Open();
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.Source);
            }
            try
            {
                ra = command.ExecuteScalar();
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.Source);
            }
            finally
            {
                connect.Close();
            }
            return ra;
        }

        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            if (Program.rol == "cajero")
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
        private void Clear()
        {
            this.Invalidate();

            for (int i = 1; i <= 6; i++)
            {
                PictureBox pb = ((PictureBox)this.Controls[string.Format("pBoxA{0}CLD", i)]);
                pb.Image = null;
                pb.Enabled = false;

                Label lbl = ((Label)this.Controls[string.Format("lblNameA{0}CLD", i)]);
                lbl.Text = "";
                Label lblPrecio = ((Label)this.Controls[string.Format("lblPrecioA{0}CLD", i)]);
                lblPrecio.Text = "";
            }
        }

        private void NewSale()
        {
            string sqlText = "DELETE FROM TICKET;";
            int ra = UpdateDB(sqlText);
            LoadTicket();
        }

        private void btcldBebidasC_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            lastButtonClicked = b;
            string sqlCmd = string.Format("SELECT * FROM Productos WHERE Categoria ={0}", b.Tag.ToString());
            DataTable dt = conectar(sqlCmd);

            Clear();
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                PictureBox pb = ((PictureBox)this.Controls[string.Format("pBoxA{0}CLD", i)]);
                ((Label)this.Controls[string.Format("lblNameA{0}CLD", i)]).Text = dr["nombre"].ToString();
                this.Controls[string.Format("lblPrecioA{0}CLD", i)].Text = "$ " + dr["precio"].ToString();
                pb.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Imagenes\\" + dr["RutaImagen"].ToString());
                pb.Tag = dr;
                int Existencia = Convert.ToInt32(dr["Cantidad"]);
                if (Existencia > 0)
                    pb.Enabled = true;
                i++;
            }
        }

        private void pBoxA1CLD_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            AgregarATicket((DataRow)pb.Tag);
        }

        private void AgregarATicket(DataRow row)
        {
            string sqlText = string.Format("SELECT Cantidad from Productos where Id = {0}", row["id"]);
            int Existencia = 0;
            int.TryParse(ExecuteScalarDB(sqlText).ToString(), out Existencia);

            if (Existencia < 5)
                MessageBox.Show(string.Format("Alerta cantidad en inventario {0}", Existencia));

            if (numCLD.Value > Existencia)
                MessageBox.Show("No hay suficiente existencia para esta cantidad");
            else
            {
                string sqlText1 = string.Format("UPDATE Productos SET Cantidad = Cantidad - {0} WHERE Cantidad >0 and id = {1}", numCLD.Value, row["id"]);

                int ra = UpdateDB(sqlText1);

                if (ra >= 1)
                {
                    string sqlText2 = string.Format("INSERT INTO TICKET (Nombre, Cantidad, Precio) SELECT Nombre, {0} as cantidad, Precio  FROM  Productos WHERE id = {1}", numCLD.Value, row["id"]);
                    ra = UpdateDB(sqlText2);

                    LoadTicket();
                    ActualizarPrecios();
                }
            }
            btcldBebidasC_Click(lastButtonClicked, null);
        }

        private void LoadTicket()
        {
            String TicketSql = "SELECT * FROM TICKET";

            dataGridView1.DataSource = conectar(TicketSql);
            dataGridView1.Columns["Id"].Visible = false;

        }

        private void ActualizarPrecios()
        {
            if (dataGridView1.RowCount > 0)
            {
                String SubtotalesSql = "SELECT sum (precio * Cantidad) as Subtotal FROM TICKET";
                DataTable dt = conectar(SubtotalesSql);

                double subTotal = (double)dt.Rows[0].Field<decimal>("Subtotal");
                double iva = subTotal * .08;
                double total = subTotal + iva;

                lblSubTotalCLD.Text = "$ " + subTotal;
                lblIvaCLD.Text = "$ " + iva;
                lblTotalCLD.Text = "$ " + total;
            }
            else
            {
                lblSubTotalCLD.Text = "$ " + 0;
                lblIvaCLD.Text = "$ " + 0;
                lblTotalCLD.Text = "$ " + 0;
            }
        }

        private void btnEliminarCLD_Click(object sender, EventArgs e)
        {
            int ra = UpdateDB("DELETE * FROM TICKET WHERE id = " + dataGridView1.SelectedRows[0].Cells["iD"].Value);
            LoadTicket();
            ActualizarPrecios();
        }

        private void btnFacturarCLD_Click(object sender, EventArgs e)
        {
            
            if (tbCLDMonto.Text == "")
            {
                MessageBox.Show("Porfavor Introdusca un monto");
            }
            else
            {
                double total = double.Parse(lblTotalCLD.Text.Remove(0, 1));
                double monto = double.Parse(tbCLDMonto.Text);
                if (monto < total)
                {
                    MessageBox.Show("El monto es menor al total");
                }
                else
                {
                    tbCLDCambio.Text = "$ " + (monto - total);
                    tbCLDMonto.Clear();
               }            
            }
        }
        private void btnResetearCLD_Click(object sender, EventArgs e)
        {
            Clear();
            NewSale();
            lblSubTotalCLD.Text = "$ " + 0;
            lblIvaCLD.Text = "$ " + 0;
            lblTotalCLD.Text = "$ " + 0;
            tbCLDMonto.Clear();
            tbCLDCambio.Clear();
            btcldBebidasC_Click(btcldBebidasC, null);
        }

        private void btncldSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                Application.Exit();
        }

        private void pBoxA2CLD_Paint(object sender, PaintEventArgs e)
        {

            PictureBox pb =  (PictureBox)sender;
            if (!pb.Enabled)
            {
                using (Brush fBrush = new SolidBrush(Color.FromArgb(171, 71, 71, 71)))
                    e.Graphics.FillRectangle(fBrush, pb.ClientRectangle);
            }
        }

        private void lblSubTotalCLD_Click(object sender, EventArgs e)
        {

        }
    }
}
