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
    public partial class ingresoFactura : Form
    {
        controlador nuevoCn = new controlador();
        public ingresoFactura()
        {
            InitializeComponent();
            actualizardatagriew("factura");
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
            string v3 = txt3.Text;
            string v4 = txt4.Text;
            string v5 = txt5.Text;
            string v6 = txt6.Text;
            // string v3 = calendarioDate.Value.Year.ToString() + "-" + calendarioDate.Value.Month.ToString() + "-" + calendarioDate.Value.Day.ToString();
            
            /*
            if (v1 == "" || v2 == "" || v4 == "")
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }*/

            bool resultado = nuevoCn.ingresoFactura(v1, v2, v3);

            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("factura");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            bool resultado2 = nuevoCn.ingresodetFactura(v1, v2, v3,v4,v5,v6);
            /*
            if (resultado2)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("factura");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            */
        }
    }
}
