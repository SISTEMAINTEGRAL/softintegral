using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class DDetalle_Venta
    {

        //Campos
        private int idarticulo;
        private decimal precioVenta;
        private int iddetalle_venta;
        private decimal cantidad;
        private int idventa;
        private decimal descuento;
        private decimal importe;
        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        //Propiedades


        public int Idarticulo
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }
        public int Iddetalle_venta
        {
            get { return iddetalle_venta; }
            set { iddetalle_venta = value; }
        }
        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }
        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        public DDetalle_Venta()
        {

        }
        public DDetalle_Venta(int iddetalle_venta, int idventa, decimal cantidad, decimal precio_venta, decimal descuento, decimal importe, int idarticulo)
        {
            this.iddetalle_venta = iddetalle_venta;
            this.idventa = idventa;
            this.cantidad = cantidad;
            this.precioVenta = precio_venta;
            this.descuento = descuento;
            this.importe = importe;
            this.idarticulo = idarticulo;


        }

        public string Insertar(DDetalle_Venta Detalle_Venta, ref SqlConnection sqlcon, ref SqlTransaction sqltra)
        {
            string rpta = "";

            try
            {
                //asigno el procedimiento almacenado y la transaccion al sqlcmd
                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon,"SP_DETALLEVENTA",sqltra);
 
                SqlParameter pariddetallev = ProcAlmacenado.asignarParametros("@iddetalle_venta", SqlDbType.Int);
                sqlcmd.Parameters.Add(pariddetallev);

                SqlParameter paridventa = ProcAlmacenado.asignarParametros("@idventa", SqlDbType.Int, Detalle_Venta.idventa);
                sqlcmd.Parameters.Add(paridventa);

                SqlParameter parcantidad = ProcAlmacenado.asignarParametros("@cantidad", SqlDbType.Money,Detalle_Venta.Cantidad); 
                sqlcmd.Parameters.Add(parcantidad);

                SqlParameter parImporte = ProcAlmacenado.asignarParametros("@importe", SqlDbType.Money, Detalle_Venta.Importe);
                sqlcmd.Parameters.Add(parImporte);

                SqlParameter pardescuento = ProcAlmacenado.asignarParametros("@descuento", SqlDbType.Decimal, Detalle_Venta.descuento);
                sqlcmd.Parameters.Add(pardescuento);

                SqlParameter paridarticulo = ProcAlmacenado.asignarParametros("@id_articulo", SqlDbType.Int, Detalle_Venta.idarticulo);
                sqlcmd.Parameters.Add(paridarticulo);

                SqlParameter parPrecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Money, Detalle_Venta.precioVenta);
                sqlcmd.Parameters.Add(parPrecio);

                SqlParameter parDetalle = ProcAlmacenado.asignarParametros("@detalle", SqlDbType.NVarChar, Detalle_Venta.detalle);
                sqlcmd.Parameters.Add(parDetalle);


                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                sqlcmd.Parameters.Add(parModo);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ingreso el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
        //pendiente mostrar listado vendido 
        //public DataTable Mostrar()
        //{
        //    //DataTable midatatable = new DataTable();
        //    //return midatatable;
        
        //}


    }
}
