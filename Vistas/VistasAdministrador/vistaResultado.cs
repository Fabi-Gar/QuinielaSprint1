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

namespace QuinielaSprint1.Vistas.VistasAdicionales
{
    public partial class vistaResultado : Form
    {
        public vistaResultado()
        {
            InitializeComponent();
        }

        private void vistaResultado_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaPartidosConId();
            dtListaUsuarios.DataSource = dataTable;

            obtenerTablas datos1 = new obtenerTablas();
            DataTable dataTable1 = datos.TablaResultadosConEquipos();
            dtListaResultados.DataSource = dataTable1;

        }

        private void btnGenerarResultado_Click(object sender, EventArgs e)
        {
            ProcedimientosSql.InsertarResultado(txtIdEquipo.Text,txtIdEquipo.Text,txtResultado.Text,txtGolesLocales.Text,txtGolesVisitante.Text);
            obtenerTablas datos1 = new obtenerTablas();
            DataTable dataTable1 = datos1.TablaResultadosConEquipos();
            dtListaResultados.DataSource = dataTable1;
        }

    
    }
}
