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
    public partial class ingresarProducto : Form
    {
        controlador nuevoCn = new controlador();
        public ingresarProducto()
        {
            InitializeComponent();
            actualizardatagriew("producto");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;//id producto
            string v2 = txt2.Text;//nombre
            string v3 = txt3.Text;//precio
            string v4 = txt4.Text;//inventario
            //string v4 = txt4.Text;

            if (v1 == "" || v2 == "" || v3 == "" || v4 == "")
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.ingresoProducto(v1, v2, v3,v4);

            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("producto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            //txt4.Text = "";
        }
    }
}
