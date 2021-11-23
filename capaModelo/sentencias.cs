using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Collections;

namespace capaModelo
{

    
    public class sentencias
    {

        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTabla(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        //CLIENTES
        public bool ingresoCliente(string v1, string v2, string v3)
        {
            int i = 0;
            try
            {
                string cadena = "insert into cliente values ('" + v1 + "','" + v2 + "','" + v3 + "',' 0.00" + "','A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ArrayList busquedaCliente(string idu)
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "select * from cliente where idCliente = " + idu + ";";
                OdbcCommand busI = new OdbcCommand(busqueda, con.conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add(lector[0]);
                    arList.Add(lector[1]);
                    arList.Add(lector[2]);
                    arList.Add(lector[3]);
                    arList.Add(lector[4]);
                }
            }
            catch (OdbcException)
            {

            }


            return arList;
        }

        public bool actualizarCliente(string v1, string v2, string v3, string v4)
        {

            int i = 0;
            try
            {
                string cadena = "update cliente set nombre = '" + v2 + "'," + "dpi = '" + v3 + "'," + "estado = '" + v4 + "' where idCliente = " + v1 + ";";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarCliente(string v1)
        {

            int i = 0;
            try
            {
                string cadena = "update cliente set estado = 'I'" + " where idCliente = " + v1 + ";";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //FIN CLIENTES 


        //PRODUCTOS

        public bool ingresoProducto(string v1, string v2, string v3, string v4)
        {
            int i = 0;
            try
            {
                string cadena = "insert into producto values ('" + v1 + "','" + v2 + "'," + v3 + "," + v4 + ",'A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ArrayList busquedaProducto(string idu)
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "select * from producto where idProducto = " + idu + ";";
                OdbcCommand busI = new OdbcCommand(busqueda, con.conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add(lector[0]);
                    arList.Add(lector[1]);
                    arList.Add(lector[2]);
                    arList.Add(lector[3]);
                    arList.Add(lector[4]);
                }
            }
            catch (OdbcException)
            {

            }


            return arList;
        }
        public bool actualizarProducto(string v1, string v2, string v3, string v4,string v5)
        {

            int i = 0;
            try
            {
                string cadena = "update producto set nombre = '" + v2 + "'," + "precio = " + v3 + "," + "inventario = " + v4 + "," + "estado = '" + v5 + "' where idProducto = " + v1 + ";";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);
                 


            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarProducto(string v1)
        {

            int i = 0;
            try
            {
                string cadena = "update producto set estado = 'I'" + " where idProducto = " + v1 + ";";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ArrayList listaProducto()
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "select * from producto ;";
                OdbcCommand busI = new OdbcCommand(busqueda, con.conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    //arList.Add(lector[0]);
                    arList.Add(lector[1]);//producto
                    //arList.Add(lector[2]);
                    //arList.Add(lector[3]);
                    //arList.Add(lector[4]);
                }
            }
            catch (OdbcException)
            {

            }


            return arList;
        }

        //FIN PRODCUTOS


        //BODEGA 
        public bool ingresoBodega(string v1, string v2, string v3)
        {
            int i = 0;
            try
            {
                string cadena = "insert into bodega values ('" + v1 + "','" + v2 + "'," + v3 + ",'A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // FIN BODEGA


        //TIPOD DE PAGO
        public bool ingresoTipoPago(string v1, string v2)
        {
            int i = 0;
            try
            {
                string cadena = "insert into tipoPago values ('" + v1 + "','" + v2 + "' , 'A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //FIN TIPO DE PAGO


        //TIPO FACTURA

        public bool ingresoFactura(string v1, string v2, string v3)
        {
            int i = 0;
            try
            {
                string cadena = "insert into factura values ('" + v1 + "','" + v2 + "' , 'A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ingresodetFactura(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            int i = 0;
            try
            {
                string cadena = "insert into detFactura values ('" + v1 + "','" + v2 + "' , 0.00 ," + v3 + "," + v4 + "," + v5 + "," + v6 + "); ";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //FIN FACTURA


        public bool ingresoCompras(string v1, string v2, string v3 , string v4)  
        {
            int i = 0;
            try
            {
                string cadena = "insert into compras values ('" + v1 + "','" + v2 + "','" + v3 + "','" +v4 + "','A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

         public bool actualizarCompras(string v1, string v2, string v3, string v4,string v5)  
        {

            int i = 0;
            try
            {
                string cadena = "update compras set descripcion = '" + v2 + "'," + "fecha = '"+ v3 + "'," + "total = " + v4 + ", estado = '" + v5 + "' where id = " + v1 + ";" ;
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool eliminarCompras(string v1)
        {

            int i = 0;
            try
            {
                string cadena = "update compras set estado = 'I'"  + " where id = " + v1 + ";";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ArrayList busquedaIndividual(string idu)
        {
            var arList = new ArrayList();
            try
            {
                string busqueda = "select * from compras where id = "+ idu + ";";
                OdbcCommand busI = new OdbcCommand(busqueda, con.conexion());
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    arList.Add(lector[0]);
                    arList.Add(lector[1]);
                    arList.Add(lector[2]);
                    arList.Add(lector[3]);
                    arList.Add(lector[4]);
                }
            }
            catch (OdbcException)
            {

            }


            return arList;
        }


    }
}
