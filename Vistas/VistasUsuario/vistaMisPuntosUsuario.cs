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
    public partial class vistaMisPuntosUsuario : Form
    {
        public vistaMisPuntosUsuario()
        {
            InitializeComponent();
        }

        private void vistaMisPuntosUsuario_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaQuinielasPorUsuario();
            dtQuinielas.DataSource = dataTable;

            obtenerTablas datos2 = new obtenerTablas();
            DataTable dataTable2 = datos.TablaPuntosUsuario();
            dtMisPuntos.DataSource = dataTable2;
        }
    }
}
