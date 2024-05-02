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
    public partial class vistaPartidosUsuario : Form
    {
        public vistaPartidosUsuario()
        {
            InitializeComponent();
        }

        private void vistaPartidosUsuario_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaPartidos();
            dtPartidos.DataSource = dataTable;
        }
    }
}
