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
    public partial class eliminar : Form
    {
        public eliminar()
        {
            InitializeComponent();
            actualizardatagriew("compras");
        }


        controlador cn = new controlador();
        controlador nuevoCn = new controlador();

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;
        }

      

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;


            if (v1 == "")
            {
                MessageBox.Show("No tiene ID ingresado");
                return;
            }


            bool resultado = nuevoCn.eliminarCompras(v1);

            if (resultado)
            {
                MessageBox.Show("Eliminación Correcta");
                actualizardatagriew("compras");
            }
            else
            {
                MessageBox.Show("Eliminicación fallida");
            }

            txt1.Text = "";
        }

        private void dvgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
