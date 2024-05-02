using QuinielaSprint1.Modelos;
using QuinielaSprint1.Vistas;
using QuinielaSprint1.Vistas.VistasAdicionales;
using QuinielaSprint1.Vistas.VistasUsuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinielaSprint1.Controlador
{
    internal class quinielaControl
    {
        //Modelos
        Conexiones MetodosSQL;
        logicaDeNegocios logicaProgramacion;
        obtenerTablas obtenerDatosTablas;
        ProcedimientosSql procedimientosAlmacenados;

        //Vistas Administrador
        vistaAgregarEquipo vistaAgregarEquipo;
        vistaAgregarPartido vistaAgregarPartido;
        vistaListaUsuarios vistaListaUsuarios;
        vistaPronosticoAdmin vistaPronosticoAdmin;
        vistaResultado vistaResultado;

        //Vistas Cliente
        vistaMisPuntosUsuario vistaMisPuntosUsuario;
        vistaPartidosUsuario vistaPartidosUsuario;
        vistaPronosticosUsuario vistaPronosticosUsuario;

        //vistas Generales

        Login vistaLogin;
        vistaAdministrador vistaAdministrador;
        vistaCliente vistaCliente;
        vistaCrearUsuario vistaCrearUsuario;

        public quinielaControl(Conexiones metodosSQL, logicaDeNegocios logicaProgramacion, 
            obtenerTablas obtenerDatosTablas, ProcedimientosSql procedimientosAlmacenados, 
            vistaAgregarEquipo vistaAgregarEquipo, vistaAgregarPartido vistaAgregarPartido, 
            vistaListaUsuarios vistaListaUsuarios, vistaPronosticoAdmin vistaPronosticoAdmin, 
            vistaResultado vistaResultado, vistaMisPuntosUsuario vistaMisPuntosUsuario, 
            vistaPartidosUsuario vistaPartidosUsuario, vistaPronosticosUsuario vistaPronosticosUsuario, 
            Login vistaLogin, vistaAdministrador vistaAdministrador, vistaCliente vistaCliente, vistaCrearUsuario vistaCrearUsuario)
        {
            MetodosSQL = metodosSQL;
            this.logicaProgramacion = logicaProgramacion;
            this.obtenerDatosTablas = obtenerDatosTablas;
            this.procedimientosAlmacenados = procedimientosAlmacenados;
            this.vistaAgregarEquipo = vistaAgregarEquipo;
            this.vistaAgregarPartido = vistaAgregarPartido;
            this.vistaListaUsuarios = vistaListaUsuarios;
            this.vistaPronosticoAdmin = vistaPronosticoAdmin;
            this.vistaResultado = vistaResultado;
            this.vistaMisPuntosUsuario = vistaMisPuntosUsuario;
            this.vistaPartidosUsuario = vistaPartidosUsuario;
            this.vistaPronosticosUsuario = vistaPronosticosUsuario;
            this.vistaLogin = vistaLogin;
            this.vistaAdministrador = vistaAdministrador;
            this.vistaCliente = vistaCliente;
            this.vistaCrearUsuario = vistaCrearUsuario;

            //Vista Login
            vistaLogin.btnIniciarSesion.Click += clickBoton;
            vistaLogin.btnCrearCuenta.Click += clickBoton;
            vistaLogin.Show();

            //Vista Administrador
            vistaAdministrador.btnAgregarEquipo.Click += clickBoton;
            vistaAdministrador.btnAgregarPartido.Click += clickBoton;
            vistaAdministrador.btnPronostico.Click += clickBoton;
            vistaAdministrador.btnResultado.Click += clickBoton;
            vistaAdministrador.btnUsuariosRegistrados.Click += clickBoton;
            

        }

        private void AbrirForm(object formHeredado)
        {
            if (vistaAdministrador.panelCentral.Controls.Count > 0) vistaAdministrador.panelCentral.Controls.RemoveAt(0);
            Form fr = formHeredado as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            vistaAdministrador.panelCentral.Controls.Add(fr);
            vistaAdministrador.panelCentral.Tag = fr;
            fr.Show();
        }




        private void clickBoton(object sender, EventArgs e)
        {

            // Inicia Sesion y muestra la ventana segun el rol del usuario
            if (sender == vistaLogin.btnIniciarSesion)
            {
                if (sender == vistaLogin.btnIniciarSesion)
                {
                    Conexiones.Miconexion.user = vistaLogin.txtUsuario.Text;
                    Conexiones.Miconexion.pass = vistaLogin.txtContraseña.Text;
                    Conexiones.Miconexion.abrir_conexion();

                    System.Data.ConnectionState estadoCOnexion = Conexiones.Miconexion.ObtenerEstadoConexion();


                    vistaLogin.Hide();
                    if (estadoCOnexion == System.Data.ConnectionState.Open)
                    {
                        if (Conexiones.Miconexion.ObtenerRol(vistaLogin.txtUsuario.Text) == "admin")
                        { vistaAdministrador.ShowDialog(); }

                        else if (Conexiones.Miconexion.ObtenerRol(vistaLogin.txtUsuario.Text) == "Tecnico")
                        { vistaCliente.ShowDialog(); }

                        else
                        { MessageBox.Show("El usuario no existe"); }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

            //Control de forms vista administrador
            if (sender == vistaAdministrador.btnAgregarEquipo)
            {
                AbrirForm(new vistaAgregarEquipo());
            }

            if (sender == vistaAdministrador.btnAgregarPartido)
            { AbrirForm(new vistaAgregarPartido()); }

            if (sender == vistaAdministrador.btnPronostico)
            { AbrirForm(new vistaPronosticoAdmin()); }

            if (sender == vistaAdministrador.btnResultado)
            { AbrirForm(new vistaResultado()); }

            if (sender == vistaAdministrador.btnUsuariosRegistrados)
            { 
                AbrirForm(new vistaListaUsuarios());
                

            }
        }
    }
}
