using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;

namespace capaVista
{
    public partial class MDI_KevinGonzalez_0901_18_1387 : Form
    {
        public MDI_KevinGonzalez_0901_18_1387()
        {
            InitializeComponent();
        }

        private void eliminaciónClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.eliminarCliente formulario = new capaVista.eliminarCliente();
            formulario.Show();
            formulario.MdiParent = this;

        }

        private void ingresoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.ingresoClientes formulario = new capaVista.ingresoClientes();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void MDI_KevinGonzalez_0901_18_1387_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
               // txtUser.Text = form.usuario();
            }
            else
            {
                this.Close();
            }

        }

        private void modificaciónClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.modificacionClientes formulario = new capaVista.modificacionClientes();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.consultarCliente formulario = new capaVista.consultarCliente();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.ingresarProducto formulario = new capaVista.ingresarProducto();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.actualizarProducto formulario = new capaVista.actualizarProducto();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.eliminarProducto formulario = new capaVista.eliminarProducto();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.consultarProducto formulario = new capaVista.consultarProducto();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresarBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.insertarBodega formulario = new capaVista.insertarBodega();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresarTipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.ingresarTipodePago formulario = new capaVista.ingresarTipodePago();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capaVista.ingresoFactura formulario = new capaVista.ingresoFactura();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capaVista.reporteCliente formulario = new capaVista.reporteCliente();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capaVista.reporteFactura formulario = new capaVista.reporteFactura();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void bodegaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capaVista.reporteBodega formulario = new capaVista.reporteBodega();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capaVista.reporteProducto formulario = new capaVista.reporteProducto();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void tipoDePagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capaVista.reportetipoPago formulario = new capaVista.reportetipoPago();
            formulario.Show();
            formulario.MdiParent = this;
        }
    }
}
