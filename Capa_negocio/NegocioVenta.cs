﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
using System.Runtime.CompilerServices;

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
           , string varnrocomprobante, decimal iva,bool concaja,string usuario, 
           DataTable dtDetalles, decimal descuento,  decimal total,decimal subtotal,
           char estado, DataTable datamultipago, bool distock = false, int nroterminal = 0,
           int codtarjeta = 0, string cupon = "",string lote = "", decimal importe = 0, 
           int cuota = 0, int codformapago = 1, decimal totalneto = 0, decimal precioiva = 0,
           string cae = "", string caefechavto = "",string numerotipofactura = "", string puntoventa = "", 
           decimal iva105 = 0,decimal neto105 = 0)
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
           objVenta.Precioiva105 = iva105;
           objVenta.Totalneto105 = neto105;
            objVenta.Idusuario = NegocioConfigEmpresa.idusuario;
            objVenta.Usuario = NegocioConfigEmpresa.usuarioconectado;
            objVenta.Turno = NegocioConfigEmpresa.turno;
            objVenta.Nrocaja = NegocioConfigEmpresa.nrocaja;

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

            if (codformapago != 5)
            {
                rpta = objVenta.Insertar(objVenta, detalles, distock);
            }
            else
            {
               rpta =  objVenta.cargarventamultipago(datamultipago, dtDetalles, objVenta,distock);
            }
           this.idventa = objVenta.Idventa;
           
           return rpta;

       }
        public static int anular(int idventa, bool stock, char estado, int codformapago, bool concaja)
        {
            int varidventa = 0;
           try
           {

                string mensaje = "";
                Dventa objventa = new Dventa(idventa, estado, codformapago);
                objventa.Fecha = DateTime.Now;
                objventa.Concaja = concaja;
                objventa.Nrocaja = NegocioConfigEmpresa.nrocaja;
                varidventa = objventa.anular(objventa, stock);


           }
           catch (Exception)
           {

                throw;
           }
            return varidventa;
        }
        public static string actualizarestadostock(int idventa, bool stock)
        {
            string mensaje = "";
            Dventa objventa = new Dventa();
            mensaje =  objventa.cambiarestadostock(idventa, stock);
            

            return mensaje;
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
        public static DataTable BuscarIdVenta(int idventa)
        {
            Dventa Obj = new Dventa();
            
            Obj.Idventa = idventa;
            Obj.Porventa = true;


            return Obj.BuscarIdVenta( Obj);

        }

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2, char estado, bool concaja, 
            string tipocomprobante, int idventa, string puntoventa, int codformapago, bool porventa, bool porformadepago,
            bool porpuntodeventa, bool porcaja,int idcliente = 0, string usuario = "" )
        {
            Dventa Obj = new Dventa(estado,concaja, tipocomprobante);
            Obj.Estado = tipocomprobante == "NOTA DE CREDITO" ? 'N' : estado;
            Obj.Concaja = concaja;
            Obj.Idventa = idventa;
            Obj.Puntoventa = puntoventa;
            Obj.Porformadepago = porformadepago;
            Obj.Porpuntodeventa = porpuntodeventa;
            Obj.Porventa = porventa;
            Obj.Codformapago = codformapago;
            Obj.Idcliente = idcliente;
            Obj.Usuario = usuario;
            Obj.Porcaja = porcaja;

            Obj.Tipo_comprobante = tipocomprobante;


            return Obj.BuscarFechas(textobuscar, textobuscar2,Obj);

        }
        public static DataTable BuscarIdMultipago(int varidventamultipago)
        {
            Dventa Obj = new Dventa();
            Obj.Idventa = varidventamultipago;
            return Obj.BuscarIdMultipago(Obj);

        }

        public static DataTable BuscarFechasPresupuesto(string textobuscar, string textobuscar2, char estado,
             int idventa, int idcliente)
        {
            Dventa Obj = new Dventa();
           
            Obj.Idventa = idventa;
            Obj.Estado = estado;
            Obj.Idcliente = idcliente;
            return Obj.BuscarFechasPresupuesto(textobuscar, textobuscar2, Obj);

        }

        public static int cambiarestadoventa(int varidVenta,char estado, string varnrocomprobante = "0", string varcae = "", string varvtocae = "", string varpuntoventa = "0001",string vartipofactura = "") 
        
        {
            
            Dventa Obj = new Dventa();
            Obj.Idventa = varidVenta;
            Obj.Estado = estado;
            Obj.Nrocomprobante = varnrocomprobante;
            Obj.Cae = varcae;
            Obj.Caevencimiento = varvtocae;
            Obj.Puntoventa = varpuntoventa;
            Obj.Numerotipofactura = vartipofactura;
            Obj.Fecha = DateTime.Now;

            
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
        public static DataTable Reporteventadetallecategoria(string texto1, string texto2)
        {
            Dventa obj = new Dventa();
            return obj.reporteventadetalleporcategoria(obj,texto1,texto2);
        }

        public static DataTable MostrarRanking5Productos(){

            return new Dventa().mostrarRanking5Productos();
        }
        public static DataTable buscarventa(int varidventa)
        {
            Dventa Obj = new Dventa(varidventa, 'a');
            return Obj.BuscarVenta(Obj);
        }

        public static string ingresarventamultipago(List<Dventa> listaventa, DataTable datadetalle, Dventa Venta)
        {
            //Dventa obj = new Dventa(idventa);
            string mensaje = "";



            return mensaje;


        }
        public static DataTable tarjeta(int modo = 9, int codigo = 0)
        {
            return new Dventa().Tarjeta(modo,codigo);
        }

        public string [,] Matrizventa = new string [100,100];


    }
    
}
