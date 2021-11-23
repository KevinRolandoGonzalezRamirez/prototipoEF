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
    public partial class insertar : Form
    {

        controlador nuevoCn = new controlador();

        public insertar()
        {
            InitializeComponent();
            actualizardatagriew("compras");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;
            string v2 = txt2.Text;
            string v3 = calendarioDate.Value.Year.ToString() + "-" + calendarioDate.Value.Month.ToString() + "-" + calendarioDate.Value.Day.ToString();
            string v4 = txt4.Text;

            if (v1=="" || v2=="" || v4=="")
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.ingresoCompras(v1, v2, v3, v4);

            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("compras");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            txt1.Text = "";      
            txt2.Text = "";
            txt4.Text = "";
          





            //MessageBox.Show(calendarioDate.Value.Month.ToString());
        }

        private void calendarioDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dvgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertar_Load(object sender, EventArgs e)
        {

        }
    }
}
