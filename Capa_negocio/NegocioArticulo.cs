﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

using System.IO;



namespace Capa_negocio
{
    public class NegocioArticulo
    {
        
        //campos
        private int idArticulo;
        private string nombre;
        private string codigo;
        private string descripcion;
        private int idCategoria;
        private string buscarArticulo;
        private decimal precio;
        private decimal precioCompra;
        private int pesable;
        private decimal preciopormayor;
        private decimal cantidadpormayor;
        private decimal iva;

        private decimal cantidadpormayor2;
        private decimal preciopormayor2;
        private decimal precio_oferta;
        private DateTime fechadeoferta;
        private bool habilitarfechaoferta;
        private decimal bulto_cantidad;
        private string bulto_codigobarra;
        private string nombrecategoria;
        private decimal stock_minimo;
        public int Pesable
        {
            get { return pesable; }
            set { pesable = value; }
        }

       
        private decimal stockActual;
        private Boolean sindatos;

        //sistema mayorista
        public static string insertar(string nombre, string codigo, string descripcion, int idCategoria, decimal precio, int cantInicial, int pesable, decimal preciocompra, decimal utilidad, decimal flete, decimal varcantidadpormayor, decimal varpreciopormayor, int idsubcategoria, decimal iva, decimal varcantidadpormayor2, decimal varpreciopormayor2, decimal varprecio_oferta, DateTime fechaoferta, bool habilitarfechaoferta, decimal bulto_cantidad, string bulto_codigobarra, decimal utilidadpormayor, decimal utilidadpormayor2, decimal utilidadoferta)
        {
            DatosArticulo dArticulo = new DatosArticulo(nombre, codigo, descripcion, idCategoria, precio, cantInicial, pesable, preciocompra, utilidad, flete, DateTime.Now, fechaoferta, 0, "", idsubcategoria, varcantidadpormayor, varpreciopormayor, iva, varcantidadpormayor2, varpreciopormayor2, varprecio_oferta, habilitarfechaoferta, bulto_cantidad, bulto_codigobarra, utilidadpormayor, utilidadpormayor2, utilidadoferta, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
            return dArticulo.agregar(dArticulo,"");

        }

       // sistema negocio
        public static string insertar(string nombre, string codigo, string descripcion, int idCategoria, decimal precio, int cantInicial, int pesable, decimal preciocompra, decimal utilidad, decimal flete, decimal varcantidadpormayor, decimal varpreciopormayor, int idsubcategoria, decimal iva)
        {
            DatosArticulo dArticulo = new DatosArticulo(nombre, codigo, descripcion, idCategoria, precio, cantInicial, pesable, preciocompra, utilidad, flete, DateTime.Now, 0, "", idsubcategoria, varcantidadpormayor, varpreciopormayor, iva, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
            return dArticulo.agregar(dArticulo,"");

        }
        public static string eliminar(int idArticulo)
        {
            
            DatosArticulo dArticulo = new DatosArticulo();
            dArticulo.IdArticulo = idArticulo;
            return dArticulo.eliminar(dArticulo);
        }
        //sistema mayorista
        public static string editar(int idArticulo,string nombre, string codigo, string descripcion, int idCategoria,decimal precio,decimal cantInicial,int pesable,decimal preciocompra,decimal utilidad, decimal flete,  DateTime fecha  ,DateTime fechaoferta,int edicionusuario = 0, string edicionlugar = "", decimal cantidadpormayor =0, decimal preciopormayor=0,int idsubcategoria = 0 , decimal iva = 0,
                                    decimal cantidadpormayor2 = 0, decimal preciopormayor2 = 0, decimal precio_oferta = 0, bool habilitarfechaoferta = false, decimal bulto_cantidad = 0, string bulto_codigobarra = "", decimal varutilidadpormayor = 0, decimal varutilidadpormayor2 = 0, decimal varutilidadoferta = 0)
        {
            DatosArticulo dArticulo = new DatosArticulo(nombre, codigo, descripcion,idCategoria,precio,cantInicial,pesable,preciocompra,utilidad,flete,fecha,fechaoferta,edicionusuario,edicionlugar,idsubcategoria,cantidadpormayor,preciopormayor, iva,cantidadpormayor2,preciopormayor2,precio_oferta,habilitarfechaoferta,bulto_cantidad,bulto_codigobarra, varutilidadpormayor,varutilidadpormayor2,varutilidadoferta, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
            dArticulo.IdArticulo= idArticulo;
            return dArticulo.editar(dArticulo);
        }
        //sistema negocio
        public static string editar(int idArticulo, string nombre, string codigo, string descripcion, int idCategoria, decimal precio, decimal cantInicial, int pesable, decimal preciocompra, decimal utilidad, decimal flete, DateTime fecha, int edicionusuario = 0, string edicionlugar = "", decimal cantidadpormayor = 0, decimal preciopormayor = 0, int idsubcategoria = 0, decimal iva = 0)
        {
            DatosArticulo dArticulo = new DatosArticulo(nombre, codigo, descripcion, idCategoria, precio, cantInicial, pesable, preciocompra, utilidad, flete, fecha, edicionusuario, edicionlugar, idsubcategoria, cantidadpormayor, preciopormayor, iva, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
            dArticulo.IdArticulo = idArticulo;
            return dArticulo.editar(dArticulo);
        }
        public static string editarcodigobarra(int idarticulo, string codigo)
        {
            DatosArticulo dArticulo = new DatosArticulo( codigo,idarticulo);
            dArticulo.IdArticulo = idarticulo;
            return dArticulo.editar(dArticulo, "");//14);
        
        }
        public static string editarPrecio(int idArticulo, decimal precio,string opcionsistema)
        {
            DatosArticulo dArticulo = new DatosArticulo(idArticulo, precio);
            return dArticulo.editarPrecio(dArticulo,opcionsistema);
        }
        public static string importarproducto(DataTable Grillaproductos, string opcionsistema)
        {
            List<DatosArticulo> listaArticulo = new List<DatosArticulo>();
            foreach (DataRow fila in Grillaproductos.Rows)
            {
                DatosArticulo dArticulo = new DatosArticulo();
                             
                dArticulo.IdArticulo = Convert.ToInt32(fila["idarticulo"].ToString());
                dArticulo.Codigo = fila["codigo"].ToString();
                dArticulo.Nombre = fila["nombre"].ToString();
                dArticulo.Descripcion = fila["descripcion"].ToString();
                dArticulo.IdCategoria = Convert.ToInt32( fila["idcategoria"].ToString());
                dArticulo.Idsubcategoria = Convert.ToInt32(fila["idsubcategoria"].ToString());
                dArticulo.Precio = Convert.ToDecimal(fila["Precio"].ToString());
                dArticulo.StockActual = Convert.ToDecimal(fila["stock_actual"].ToString());
                dArticulo.PrecioCompra = Convert.ToDecimal(fila["PrecioCompra"].ToString());
                dArticulo.Pesableflag = Convert.ToBoolean(fila["pesable"]);
                dArticulo.Preciomanual = Convert.ToBoolean(fila["preciomanual"].ToString());
                dArticulo.Flete = Convert.ToDecimal(fila["Flete"].ToString());
                dArticulo.Stock_minimo = Convert.ToDecimal(fila["stock_minimo"].ToString());
                dArticulo.Tipobalanza = Convert.ToBoolean(fila["balanza"].ToString());
                dArticulo.Utilidad = Convert.ToDecimal(fila["Utilidad"].ToString());
                dArticulo.Iva = Convert.ToDecimal(fila["iva"].ToString());
                
                

                if (opcionsistema == "mayorista")
                {
                    dArticulo.Utilidadpreciopormayor = Convert.ToDecimal(fila["Utilidadpormayor"].ToString());
                    dArticulo.Preciopormayor = Convert.ToDecimal(fila["Preciopormayor"].ToString());
                    dArticulo.Utilidadpreciopormayor2 = Convert.ToDecimal(fila["Utilidadpormayor2"].ToString());
                    dArticulo.Preciopormayor2 = Convert.ToDecimal(fila["Preciopormayor2"].ToString());
                    dArticulo.Utilidadoferta = Convert.ToDecimal(fila["Utilidadoferta"]);
                    dArticulo.Precio_oferta = Convert.ToDecimal(fila["Precio_Oferta"]);
                }
                if (dArticulo.IdArticulo == 1198)
                {
                    int CON = 0;
                }
                listaArticulo.Add(dArticulo);
            }
            DatosArticulo datosArticulo = new DatosArticulo();
            return datosArticulo.editarPrecioMasivo(listaArticulo, opcionsistema);
        }
        public static string editarPrecioMasivo(DataTable Grillaproductos, string opcionsistema)
        {
             List<DatosArticulo> listaArticulo= new List<DatosArticulo>();
            foreach (DataRow fila in Grillaproductos.Rows)
	        {
		       DatosArticulo dArticulo = new DatosArticulo();
               dArticulo.IdArticulo = Convert.ToInt32(fila["Codigo"].ToString());
               dArticulo.Precio = Convert.ToDecimal(fila["PrecioVenta"].ToString());
               dArticulo.PrecioCompra = Convert.ToDecimal(fila["PrecioCompra"].ToString());
               dArticulo.Utilidad= Convert.ToDecimal(fila["Utilidad"].ToString());
               dArticulo.Flete = Convert.ToDecimal(fila["Flete"].ToString());
               dArticulo.Nombre = fila["producto"].ToString();
               dArticulo.Descripcion = fila["descripcion"].ToString();
                dArticulo.Codigo = fila["codigobarra"].ToString();

                if (opcionsistema == "mayorista")
                {
                    dArticulo.Utilidadpreciopormayor = Convert.ToDecimal(fila["Utilidadpormayor"].ToString());
                    dArticulo.Preciopormayor = Convert.ToDecimal(fila["Preciopormayor"].ToString());
                    dArticulo.Utilidadpreciopormayor2 = Convert.ToDecimal(fila["Utilidadpormayor2"].ToString());
                    dArticulo.Preciopormayor2 = Convert.ToDecimal(fila["Preciopormayor2"].ToString());
                    dArticulo.Utilidadoferta = Convert.ToDecimal(fila["Utilidadpreciooferta"]);
                    dArticulo.Precio_oferta = Convert.ToDecimal(fila["Precio_Oferta"]);
                }
                if (dArticulo.IdArticulo == 1198)
                {
                    int CON = 0;
                }
               listaArticulo.Add(dArticulo);
	            }
            DatosArticulo datosArticulo = new DatosArticulo();
            return datosArticulo.editarPrecioMasivo(listaArticulo,opcionsistema);
        }
        public static string editarPrecio(int idArticulo, decimal precio,decimal precioCompra,decimal utilidad, string opcionsistema)
        {
           
            DatosArticulo dArticulo = new DatosArticulo(idArticulo, precio,precioCompra,utilidad);
            return dArticulo.editarPrecio(dArticulo,opcionsistema);
        }
        public static DataTable buscarNombre(string texto,string descripcion = "",string nombrecategoria="", bool tipobalanza = false )
        {
            DatosArticulo dArticulo = new DatosArticulo();
            dArticulo.BuscarArticulo= texto;
            dArticulo.Descripcion = descripcion;
            dArticulo.Nombrecategoria = nombrecategoria;
            dArticulo.Tipobalanza = tipobalanza;
            int buscarNombre=0;
            //si el booleano que le paso es verdadero busca por nombre o sino por codigo de barra
            return dArticulo.buscarTexto(dArticulo,buscarNombre);
        }
        public static DataTable buscarCodigoBarra(string texto, int modo = 6 )
        {
            DatosArticulo dArticulo = new DatosArticulo();
            dArticulo.BuscarArticulo = texto;
            int buscarCodigoBarra = 1;
            //si el booleano buscarNombre que le paso es verdadero busca por nombre o sino por codigo de barra
            return dArticulo.buscarTexto(dArticulo,buscarCodigoBarra,modo);
        }
       
        public static DataTable buscarCategoria(string texto)
        {
            DatosArticulo dArticulo = new DatosArticulo();
            dArticulo.BuscarArticulo = texto;
            int buscarCategoria = 2;
            //si el booleano buscarNombre que le paso es verdadero busca por nombre o sino por codigo de barra
            return dArticulo.buscarTexto(dArticulo, buscarCategoria);
        }
        public static DataTable buscarIdProducto(string texto)
        {
            DatosArticulo dArticulo = new DatosArticulo();
            dArticulo.BuscarArticulo = texto;
            int buscaridProducto = 3;
            //si el booleano buscarNombre que le paso es verdadero busca por nombre o sino por codigo de barra
            return dArticulo.buscarTexto(dArticulo, buscaridProducto);
        }
        public static DataTable mostrar()
        {
            return new DatosArticulo().mostrar();
        }
        public static DataTable mostrartodo(bool solopesable = false)
        {
            return new DatosArticulo().mostrar(true,solopesable);
        }
        public static DataTable mostrarPesable()
        {
            //mostrar solo los productos pesables
           return new DatosArticulo().mostrarPesable();
        }
      //devuelve el valor de idArticulo
        public static int obtenerIdArticulo()
        {
            int idArticuloActual=0;
            DatosArticulo dArticulo = new DatosArticulo();
            idArticuloActual= dArticulo.obtenerIdArticulo();
            if(idArticuloActual==0||idArticuloActual==null){

                throw new FormatException();
            }
            return idArticuloActual;
        }
        //obtengo el producto correspondiente a un idArticulo
        public static DataTable obtenerProductoXIdArticulo(int idArticulo)
        {
  
            DatosArticulo dArticulo = new DatosArticulo();
            dArticulo.IdArticulo = idArticulo;
            return dArticulo.obtenerProductoXIdProducto(dArticulo);
        }
        public static int calcDigControl(String codigoBarra)
        {
            int resultado = 0;
            int pares = 0, impares = 0;

            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    pares += int.Parse(codigoBarra[i].ToString());

                    
                }
                else
                {
                    impares += int.Parse(codigoBarra[i].ToString()) * 3;

                }

            }
            resultado = pares + impares;
            //obtengo el ultimo digito de la derecha y lo resto con 10 para saber el digito de control
            if (resultado % 10 == 0)
            {
                return resultado = 0;

            }
            //restamos el numero diez para saber cuanto falta para llegar al numero 10 menos el resto del numero dividiendo por 10
            resultado = 10 - (resultado % 10);

            return resultado;



        }

        //extrae los datos de la base por el articulo buscado del id 
        // si el tipo es poridarticulo te lo trae por el codigo si no porbarra

        public void extraerdatos(long codArticulo, string tipo, string codbarra = "")
        {
            DatosArticulo ObjArticulo = new DatosArticulo();


            ObjArticulo.ExtraerDatos(codArticulo, tipo, codbarra);

            this.idArticulo = ObjArticulo.IdArticulo;
            this.nombre = ObjArticulo.Nombre;
            this.codigo = ObjArticulo.Codigo;
            this.descripcion = ObjArticulo.Descripcion;
            this.idCategoria = ObjArticulo.IdCategoria;
            this.precio = ObjArticulo.Precio;
            this.sindatos = ObjArticulo.Sindatos;
            this.pesable = ObjArticulo.Pesable;
            this.preciopormayor = ObjArticulo.Preciopormayor;
            this.cantidadpormayor = ObjArticulo.Cantidadpormayor;
            this.Iva= ObjArticulo.Iva;
            this.cantidadpormayor2 = ObjArticulo.Cantidadpormayor2;
            this.preciopormayor2 = ObjArticulo.Preciopormayor2;
            this.precio_oferta = ObjArticulo.Precio_oferta;
            this.fechadeoferta = ObjArticulo.Fecha_oferta;
            this.habilitarfechaoferta = ObjArticulo.Habilitarfechaoferta;
            this.bulto_cantidad = ObjArticulo.Bulto_cantidad;
            this.bulto_codigobarra = ObjArticulo.Bulto_codigobarra;
            this.nombrecategoria = ObjArticulo.Nombrecategoria;
            this.stock_minimo = ObjArticulo.Stock_minimo;
            this.stockActual = ObjArticulo.StockActual;
        }
        public static NegocioArticulo extraerdatosPesable(long codArticulo, string tipo)
        {
            DatosArticulo ObjArticulo = new DatosArticulo();
            NegocioArticulo articulo = new NegocioArticulo();

            ObjArticulo.ExtraerDatos(codArticulo, tipo,true);

            articulo.IdArticulo = ObjArticulo.IdArticulo;
            articulo.Nombre = ObjArticulo.Nombre;
            articulo.Codigo = ObjArticulo.Codigo;
            articulo.Descripcion = ObjArticulo.Descripcion;
            articulo.IdCategoria = ObjArticulo.IdCategoria;
            articulo.Precio = ObjArticulo.Precio;
            articulo.Sindatos = ObjArticulo.Sindatos;
            return articulo;
        }
        public static NegocioArticulo extraerdatosPesable(string nombre, string tipo)
        {
            DatosArticulo objArticulo = new DatosArticulo();
           NegocioArticulo articulo = new NegocioArticulo();
            //true porque es pesable
            objArticulo.ExtraerDatos(nombre, tipo,true);
                articulo.IdArticulo = objArticulo.IdArticulo;
             articulo.Nombre = objArticulo.Nombre;
            articulo.Codigo = objArticulo.Codigo;
             articulo.Descripcion = objArticulo.Descripcion;
             articulo.IdCategoria = objArticulo.IdCategoria;
             articulo.Precio = objArticulo.Precio;
             articulo.Sindatos = objArticulo.Sindatos;
             return articulo;

        }
        public static DataTable mostrarPesableXbusqueda(string Producto, string tipoBusqueda)
        {
            DatosArticulo ObjArticulo = new DatosArticulo();


           
            if(tipoBusqueda=="idarticulo"){
                ObjArticulo.IdArticulo = Convert.ToInt32(Producto);
            }
            ObjArticulo.IdArticulo =0;
            //el nombre lo utilizo para los categoria y nombre de producto
            ObjArticulo.Nombre = Producto;
            ObjArticulo.Codigo = Producto;
       
            return  ObjArticulo.mostrarPesableXbusqueda(ObjArticulo,tipoBusqueda);
        }

        //productos mayoristas-----------------------------------------

        public static DataTable mostrarpreciomayorista(decimal precio,decimal cantidad, string tipo, int idarticulo)
        {
            DatosArticulo objart = new Capa_Datos.DatosArticulo(idarticulo,precio,cantidad,tipo);
            return objart.preciomayorista(objart);
        }

        public static string cargarpreciomayorista(List<DatosArticulo> listaArticulo)
        {
            DatosArticulo objart = new DatosArticulo();
            return objart.cargarpreciomayorista(listaArticulo);
        }

        //gondola
        public static string cargarproductogondola(List<int> codigoarticulo,  int idequipo, string opcionsistema)
        {
            DatosArticulo objart = new DatosArticulo(idequipo);
            List<DatosArticulo> detalle = new List<DatosArticulo>();

            for (int index = 0; index < codigoarticulo.Count; index++)
            {
                DatosArticulo objartlista = new DatosArticulo();
                objart.ExtraerDatos(codigoarticulo[index], "poridarticulo","");

                
                objartlista.IdArticulo = objart.IdArticulo;
                objartlista.Precio = objart.Precio;
                objartlista.Preciopormayor = objart.Preciopormayor;
                objartlista.Preciopormayor2 = objart.Preciopormayor2;
                objartlista.Precio_oferta = objart.Precio_oferta;
                objartlista.IdCategoria = objart.IdCategoria;
                objartlista.Codigo = objart.Codigo;

                detalle.Add(objartlista);
            }


            return objart.cargarproductogondola(detalle,opcionsistema);
        }

        public static DataTable consultagondola(int varidequipo)
        {
            DatosArticulo objart = new DatosArticulo(varidequipo);
            return objart.consultaproductogondola();
            
        }
        public static DataTable mostrarsqlite()
        {
            DatosArticulo objart = new DatosArticulo();
            return objart.mostrarsqlite();

        }
        public static DataTable mostrarmysql()
        {
            DatosArticulo objart = new DatosArticulo();
            return objart.mostrarmysql();

        }
        public static DataTable consultafecha(DateTime fechadesde, DateTime fechahasta)
        {
            DatosArticulo objart = new DatosArticulo();
            objart.Fechaediciondesde = fechadesde;
            objart.Fechaedicionhasta = fechahasta;
            return objart.buscarTexto(objart, 4);
        }
        public static string ExportarProductos(DataTable Grillaproductos, bool todoslosproductos, string opcionsistema = "mayorista", string opcionexportacion = "nube")
        {

            List<DatosArticulo> listaArticulo = new List<DatosArticulo>();

            foreach (DataRow fila in Grillaproductos.Rows)
            {
                //stock_actual,estado,constock,preciomanual,cantidadpormayor, idsubcategoria,iva, cantidadpormayor2, fechadeoferta,habilitarfechaoferta,
                //bulto_cantidad,bulto_codigobarra,edicionfecha,codigointerno,balanza
                
                DatosArticulo dArticulo = new DatosArticulo();
                dArticulo.IdArticulo = Convert.ToInt32(fila["idarticulo"].ToString());
                dArticulo.Codigo = fila["Codigo"].ToString();
                dArticulo.Nombre = fila["Nombre"].ToString();
                dArticulo.Descripcion = fila["Descripcion"].ToString();
                dArticulo.IdCategoria = Convert.ToInt32(fila["idcategoria"].ToString());
                dArticulo.Idsubcategoria = Convert.ToInt32(fila["idsubcategoria"].ToString());
                dArticulo.Precio = Convert.ToDecimal(fila["Precio"].ToString());
                dArticulo.StockActual = Convert.ToDecimal(fila["stock_actual"].ToString());
                dArticulo.PrecioCompra = Convert.ToDecimal(fila["Precio_Compra"].ToString());
                dArticulo.Utilidad = Convert.ToDecimal(fila["Utilidad"].ToString());
                dArticulo.Estado = Convert.ToBoolean(fila["estado"].ToString());
                dArticulo.Pesable = Convert.ToBoolean( fila["pesable"]) == false ? 0 : 1;
                //dArticulo.Preciomanual = Convert.ToBoolean(fila["preciomanual"].ToString());
                dArticulo.Flete = Convert.ToDecimal(fila["Flete"].ToString());
                dArticulo.Stock_minimo = Convert.ToDecimal(fila["stock_minimo"].ToString());
                dArticulo.Tipobalanza = Convert.ToBoolean(fila["balanza"].ToString());

                if (opcionsistema == "mayorista")
                {
                    dArticulo.Utilidadpreciopormayor = Convert.ToDecimal(fila["Utilidadpormayor"].ToString());
                    dArticulo.Preciopormayor = Convert.ToDecimal(fila["Preciopormayor"].ToString());
                    dArticulo.Utilidadpreciopormayor2 = Convert.ToDecimal(fila["Utilidadpormayor2"].ToString());
                    dArticulo.Preciopormayor2 = Convert.ToDecimal(fila["Preciopormayor2"].ToString());
                    dArticulo.Utilidadoferta = Convert.ToDecimal(fila["Utilidadoferta"]);
                    dArticulo.Precio_oferta = Convert.ToDecimal(fila["Precio_Oferta"]);
                }

                listaArticulo.Add(dArticulo);
            }
            
            DatosArticulo datosArticulo = new DatosArticulo();
            if (opcionexportacion   == "nube")
            {
                datosArticulo.insertararticulomysql(listaArticulo);
            }
            else if (opcionexportacion == "archivo")
            {
                datosArticulo.insertararticulosqlite(listaArticulo);
            }

            return "";
        }



        public Boolean Sindatos
        {
            get { return sindatos; }
            set { sindatos = value ; }
        
        }
        public int IdArticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public decimal StockActual
        {
            get { return stockActual; }
            set { stockActual = value; }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string BuscarArticulo
        {
            get { return buscarArticulo; }
            set { buscarArticulo = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public decimal PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }

        public decimal Preciopormayor
        {
            get
            {
                return preciopormayor;
            }

            set
            {
                preciopormayor = value;
            }
        }

        public decimal Cantidadpormayor
        {
            get
            {
                return cantidadpormayor;
            }

            set
            {
                cantidadpormayor = value;
            }
        }

        public decimal Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public decimal Cantidadpormayor2
        {
            get
            {
                return cantidadpormayor2;
            }

            set
            {
                cantidadpormayor2 = value;
            }
        }

        public decimal Preciopormayor2
        {
            get
            {
                return preciopormayor2;
            }

            set
            {
                preciopormayor2 = value;
            }
        }

        public decimal Precio_oferta
        {
            get
            {
                return precio_oferta;
            }

            set
            {
                precio_oferta = value;
            }
        }

        public DateTime Fechadeoferta
        {
            get
            {
                return fechadeoferta;
            }

            set
            {
                fechadeoferta = value;
            }
        }

        public bool Habilitarfechaoferta
        {
            get
            {
                return habilitarfechaoferta;
            }

            set
            {
                habilitarfechaoferta = value;
            }
        }

        public decimal Bulto_cantidad
        {
            get
            {
                return bulto_cantidad;
            }

            set
            {
                bulto_cantidad = value;
            }
        }

        public string Bulto_codigobarra
        {
            get
            {
                return bulto_codigobarra;
            }

            set
            {
                bulto_codigobarra = value;
            }
        }

        public string Nombrecategoria
        {
            get
            {
                return nombrecategoria;
            }

            set
            {
                nombrecategoria = value;
            }
        }

        public decimal Stock_minimo
        {
            get
            {
                return stock_minimo;
            }

            set
            {
                stock_minimo = value;
            }
        }
    }
}
