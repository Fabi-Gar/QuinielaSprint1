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

        int Equipo = 0;
        int Resultado = 0;

        private void btnLocal_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dtPartidos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dtPartidos.SelectedRows[0];

                // Obtener el valor de la columna 0 (ID)
                string id = row.Cells[0].Value.ToString();

                // Mostrar el valor en un MessageBox (solo para demostración)
                lblEquipo.Text = id;

                btnVisitante.Enabled = false;
                btnLocal.Enabled = false;

                Equipo = 1;
                
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
                string id = row.Cells[2].Value.ToString();

                // Mostrar el valor en un MessageBox (solo para demostración)
                lblEquipo.Text = id;

                btnLocal.Enabled = false;
                btnVisitante.Enabled = false;

                Equipo = 3;
            }
            else
            {
                // Si no hay filas seleccionadas, mostrar un mensaje
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }

            
        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Ganador";
            btnGanador.Enabled = false;
            btnEmpate.Enabled = false;
            btnPerder.Enabled = false;
            Resultado = 1;
        }

        private void btnEmpate_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Empate";
            btnGanador.Enabled = false;
            btnEmpate.Enabled = false;
            btnPerder.Enabled = false;
            Resultado = 2;
        }

        private void btnPerder_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Perdedor";
            btnGanador.Enabled = false;
            btnEmpate.Enabled = false;
            btnPerder.Enabled = false;
            Resultado = 3;
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

            Resultado = 0;
            Equipo = 0;

        }

        private void vistaPronosticosUsuario_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaPartidos();
            dtPartidos.DataSource = dataTable;
        }
    }
}
