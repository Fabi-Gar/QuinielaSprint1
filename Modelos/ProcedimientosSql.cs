using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuinielaSprint1.Modelos.Conexiones;
using System.Security.Cryptography;
using System.Text;


namespace QuinielaSprint1.Modelos
{
    internal class ProcedimientosSql
    {
        public string ObtenerNombreUsuario(string nombreUsuario, string contraseña)
        {
            string nombre = "";

            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand("ObtenerNombreUsuario", Miconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contraseña);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nombre = reader["Usuario"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Miconexion.conexion.State == ConnectionState.Open)
                {
                    Miconexion.conexion.Close();
                }
            }

            return nombre;
        }

        public int ObtenerIdUsuario(string nombreUsuario, string contraseña)
        {
            int idUsuario = -1;

            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand("ObtenerIdUsuario", Miconexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contraseña);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    idUsuario = Convert.ToInt32(reader["idUsuario"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Miconexion.conexion.State == ConnectionState.Open)
                {
                    Miconexion.conexion.Close();
                }
            }

            return idUsuario;
        }

        public static void AgregarEquipo(string nomEquipo)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarEquipo";
                cmd.Connection = Miconexion.conexion;

                cmd.Parameters.Add(new SqlParameter("@Equipo", nomEquipo));


                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipo Agregado Exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salio mal " + ex.Message);
            }
        }

        public static void AgregarPartido(DateTime fecha, string idEquipoLocal, string idEquipoVisitante)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarPartido";
                cmd.Connection = Miconexion.conexion;

                // Configuración de los parámetros
                cmd.Parameters.Add(new SqlParameter("@Fecha", fecha));
                cmd.Parameters.Add(new SqlParameter("@idLocal", idEquipoLocal));
                cmd.Parameters.Add(new SqlParameter("@idVisitante", idEquipoVisitante));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Partido Agregado Exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal " + ex.Message);
            }

        }

        public static void InsertarResultado(string idPartido, string idEquipoGanador, string resultado)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarResultado";
                cmd.Connection = Miconexion.conexion;

                // Configurar parámetros
                
                cmd.Parameters.Add(new SqlParameter("@idPartido", idPartido));
                cmd.Parameters.Add(new SqlParameter("@idEquipoGanador", idEquipoGanador));
                cmd.Parameters.Add(new SqlParameter("@Resultado", resultado));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Resultado insertado exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar resultado: " + ex.Message);
            }
        }


        public static void InsertarQuiniela(string idUsuario, DateTime fecha)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarQuiniela";
                cmd.Connection = Miconexion.conexion;

                

                cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                cmd.Parameters.Add(new SqlParameter("@Fecha", fecha));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Quiniela insertada exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar quiniela: " + ex.Message);
            }
        }

        public static void InsertarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarUsuario";
                cmd.Connection = Miconexion.conexion;



                cmd.Parameters.Add(new SqlParameter("@Usuario", nombreUsuario));
                cmd.Parameters.Add(new SqlParameter("@Contraseña", contraseña));
                cmd.Parameters.Add(new SqlParameter("@Rol", "Usuario"));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Creado exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
        }

        public static void InsertarPuntos(string idUsuario, string puntos)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarQuiniela";
                cmd.Connection = Miconexion.conexion;



                cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                cmd.Parameters.Add(new SqlParameter("@Puntos", puntos));
             

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Creado exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
        }
    }
}
