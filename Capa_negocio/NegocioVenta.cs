using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
namespace Capa_negocio
{
    public class NegocioVenta
    {
         // propiedad venta detalle
        private int iddetalle;
        private int idarticulo;
        private int importe;
        private int idventa;
        private decimal cantidad;
        private string puntoventa;

        private bool concaja;

        public bool Concaja
        {
            get { return concaja; }
            set { concaja = value; }
        }

        private bool constock;

        public bool Constock
        {
            get { return constock; }
            set { constock = value; }
        }


        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal subtotal;
        private decimal descuento;
        private decimal precio;

        public int Iddetalle
        {
            get { return iddetalle; }
            set { iddetalle = value; }
        }
        

        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }

       

      

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
       
        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
      

        public int Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        public int Idarticulo
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }

       

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Puntoventa
        {
            get
            {
                return puntoventa;
            }

            set
            {
                puntoventa = value;
            }
        }

        public string Insertar(int idcliente, DateTime fecha, string tipo_comprobante, string serie
           , string varnrocomprobante, decimal iva,bool concaja,bool constock,string usuario, 
           DataTable dtDetalles, decimal descuento,  decimal total,decimal subtotal,
           char estado,bool distock = false, int nroterminal = 0,
           int codtarjeta = 0, string cupon = "",string lote = "", decimal importe = 0, 
           int cuota = 0, int codformapago = 1, decimal totalneto = 0, decimal precioiva = 0,
           string cae = "", string caefechavto = "",string numerotipofactura = "", string puntoventa = "")
       {

           string rpta = "";
           Dventa objVenta = new Dventa();
           objVenta.Idcliente = idcliente;
           objVenta.Fecha = fecha;
           objVenta.Tipo_comprobante = tipo_comprobante;
           objVenta.Serie = serie;
           objVenta.Nrocomprobante = varnrocomprobante;
           objVenta.Iva = iva;
           objVenta.Concaja = concaja;
           objVenta.Constock = constock;
           objVenta.Usuario = usuario;
           objVenta.Descuento = descuento;
           objVenta.Total = total;
           objVenta.Subtotal = subtotal;
           objVenta.Estado = estado;
           objVenta.Nroterminal = nroterminal;
           objVenta.Codtarjeta = codtarjeta;
           objVenta.Cupon = cupon;
           objVenta.Lote = lote;
           objVenta.Importe = importe;
           objVenta.Cuotas = cuota;
           objVenta.Codformapago = codformapago;
            objVenta.Totalneto = totalneto;
            objVenta.Precioiva = precioiva;
            objVenta.Cae = cae;
            objVenta.Caevencimiento = caefechavto;
            objVenta.Numerotipofactura = numerotipofactura;
            objVenta.Puntoventa = puntoventa;
            

           List<DDetalle_Venta> detalles = new List<DDetalle_Venta>();
           

           foreach (DataRow row in dtDetalles.Rows)
           {
               //asigno los valores de los detalle de ventas a cada objeto detalle
               DDetalle_Venta detalle = new DDetalle_Venta();
               detalle.Idarticulo = Convert.ToInt32(row["codigo"].ToString());
               detalle.Cantidad = Convert.ToDecimal(row["cantidad"].ToString());
               detalle.PrecioVenta = Convert.ToDecimal(row["precio"].ToString());
               detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
               detalle.Importe = Convert.ToDecimal(row["Importe"].ToString());
               detalle.Detalle = row["producto"].ToString();
               //agrego el item a la lista detalles
               detalles.Add(detalle);
           }

           //le paso como parametro la lista de detalles de ventas y el objeto venta previamente inicializado
           rpta = objVenta.Insertar(objVenta, detalles,distock);
           this.idventa = objVenta.Idventa;
           
           return rpta;

       }
        

       public static string Eliminar(int idventa)
       {
           Dventa Obj = new Dventa();
           Obj.Idventa = idventa;
           return Obj.Eliminar(Obj);


       }

      

        public NegocioVenta()
        {
                        

        }

        public static DataTable Mostrar()
        {
            return new Dventa().Mostrar();


        }

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2, char estado, bool concaja, string tipocomprobante)
        {
            Dventa Obj = new Dventa(estado,concaja, tipocomprobante);
            return Obj.BuscarFechas(textobuscar, textobuscar2);

        }

        public static string cambiarestadoventa(int idVenta,char estado, string varnrocomprobante = "0") {
            Dventa Obj = new Dventa();
            Obj.Idventa = idVenta;
            Obj.Estado = estado;
            Obj.Nrocomprobante = varnrocomprobante;
            return Obj.CambiarEstadoVenta(Obj);
        }

        public static void cambiarestadoventa(int idventa, bool concaja, bool constock)
        {
            Dventa obj = new Dventa();
            obj.Idventa = idventa;
            obj.Concaja = concaja;
            obj.Constock = constock;
            obj.CambiarEstadoVenta(obj,8);
        
        }

        public static DataTable NotaDeVenta()
        {
            Dventa Obj = new Dventa();
            return new Dventa().notaDeVenta();

        }

        public static DataTable MostrarDetalle(string textobuscar)
        {
            Dventa Obj = new Dventa();
            return Obj.MostrarDetalle(textobuscar);


        }

        public static DataTable Reporteventa(int idventa)
        {
            Dventa obj = new Dventa(idventa,NegocioConfigEmpresa.idequipo);
            return obj.reporteventa(obj);
        }
        public static DataTable MostrarRanking5Productos(){

            return new Dventa().mostrarRanking5Productos();
        }
        public static DataTable tarjeta(int modo = 9, int codigo = 0)
        {
            return new Dventa().Tarjeta(modo,codigo);
        }

        public string [,] Matrizventa = new string [100,100];


    }
    
}
