using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Base_de_datos
{
    internal static class Program
    {
        public static string nombreUsuario;
        public static string rol;
        public static FormAdministrador formAdministrador = null;
        public static FormCarga formCarga = null;
        public static FormLogin formLogin = null;
        public static FormVenta formMenu = null;
        public static FormProductos FormSurtir = null;
        public static FormEmpleados formEmpleados = null;   
       /// <summary>
       /// The main entry point for the application.
       /// </summary>
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAdministrador());
        }
    }
}
