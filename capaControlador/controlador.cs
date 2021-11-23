using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaModelo;
using System.Data;
using System.Data.Odbc;
using System.Collections;

namespace capaControlador
{
    public  class controlador
    {
        sentencias sn = new sentencias();

        public DataTable llenarTabla(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTabla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool ingresoCompras(string v1, string v2, string v3, string v4)
        {
            return sn.ingresoCompras(v1,v2,v3,v4);

        }

        //CLIENTES
        public bool ingresoCliente(string v1, string v2, string v3)
        {
            return sn.ingresoCliente(v1, v2, v3);

        }

        public ArrayList busquedaCliente(string idu)
        {
            return sn.busquedaCliente(idu);
        }

        public bool actualizarCliente(string v1, string v2, string v3, string v4)
        {
            return sn.actualizarCliente(v1, v2, v3, v4);

        }


        public bool eliminarCliente(string v1)
        {
            return sn.eliminarCliente(v1);

        }

        //FIN CLIENTES


        //PRODUCTOS

        public bool ingresoProducto(string v1, string v2, string v3,string v4)
        {
            return sn.ingresoProducto(v1, v2, v3,v4);

        }

        public ArrayList busquedaProducto(string idu)
        {
            return sn.busquedaProducto(idu);
        }

        public bool actualizarProducto(string v1, string v2, string v3, string v4, string v5)
        {
            return sn.actualizarProducto(v1, v2, v3, v4, v5);

        }

        public bool eliminarProducto(string v1)
        {
            return sn.eliminarProducto(v1);

        }

        public ArrayList listaProducto()
        {
            return sn.listaProducto();
        }

        //FIN PRODUCTOS


        //BODEGAS
        public bool ingresoBodega(string v1, string v2, string v3)
        {
            return sn.ingresoBodega(v1, v2, v3);

        }
        //FIN BODEGAS


        //TIPO DE PAGO
        public bool ingresoTipoPago(string v1, string v2)
        {
            return sn.ingresoTipoPago(v1, v2);

        }
        //FIN TIPO DE PAGO

        //FACTURA

        public bool ingresoFactura(string v1, string v2, string v3)
        {
            return sn.ingresoFactura(v1, v2, v3);

        }
        public bool ingresodetFactura(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            return sn.ingresodetFactura( v1,  v2,  v3,  v4,  v5,  v6);

        }

        //FIN FACTURA

        public bool actualizarCompras(string v1, string v2, string v3, string v4, string v5)
        {
            return sn.actualizarCompras(v1, v2, v3, v4, v5);

        }

        public bool eliminarCompras(string v1)
        {
            return sn.eliminarCompras(v1);

        }

        public ArrayList busquedaIndividual(string idu)
        {
            return sn.busquedaIndividual(idu);
        }

    }
}
