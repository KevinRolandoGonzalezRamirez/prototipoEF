using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaVista
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            //
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            capaVista.insertar formulario = new capaVista.insertar();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.Actualizar formulario = new capaVista.Actualizar();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.eliminar formulario = new capaVista.eliminar();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.consultar formulario = new capaVista.consultar();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
