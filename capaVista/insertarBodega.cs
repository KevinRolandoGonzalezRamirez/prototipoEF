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
using System.Collections;

namespace capaVista
{
    public partial class insertarBodega : Form
    {

        controlador nuevoCn = new controlador();
        controlador cn = new controlador();
        public insertarBodega()
        {
            InitializeComponent();
            actualizardatagriew("bodega");

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

            //codigo para insertar el indicce
            int id;
            id = comboBox1.SelectedIndex + 1;

            string idString = id.ToString();//lo convierto en un string para el foraneo

            if (v1 == "" || v2 == "" )
            {
                MessageBox.Show("tiene datos faltantes");
                return;
            }

            bool resultado = nuevoCn.ingresoBodega(v1, v2,idString);

            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("bodega");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            txt1.Text = "";
            txt2.Text = "";
            


        }

        private void insertarBodega_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            var listaCines = cn.listaProducto();//tengo la lista de las ciudades


            //convertir a string
            //txtNom.Text = (string)lista[0];


            //intento de recorrer todo el arralist
            for (int i = 0; i < listaCines.Count; i++)
            {
                comboBox1.Items.Add(listaCines[i].ToString());
            }
        }
    }
}
