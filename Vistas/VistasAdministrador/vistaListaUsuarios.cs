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
    public partial class vistaListaUsuarios : Form
    {
        public vistaListaUsuarios()
        {
            InitializeComponent();
        }

        private void vistaListaUsuarios_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaListaUsuarios();
            dtListaUsuarios.DataSource = dataTable;
        }
    }
}
