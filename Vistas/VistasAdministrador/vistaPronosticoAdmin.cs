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
    public partial class vistaPronosticoAdmin : Form
    {
        public vistaPronosticoAdmin()
        {
            InitializeComponent();
        }

        private void vistaPronosticoAdmin_Load(object sender, EventArgs e)
        {
            obtenerTablas datos = new obtenerTablas();
            DataTable dataTable = datos.TablaTodosLosPronosticos();
            dtPronosticos.DataSource = dataTable;
        }
    }
}
