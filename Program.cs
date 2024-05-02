using QuinielaSprint1.Controlador;
using QuinielaSprint1.Modelos;
using QuinielaSprint1.Vistas;
using QuinielaSprint1.Vistas.VistasAdicionales;
using QuinielaSprint1.Vistas.VistasUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinielaSprint1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Modelos
            Conexiones conexiones = new Conexiones();
            logicaDeNegocios logicaDeNegocios = new logicaDeNegocios();
            obtenerTablas obtenerTablas = new obtenerTablas();
            ProcedimientosSql procedimientosSql = new ProcedimientosSql();


            //vistas Administrador
            vistaAgregarEquipo vistaAgregarEquipo = new vistaAgregarEquipo();
            vistaAgregarPartido vistaAgregarPartido = new vistaAgregarPartido();
            vistaListaUsuarios vistaListaUsuarios   = new vistaListaUsuarios();
            vistaPronosticoAdmin vistaPronosticoAdmin = new vistaPronosticoAdmin();
            vistaResultado vistaResultado = new vistaResultado();

            //Vistas Cliente

            vistaMisPuntosUsuario vistaMisPuntosUsuario = new vistaMisPuntosUsuario();
            vistaPartidosUsuario vistaPartidosUsuario = new vistaPartidosUsuario();
            vistaPronosticosUsuario vistaPronosticosUsuario = new vistaPronosticosUsuario();

            //Vistas Generales

            Login vistaLogin = new Login();
            vistaAdministrador vistaAdministrador = new vistaAdministrador();
            vistaCliente vistaCliente = new vistaCliente();
            vistaCrearUsuario vistaCrearUsuario = new vistaCrearUsuario();

            quinielaControl controlPrograma = new 
                quinielaControl(conexiones,logicaDeNegocios,
                obtenerTablas,procedimientosSql,vistaAgregarEquipo,
                vistaAgregarPartido,vistaListaUsuarios,vistaPronosticoAdmin,
                vistaResultado,vistaMisPuntosUsuario,vistaPartidosUsuario,vistaPronosticosUsuario
                ,vistaLogin,vistaAdministrador,vistaCliente,vistaCrearUsuario);







            Application.Run();
        }
    }
}
