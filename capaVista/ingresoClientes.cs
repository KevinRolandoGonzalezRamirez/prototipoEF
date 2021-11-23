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
    public partial class ingresoClientes : Form
    {

        controlador nuevoCn = new controlador();
        public ingresoClientes()
        {
            InitializeComponent();
            actualizardatagriew("cliente");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;//id cliente
            string v2 = txt2.Text;//nombre
            string v3 = txt3.Text;//dpi
            //string v4 = txt4.Text;

            if (v1 == "" || v2 == "" || v3 == "" )
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.ingresoCliente(v1, v2, v3);

            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("cliente");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            //txt4.Text = "";

        }
    }
}
