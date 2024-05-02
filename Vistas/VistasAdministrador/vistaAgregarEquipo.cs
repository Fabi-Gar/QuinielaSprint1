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
    public partial class vistaAgregarEquipo : Form
    {
        public vistaAgregarEquipo()
        {
            InitializeComponent();
        }

        private void vistaAgregarEquipo_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaEquipos();
            dtEquipos.DataSource = dataTable;
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            ProcedimientosSql.AgregarEquipo(txtUsuario.Text);
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaEquipos();
            dtEquipos.DataSource = dataTable;
        }
    }
}
