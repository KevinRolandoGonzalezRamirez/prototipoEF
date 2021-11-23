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
    public partial class modificacionClientes : Form
    {

        controlador cn = new controlador();
        controlador nuevoCn = new controlador();
        public modificacionClientes()
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
        private void btn2_Click(object sender, EventArgs e)
        {
            string uid = txt1.Text;
            var lista = cn.busquedaCliente(uid);

            txt2.Text = (string)lista[1];//nombre
            txt3.Text = (string)lista[2];//dpi
            txt4.Text = (string)lista[4];//estado;
            //  calendarioDate.Value = Convert.ToDateTime(lista[2]);
            // txt4.Text = lista[3].ToString();
            //txt5.Text = (string)lista[4];
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;//id
            string v2 = txt2.Text;//nombre
            string v3 = txt3.Text;//DPI
            string v4 = txt4.Text;//estado
           

            if (v1 == "" || v2 == "" || v3 == "" || v4 == "")
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.actualizarCliente(v1, v2, v3, v4);

            if (resultado)
            {
                MessageBox.Show("Actualización correcta");
                actualizardatagriew("cliente");
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }

            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            
        }
    }
}
