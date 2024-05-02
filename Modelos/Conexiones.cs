using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinielaSprint1.Modelos
{
    internal class Conexiones
    {
        public static class Miconexion
        {
            public static SqlConnection conexion;

            //Estas variables son cambiadas por el login al ser incorrectas no se hace la conexion
            public static String user;
            public static String pass;

            public static void abrir_conexion()
            {
                try
                {
                    //Este es el nombre de conexion para conectar a la base de datos
                    conexion = new SqlConnection("Data Source=34.16.213.5; Initial Catalog =Quiniela; Persist Security Info = True; User ID = " + user + "; Password = " + pass + "; TrustServerCertificate = True");

                    //Este if cambia el estado de conexion cerrada a abierta
                    if (conexion.State == System.Data.ConnectionState.Closed)
                    {
                        conexion.Open();
                    }
                    else { MessageBox.Show("error"); }
                }
                catch (Exception ex) { MessageBox.Show("error " + ex); }
            }


            //Con este metodo se obtiene el estado de la conexion
            public static System.Data.ConnectionState ObtenerEstadoConexion()
            {
                return conexion.State;
            }

            //se obtiene el rol del usuario
            public static string ObtenerRol(string usuario)
            {
                string rolUsuario = "";
                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "buscarRol";
                    cmd.Connection = Miconexion.conexion;

                    cmd.Parameters.Add(new SqlParameter("@nomUsuario", usuario));

                    SqlDataReader rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        rs.Read();
                        rolUsuario = rs.GetString(0);
                    }
                }
                catch (Exception ex) { Console.Write(ex); }

                finally { cmd.Dispose(); }

                return rolUsuario;
            }

            public static string ObtenerId(string usuario)
            {
                string idUsuario = "";
                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "obtenerId";
                    cmd.Connection = Miconexion.conexion;

                    cmd.Parameters.Add(new SqlParameter("@nomUsuario", usuario));

                    SqlDataReader rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        rs.Read();
                        idUsuario = rs.GetString(0);
                    }
                }
                catch (Exception ex) { Console.Write(ex); }

                finally { cmd.Dispose(); }

                return idUsuario;
            }

        }
    }
}
