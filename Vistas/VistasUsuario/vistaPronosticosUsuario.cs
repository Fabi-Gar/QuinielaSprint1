using QuinielaSprint1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinielaSprint1.Vistas.VistasUsuario
{
    public partial class vistaPronosticosUsuario : Form
    {
        public vistaPronosticosUsuario()
        {
            InitializeComponent();

            dtPartidos.RowHeadersWidth = 25;
           

        }

        string Equipo = "";
        string Resultado = "";
        string idPartido = "";

        private void btnLocal_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dtPartidos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dtPartidos.SelectedRows[0];

                // Obtener el valor de la columna 0 (ID)
                string equipo = row.Cells[1].Value.ToString();

                // Mostrar el valor en un MessageBox (solo para demostración)
                lblEquipo.Text = equipo;

                btnVisitante.Enabled = false;
                btnLocal.Enabled = false;

                Equipo = equipo;
                
            }
            else
            {
                // Si no hay filas seleccionadas, mostrar un mensaje
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }

            
        }

        private void btnVisitante_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dtPartidos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dtPartidos.SelectedRows[0];

                // Obtener el valor de la columna 0 (ID)
                string equipo = row.Cells[3].Value.ToString();

                // Mostrar el valor en un MessageBox (solo para demostración)
                lblEquipo.Text = equipo;

                btnLocal.Enabled = false;
                btnVisitante.Enabled = false;

                Equipo = equipo;


            }
            else
            {
                // Si no hay filas seleccionadas, mostrar un mensaje
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }

            
        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "victoria";
            btnGanador.Enabled = false;
            btnEmpate.Enabled = false;
            btnPerder.Enabled = false;
            Resultado = lblResultado.Text;
        }

        private void btnEmpate_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "empate";
            btnGanador.Enabled = false;
            btnEmpate.Enabled = false;
            btnPerder.Enabled = false;
            Resultado = lblResultado.Text;
        }

        private void btnPerder_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "derrota";
            btnGanador.Enabled = false;
            btnEmpate.Enabled = false;
            btnPerder.Enabled = false;
            Resultado = lblResultado.Text;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnGanador.Enabled = true;
            btnEmpate.Enabled = true;
            btnPerder.Enabled = true;
            btnLocal.Enabled = true;
            btnVisitante.Enabled = true;

            lblEquipo.Text = ".";
            lblResultado.Text = ".";

            Resultado = "";
            Equipo = "";

        }

        private void vistaPronosticosUsuario_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaPartidos();
            dtPartidos.DataSource = dataTable;
        }

        private void btnPronosticar_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dtPartidos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dtPartidos.SelectedRows[0];

                // Obtener el valor de la columna 0 (ID)
                string idPartidos = row.Cells[0].Value.ToString();


                idPartido = idPartidos;


                ProcedimientosSql.AgregarQuiniela(idPartido, Equipo, Resultado);

            }
            else
            {
                // Si no hay filas seleccionadas, mostrar un mensaje
                MessageBox.Show("no se pudo realizar la quiniela");
            }
        }
    }
}
