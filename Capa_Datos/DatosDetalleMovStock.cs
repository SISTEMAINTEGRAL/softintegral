using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
   public class DatosDetalleMovStock
    {
        //campos
        private int idDetalleMovStock;
        private int idMovStock;
        private int idarticulo;
        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal precio;
        private decimal precioVenta;
       

       
        private string buscarDetMovStock;

        

        public DatosDetalleMovStock() { 
        }

        public DatosDetalleMovStock(int idDetalleIngreso, int idIngreso,int idarticulo,DateTime fechaVencimiento,int stockInicial,
            int stockActual,decimal precio)
        {
        this.idDetalleMovStock=idIngreso;
        this.idarticulo = idarticulo;
        this.cantidad=stockInicial;
        this.precio=precio;
        
        }
        public string agregar(DatosDetalleMovStock detalleMovStock,ref SqlConnection con,ref SqlTransaction transaccion)
        {
            //modo 1 para DB
            string respuesta = "";
            try
            {

              
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(con, "SP_DETALLEMOVSTOCK",transaccion);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                comando.Parameters.Add(parModo);

                SqlParameter parIdDetalleMovStock = ProcAlmacenado.asignarParametros("@iddetalle_movStock", SqlDbType.Int);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdDetalleMovStock);

                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int,detalleMovStock.IdArticulo);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdArticulo);


                SqlParameter parIdMovStock = ProcAlmacenado.asignarParametros("@idmov_stock", SqlDbType.Int, detalleMovStock.IdMovStock);
                comando.Parameters.Add(parIdMovStock);
                SqlParameter parPrecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Money, detalleMovStock.Precio);
                comando.Parameters.Add(parPrecio);
                SqlParameter parCantidad = ProcAlmacenado.asignarParametros("@cantidad", SqlDbType.Int, detalleMovStock.Cantidad);
                comando.Parameters.Add(parCantidad);

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";

                }
                else
                {

                    respuesta = "error";
                }
                 
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
               
            }
         
            return respuesta;
        }
       
        //PROPIEDADES
    
        public int IdArticulo
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }
       
        
  
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    
        public int IdMovStock
        {
            get { return idMovStock; }
            set { idMovStock = value; }
        }
        public int IdDetalleMovStock
        {
            get { return idDetalleMovStock; }
            set { idDetalleMovStock = value; }
        }
        public string BuscarDetMovStock
        {
            get { return buscarDetMovStock; }
            set { buscarDetMovStock = value; }
        }
        public decimal PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
    }
}
