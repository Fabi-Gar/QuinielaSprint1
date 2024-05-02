using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuinielaSprint1.Modelos.Conexiones;

namespace QuinielaSprint1.Modelos
{
    internal class ProcedimientosSql
    {

        public static string[] ObtenerId(string usuario)
        {
            string[] resultados = new string[2]; // Array para almacenar los resultados

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
                    resultados[0] = rs.GetString(0); // Almacenar el ID de usuario
                    resultados[1] = rs.GetString(1); // Almacenar el nombre de usuario
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); // Imprimir el error en la consola
            }
            finally
            {
                cmd.Dispose();
            }

            return resultados;
        }

        public static void AgregarEquipo(string nomEquipo)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AgregarEquipo";
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
                cmd.CommandText = "AgregarPartido";
                cmd.Connection = Miconexion.conexion;

                // Configuración de los parámetros
                cmd.Parameters.Add(new SqlParameter("@Fecha", fecha));
                cmd.Parameters.Add(new SqlParameter("@idEquipoLocal", idEquipoLocal));
                cmd.Parameters.Add(new SqlParameter("@idEquipoVisitante", idEquipoVisitante));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Partido Agregado Exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal " + ex.Message);
            }

        }

        public static void InsertarResultado(string resultado, string idPartido)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AgregarResultado";
                cmd.Connection = Miconexion.conexion;

                // Configurar parámetros
                cmd.Parameters.Add(new SqlParameter("@Resultado", resultado));
                cmd.Parameters.Add(new SqlParameter("@idPartido", idPartido));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Resultado insertado exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar resultado: " + ex.Message);
            }

        }

        


    }
}
