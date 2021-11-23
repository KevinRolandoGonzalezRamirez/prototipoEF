using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaControlador;

namespace capaVista
{
    public partial class consultar : Form
    {

        controlador nuevoCn = new controlador();
        public consultar()
        {
            InitializeComponent();
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DataTable dt = nuevoCn.llenarTabla("compras");
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }

        private void dvgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
