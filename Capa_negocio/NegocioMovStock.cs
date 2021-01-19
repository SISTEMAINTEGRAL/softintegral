using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;
namespace Capa_negocio
{
   public class NegocioMovStock
    {
       public static string insertar(int idproveedor,DateTime fecha,string serie,string correlativa,string tipoComprobante,decimal IVA,string estado,string movimiento,DataTable
           detalle_movStock)
       {
           DatosMovStock dMovStock = new DatosMovStock();
           dMovStock.IdProveedor = idproveedor;
           dMovStock.Fecha = fecha;
           dMovStock.Serie= serie;
           dMovStock.Correlativa = correlativa;
           dMovStock.IVA =(float) IVA;
           dMovStock.TipoComprante = tipoComprobante;
           dMovStock.Estado = estado;
           dMovStock.Movimiento = movimiento;
           List<DatosDetalleMovStock> lista_detalleMovStock = new List<DatosDetalleMovStock>();
           //lista de articulos para ir almacenando los valores precio stockActual y idarticulo para poder modificarlos
           List<DatosArticulo> listaArticulo= new List<DatosArticulo>();
           foreach (DataRow fila in detalle_movStock.Rows)
           {
               //creo un objeto dDetalleMovStock para agregar a la lista de los detalles
               DatosDetalleMovStock dDetalleMovStock = new DatosDetalleMovStock();
               DatosArticulo dArticulo = new DatosArticulo();
               dDetalleMovStock.IdArticulo = Convert.ToInt32(fila["Codigo"].ToString());
               dDetalleMovStock.Precio = Convert.ToDecimal(fila["Precio"].ToString());
               dDetalleMovStock.Cantidad = Convert.ToDecimal(fila["Cantidad"].ToString());
               dDetalleMovStock.PrecioVenta = Convert.ToDecimal(fila["PrecioVenta"].ToString()); 
               lista_detalleMovStock.Add(dDetalleMovStock);

               dArticulo.IdArticulo = dDetalleMovStock.IdArticulo;
               dArticulo.StockActual = dDetalleMovStock.Cantidad;
               dArticulo.Precio = dDetalleMovStock.PrecioVenta;
               listaArticulo.Add(dArticulo);
           }

           return dMovStock.agregar(dMovStock,lista_detalleMovStock,listaArticulo);
       }
       public static string anular(int idMovStock,string movimiento)
       {
            DataTable detalle_movStock = new DataTable();
           DatosMovStock dMovStock = new DatosMovStock();
            detalle_movStock = NegocioMovStock.mostrarDetalleMovStock(idMovStock);
           dMovStock.IdmovStock = idMovStock;
            dMovStock.Movimiento = movimiento;
            List<DatosArticulo> listaArticulo = new List<DatosArticulo>();
            foreach (DataRow fila in detalle_movStock.Rows)
            {
                //creo un objeto dDetalleMovStock para agregar a la lista de los detalles
                
                DatosArticulo dArticulo = new DatosArticulo();
                

                dArticulo.IdArticulo = Convert.ToInt32(fila["idarticulo"].ToString());
                dArticulo.StockActual = Convert.ToDecimal(fila["Cantidad"].ToString());
                
                listaArticulo.Add(dArticulo);
            }

            return dMovStock.anular(dMovStock,dMovStock,listaArticulo);
       }

       public static DataTable buscarFecha(string textoBuscar1, string textoBuscar2, int idproveedor = 0)
       {
           DatosMovStock dMovStock = new DatosMovStock();
            dMovStock.IdProveedor = idproveedor;

           return dMovStock.buscarTexto(textoBuscar1, textoBuscar2, dMovStock);
       }
        public static DataTable mostrar()
        {

            return new DatosMovStock().mostrarMovStock();
        }
        public static DataTable mostrarDetalleMovStock(int idMovStock)
        {

            return new DatosMovStock().mostrarDetalleMovStock(idMovStock);
        }
    }
}
