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
    public partial class actualizarProducto : Form
    {

        controlador cn = new controlador();
        controlador nuevoCn = new controlador();
        public actualizarProducto()
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

        private void btn2_Click(object sender, EventArgs e)
        {
            string uid = txt1.Text;
            var lista = cn.busquedaProducto(uid);

            txt2.Text = (string)lista[1];
            txt3.Text = lista[2].ToString();
            txt4.Text = lista[3].ToString();
            txt5.Text = (string)lista[4];
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;//id producto
            string v2 = txt2.Text;// nombre
            string v3 = txt3.Text;//precio
            string v4 = txt4.Text;//inventario
            string v5 = txt5.Text;//obtengo el estado

            if (v1 == "" || v2 == "" || v3 == "" || v4 == "" || v5 == "")
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.actualizarProducto(v1, v2, v3, v4, v5);

            if (resultado)
            {
                MessageBox.Show("Actualización correcta");
                actualizardatagriew("producto");
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }

            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";



        }
    }
}
