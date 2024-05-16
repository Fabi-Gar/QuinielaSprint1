using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace QuinielaSprint1.Modelos
{
    internal class Conexiones
    {
        public static class Miconexion
        {
            public static SqlConnection conexion;

            public static void abrir_conexion()
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ConnectionString;
                    conexion = new SqlConnection(connectionString);

                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open();
                    }
                    else { MessageBox.Show("error"); }
                }
                catch (Exception ex) { MessageBox.Show("error " + ex); }
            }

            public static ConnectionState ObtenerEstadoConexion()
            {
                return conexion.State;
            }

            public static string Log_in(string nombreUsuario, string contraseña)
            {
                string rolUsuario = "";

                try
                {
                    abrir_conexion();

                    SqlCommand cmd = new SqlCommand("ValidarUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        rolUsuario = reader["Rol"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }

                return rolUsuario;
            }
        }
    }
}