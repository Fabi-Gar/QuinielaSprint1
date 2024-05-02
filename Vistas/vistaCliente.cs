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


namespace QuinielaSprint1.Vistas
{
    public partial class vistaCliente : Form
    {
        public vistaCliente()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState =FormWindowState.Maximized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void vistaCliente_Load(object sender, EventArgs e)
        {
            string[] resultados = ProcedimientosSql.ObtenerId(Conexiones.Miconexion.user);
            string nombreUsuario = resultados[0];
            MessageBox.Show(nombreUsuario);

        }
    }
}
