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
    public partial class Actualizar : Form
    {
        controlador cn = new controlador();
        controlador nuevoCn = new controlador();
        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }

        public Actualizar()
        {
            InitializeComponent();
            actualizardatagriew("compras");
            //bloquear textboxs
            txt5.DropDownStyle = ComboBoxStyle.DropDownList;
            //poner valor en combobox
            
        }

        
        private void btn2_Click(object sender, EventArgs e)
        {

            string uid = txt1.Text;
            var lista = cn.busquedaIndividual(uid);
            
            txt2.Text = (string)lista[1];
            calendarioDate.Value = Convert.ToDateTime(lista[2]);
            txt4.Text = lista[3].ToString();
            txt5.Text = (string)lista[4];

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string v1 = txt1.Text;
            string v2 = txt2.Text;
            string v3 = calendarioDate.Value.Year.ToString() + "-" + calendarioDate.Value.Month.ToString() + "-" + calendarioDate.Value.Day.ToString();
            string v4 = txt4.Text;
            string v5 = txt5.Text;//obtengo el estado

            if (v1 == "" || v2 == "" || v4 == "")
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.actualizarCompras(v1, v2, v3, v4,v5);

            if (resultado)
            {
                MessageBox.Show("Actualización correcta");
                actualizardatagriew("compras");
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }

            txt1.Text = "";
            txt2.Text = "";
            txt4.Text = "";
            txt5.Text = "";

        }

        private void calendarioDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
