using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuinielaSprint1.Modelos.Conexiones;
using System.Windows.Forms;

namespace QuinielaSprint1.Modelos
{
    internal class obtenerTablas
    {
        public DataTable TablaListaUsuarios()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarUsuarios";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }

        public DataTable TablaPartidos()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarTodosLosPartidos";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }

        public DataTable TablaEquipos()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarEquipos";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }

        

        public DataTable TablaResultadosConEquipos()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarResultadosConPartidos";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }

        

        public DataTable TablaTodosLosPronosticos()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarPronosticos";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }
    }
}
