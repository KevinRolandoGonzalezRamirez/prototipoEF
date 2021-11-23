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
    public partial class ingresarTipodePago : Form
    {

        controlador nuevoCn = new controlador();
        controlador cn = new controlador();
        public ingresarTipodePago()
        {
            InitializeComponent();
            actualizardatagriew("tipoPago");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;
            string v2 = txt2.Text;

            if (v1 == "" || v2 == "")
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.ingresoTipoPago(v1, v2);

            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("tipoPago");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            txt1.Text = "";
            txt2.Text = "";

        }
    }
}
