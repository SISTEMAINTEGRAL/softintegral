using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.ComponentModel.Design;

namespace Capa_Datos
{
    public class DatosArticulo
    {
        //campos
        private int idArticulo = 0;
        private string nombre = "";
        private string codigo = "0";
        private string descripcion = "";
        private int idCategoria = 0;
        private string buscarArticulo ;
        private decimal precio ;
        private decimal stockActual;
        private Boolean sindatos ;
        private decimal utilidad;
        private decimal precioCompra;
        private int pesable;
        private string nombrecategoria;
        private decimal flete;
        private DateTime fecha;
        private int editarusuario;
        private string editarlugar;
        private string tipo;
        private decimal iva;
        private int modo;

        private decimal preciopormayor;
        private decimal cantidadpormayor;
        private int idsubcategoria;

        private decimal cantidadpormayor2;
        private decimal preciopormayor2;
        private decimal precio_oferta;
        private DateTime fecha_oferta;
        private bool habilitarfechaoferta;
        private decimal bulto_cantidad;
        private string bulto_codigobarra;
        private decimal utilidadpreciopormayor;
        private decimal utilidadpreciopormayor2;
        private decimal utilidadoferta;
        private decimal stock_minimo;

        private string opcionsistema;

        private DateTime fechaediciondesde;
        private DateTime fechaedicionhasta;
        SqlCommand comando;

        private int idequipo;
        public decimal Flete
        {
            get { return flete; }
            set { flete = value; }
        }

        public string Nombrecategoria
        {
            get { return nombrecategoria; }
            set { nombrecategoria = value; }
        }

        //getters and setters
        public decimal PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        public Boolean Sindatos
        {
            get { return sindatos; }
            set { sindatos = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
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
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
        public decimal StockActual
        {
            get { return stockActual; }
            set { stockActual = value; }
        }
        public decimal Utilidad
        {
            get { return utilidad; }
            set { utilidad = value; }
        }
        public int Pesable
        {
            get { return pesable; }
            set { pesable = value; }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int Editarusuario
        {
            get
            {
                return editarusuario;
            }

            set
            {
                editarusuario = value;
            }
        }

        public string Editarlugar
        {
            get
            {
                return editarlugar;
            }

            set
            {
                editarlugar = value;
            }
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

        public int Idsubcategoria
        {
            get
            {
                return idsubcategoria;
            }

            set
            {
                idsubcategoria = value;
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

        public DateTime Fecha_oferta
        {
            get
            {
                return fecha_oferta;
            }

            set
            {
                fecha_oferta = value;
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

        public decimal Utilidadpreciopormayor
        {
            get
            {
                return utilidadpreciopormayor;
            }

            set
            {
                utilidadpreciopormayor = value;
            }
        }

        public decimal Utilidadpreciopormayor2
        {
            get
            {
                return utilidadpreciopormayor2;
            }

            set
            {
                utilidadpreciopormayor2 = value;
            }
        }

        public decimal Utilidadoferta
        {
            get
            {
                return utilidadoferta;
            }

            set
            {
                utilidadoferta = value;
            }
        }

        public int Idequipo
        {
            get
            {
                return idequipo;
            }

            set
            {
                idequipo = value;
            }
        }

        public string Opcionsistema
        {
            get
            {
                return opcionsistema;
            }

            set
            {
                opcionsistema = value;
            }
        }

        public int Modo
        {
            get
            {
                return modo;
            }

            set
            {
                modo = value;
            }
        }

        public DateTime Fechaediciondesde
        {
            get
            {
                return fechaediciondesde;
            }

            set
            {
                fechaediciondesde = value;
            }
        }

        public DateTime Fechaedicionhasta
        {
            get
            {
                return fechaedicionhasta;
            }

            set
            {
                fechaedicionhasta = value;
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




        //constructores
        public DatosArticulo() { 
        
        }

        
        public DatosArticulo(string nombre,string codigo,string descripcion,int idCategoria,decimal precio,decimal cantInicial,
            int pesable,decimal varpreciocompra, decimal varutilidad,decimal varflete, DateTime varfecha,DateTime varfechaoferta, int varedicionusuario = 0,
            string varlugaredicion = "", int varidsubcategoria = 0,decimal varcantidadpormayor = 0, decimal varpreciopormayor = 0, 
            decimal iva = 0, decimal varcantidadpormayor2 = 0, decimal varpreciopormayor2 = 0, decimal varprecio_oferta = 0,
             bool varhabilitarfechaoferta = false, decimal varbulto_cantidad = 0, string varbulto_codigobarra = "",
             decimal varutilidadpormayor = 0, decimal varutilidadpormayor2 = 0,decimal varutilidadoferta = 0, string varopcionsistema = "mayorista")
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.StockActual = cantInicial;
            this.pesable = pesable;
            this.utilidad = varutilidad;
            this.precioCompra = varpreciocompra;
            this.flete = varflete;
            this.fecha = varfecha;
            this.editarlugar = varlugaredicion;
            this.editarusuario = varedicionusuario;
            this.Idsubcategoria = varidsubcategoria;
            this.Preciopormayor = varpreciopormayor;
            this.Cantidadpormayor = varcantidadpormayor;
            this.iva = iva;
            this.cantidadpormayor2 = varcantidadpormayor2;
            this.preciopormayor2 = varpreciopormayor2;
            this.precio_oferta = varprecio_oferta;
            this.habilitarfechaoferta = varhabilitarfechaoferta;
            this.bulto_cantidad = varbulto_cantidad;
            this.bulto_codigobarra = varbulto_codigobarra;
            this.fecha_oferta = varfechaoferta;
            this.utilidadpreciopormayor = varutilidadpormayor;
            this.utilidadpreciopormayor2 = varutilidadpormayor2;
            this.utilidadoferta = varutilidadoferta;
            this.opcionsistema = varopcionsistema;

         }
        public DatosArticulo(string nombre, string codigo, string descripcion, int idCategoria, decimal precio, decimal cantInicial, int pesable, decimal varpreciocompra, decimal varutilidad, decimal varflete, DateTime varfecha, int varedicionusuario = 0, string varlugaredicion = "", int varidsubcategoria = 0, decimal varcantidadpormayor = 0, decimal varpreciopormayor = 0, decimal iva = 0, string varopcionsistema ="")
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.StockActual = cantInicial;
            this.pesable = pesable;
            this.utilidad = varutilidad;
            this.precioCompra = varpreciocompra;
            this.flete = varflete;
            this.fecha = varfecha;
            this.editarlugar = varlugaredicion;
            this.editarusuario = varedicionusuario;
            this.Idsubcategoria = varidsubcategoria;
            this.Preciopormayor = varpreciopormayor;
            this.Cantidadpormayor = varcantidadpormayor;
            this.iva = iva;
            this.opcionsistema = varopcionsistema;

        }
        public DatosArticulo(int varidequipo)
        {
            this.idequipo = varidequipo;
        }
        public DatosArticulo(int idArticulo,decimal precio, decimal cantidad = 0, string tipo = "")
        {
            this.idArticulo = idArticulo;
            this.precio = precio;
            this.stockActual = cantidad;
            this.tipo = tipo;
        }
        public DatosArticulo(int idArticulo, decimal precio,decimal precioCompra,decimal utilidad)
        {

            this.idArticulo = idArticulo;
            this.precio = precio;
            this.utilidad = utilidad;
            this.precioCompra = precioCompra;
        }
        public DatosArticulo(string nombre, string codigo, string descripcion, int idCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            

        }
        public DatosArticulo(string codigo, int idarticulo)
        {
            this.codigo = codigo;
            this.idArticulo = idarticulo;
        
        }

        public void agregarparametros(DatosArticulo varobjarticulo, string opcionsistema)
        {

            comando.Parameters.AddWithValue("@idarticulo", varobjarticulo.idArticulo);
            comando.Parameters.AddWithValue("@nombre", varobjarticulo.nombre);
            comando.Parameters.AddWithValue("@descripcion", varobjarticulo.descripcion);
            comando.Parameters.AddWithValue("@codigo", varobjarticulo.codigo);
            comando.Parameters.AddWithValue("@idcategoria", varobjarticulo.idCategoria);
            comando.Parameters.AddWithValue("@precio", varobjarticulo.precio);
            comando.Parameters.AddWithValue("@stockactual", varobjarticulo.stockActual);
            comando.Parameters.AddWithValue("@pesable", varobjarticulo.pesable);
            comando.Parameters.AddWithValue("@precio_compra", varobjarticulo.precioCompra);
            comando.Parameters.AddWithValue("@utilidad", varobjarticulo.utilidad);
            comando.Parameters.AddWithValue("@flete", varobjarticulo.flete);
            comando.Parameters.AddWithValue("@idsubcategoria", varobjarticulo.idsubcategoria);
            comando.Parameters.AddWithValue("@preciopormayor", varobjarticulo.preciopormayor);
            comando.Parameters.AddWithValue("@cantidadpormayor", varobjarticulo.cantidadpormayor);
            comando.Parameters.AddWithValue("@iva", varobjarticulo.iva );
            comando.Parameters.AddWithValue("@cantidadpormayor2", varobjarticulo.cantidadpormayor2);
            comando.Parameters.AddWithValue("@preciopormayor2", varobjarticulo.preciopormayor2);
            comando.Parameters.AddWithValue("@stock_minimo", varobjarticulo.stock_minimo);

            if (opcionsistema == "mayorista")
            {
               
                comando.Parameters.AddWithValue("@precio_oferta", varobjarticulo.precio_oferta);
                
                comando.Parameters.AddWithValue("@habilitarfechaoferta", varobjarticulo.habilitarfechaoferta);
                comando.Parameters.AddWithValue("@bulto_cantidad", varobjarticulo.bulto_cantidad);
                comando.Parameters.AddWithValue("@bulto_codigobarra", varobjarticulo.bulto_codigobarra);
                comando.Parameters.AddWithValue("@utilidadpormayor", varobjarticulo.utilidadpreciopormayor);
                comando.Parameters.AddWithValue("@utilidadpormayor2", varobjarticulo.utilidadpreciopormayor2);
                comando.Parameters.AddWithValue("@utilidadoferta", varobjarticulo.utilidadoferta);
            }


        }

        public string agregar(DatosArticulo articulo, string opcionsistema)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");

                comando.Parameters.AddWithValue("@modo", 1);
                comando.Parameters.AddWithValue("@fechadeoferta", articulo.fecha_oferta);
                comando.Parameters.AddWithValue("@edicionfecha", articulo.fecha);
                agregarparametros(articulo, opcionsistema);

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";

                }
                else
                {

                    respuesta = "error";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                cn.Close();
            }
            return respuesta;
        }
        public string editar(DatosArticulo articulo, string opcionsistema = "negocio")
        {
            //modo 2 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                 comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");

                comando.Parameters.AddWithValue("@modo", 2);
                comando.Parameters.AddWithValue("@edicionfecha", articulo.fecha);
                if (opcionsistema == "mayorista")
                {
                    comando.Parameters.AddWithValue("@fechadeoferta", articulo.fecha_oferta);
                }
                
                //SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                //comando.Parameters.Add(parModo);

                agregarparametros(articulo, opcionsistema);

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {

                    respuesta = "error de ingreso";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;

            }
            return respuesta;

        }

        public void edicionmasiva(List <DatosArticulo> Articulos, string opcionsistema)
        {
            SqlConnection sqlcon = new SqlConnection();
            string rpta = "";
            try
            {
                sqlcon.ConnectionString = Conexion.conexion;
                sqlcon.Open();

                SqlTransaction sqltra = sqlcon.BeginTransaction();

                foreach (DatosArticulo art in Articulos)
                {
                   rpta = art.editar(art,opcionsistema);
                   if (!rpta.Equals("OK"))
                   {
                       break;
                   }
                
                }

                if (rpta.Equals("OK"))
                {
                    sqltra.Commit();
                }
                else
                {
                    sqltra.Rollback();
                }
            }
            catch (Exception e)
            {
              
            
            }
        
        }
        public string eliminar(DatosArticulo articulo)
        {
            //modo 3 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                cn.Open();
                //abro conexion
                comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //MODO 3 ELIMINAR
                comando.Parameters.AddWithValue("@modo", 3);
                comando.Parameters.AddWithValue("@idarticulo", articulo.idArticulo);
                       
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {
                    respuesta = "error: no se ha podido eliminar";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                respuesta = "error conexion: " + ex.Message;
            }
            return respuesta;

        }
        public DataTable buscarTexto(DatosArticulo articulo,int buscarTexto)
        {
            //Modo 4 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                

                 comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //MODO 4 buscartexto

                //buscartexto=0 busca por nombre
                //buscartexto=1 busca por codigoBarra   
                //buscartexto=2 busca por categoria
                if (buscarTexto == 0)
                {
                    //busca por nombre de producto
                    comando.Parameters.AddWithValue("@modo", 4);
                    comando.Parameters.AddWithValue("@nombrecategoria", articulo.nombrecategoria);
                    comando.Parameters.AddWithValue("@descripcion", articulo.descripcion);
                    
                }
                else if(buscarTexto==1) {
                    //busca por codigo de barra del producto
                    comando.Parameters.AddWithValue("@modo", 6);
                    
                }
                else if (buscarTexto == 2)
                {
                    //busca por categoria de producto
                    comando.Parameters.AddWithValue("@modo", 7);
                    
                
                }
                else if (buscarTexto == 3)
                {
                    //busca por idarticulo
                    comando.Parameters.AddWithValue("@modo", 8);
                    

                }
                else if (buscarTexto == 4)
                {
                    comando.Parameters.AddWithValue("@modo", 15);
                    comando.Parameters.AddWithValue("@fechadesde", articulo.fechaediciondesde);
                    comando.Parameters.AddWithValue("@fechahasta", articulo.fechaedicionhasta);
                }
                comando.Parameters.AddWithValue("@idarticulo",0);
                comando.Parameters.AddWithValue("@buscarTexto", articulo.buscarArticulo);
                comando.Parameters.AddWithValue("@idcategoria", articulo.IdCategoria);
                         

                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);
                cn.Close();
            }
            catch (Exception ex)
            {

                dtResult = null;
                cn.Close();
                //lanzo una excepcion en el caso de problemas con bd
                throw ex;
            }
            return dtResult;
        }
        public DataTable mostrar(bool mostrartodo = false)
        {

            //Modo 5 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //Modo 5 MOSTRAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, mostrartodo == false ? 5 : 16);
                comando.Parameters.Add(parModo);
                //Asigno al parametro @idcategoria, aunque no lo use
                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int);
                comando.Parameters.Add(parIdArticulo);

                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                throw ex;
            }
            return dtResult;
        }


        public DataTable mostrarPesable()
        {
            //Modo 5 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                cn.Open();

                comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //Modo 12 MOSTRAR pesables
                comando.Parameters.AddWithValue("@modo", 12);
                comando.Parameters.AddWithValue("@idarticulo", 0);


                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                throw ex;
            }
            return dtResult;
        }
        public DataTable mostrarPesableXbusqueda(DatosArticulo articulo,string tipoDeBusqueda)
        {
            //Modo 13 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                cn.Open();

                comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //Modo 13 MOSTRAR pesables
                comando.Parameters.AddWithValue("@modo", 13);
                comando.Parameters.AddWithValue("@buscarTexto", tipoDeBusqueda);
                comando.Parameters.AddWithValue("@idarticulo", articulo.IdArticulo);
                comando.Parameters.AddWithValue("@codigo", articulo.codigo);
                comando.Parameters.AddWithValue("@nombre", articulo.nombre);
                               
                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                throw ex;
            }
            return dtResult;
        }
        public string actualizarPrecioStock(DatosArticulo articulos, ref SqlConnection con, ref SqlTransaction transaccion,string movStock)
        {
            //devuelve la cantidad actual
            string stock = "select stock_actual from articulo where idarticulo=@idarticulo";
            string respuesta = "";
            string queryIngreso = 
                "update articulo set stock_actual=("+ stock+")+ @stock_actual where idarticulo=@idarticulo ";
            string queryEgreso =
                "update articulo set stock_actual=(" + stock + ")- @stock_actual where idarticulo=@idarticulo ";
            try
            {

                comando = ProcAlmacenado.CrearTransaccion(con, transaccion);
                //si movStock es ingreso asigno queryIngreso sino queryEgreso
                comando.CommandText= (movStock=="INGRESO") ?  queryIngreso :  queryEgreso;

                //comando.Parameters.AddWithValue("@precio", articulos.Precio);
                comando.Parameters.AddWithValue("@stock_actual", articulos.StockActual);
                comando.Parameters.AddWithValue("@idarticulo", articulos.idArticulo);
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {
                    respuesta = "error: no se ha podido modificar el precio y la cantidad en los productos";
                }
               
               
            }

            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;

            }

      
            return respuesta;
            
        }
        public DataTable obtenerProductoXIdProducto(DatosArticulo articulo)
        {

            //Modo 10 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                cn.Open();

                comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //Modo 10 ObtenerProductoXId

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 10);
                comando.Parameters.Add(parModo);

                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idArticulo", SqlDbType.Int,articulo.IdArticulo);
                comando.Parameters.Add(parIdArticulo);

                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                throw ex;
            }
            return dtResult;
        }
        //devuelve el valor de idArticulo
        public int obtenerIdArticulo()
        {
         
            int idArticulo=0;
            string queryObtenerIdArticulo = "select  IDENT_CURRENT('articulo')+1 as [idArticulo]";
                //(obtiene el ultimo valor del idarticulo)

            SqlConnection con = new SqlConnection(Conexion.conexion);
            con.Open();
            SqlTransaction transaccion = con.BeginTransaction();
                SqlCommand comando = ProcAlmacenado.CrearTransaccion(con, transaccion);
                
                comando.CommandText = queryObtenerIdArticulo;

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    
                    idArticulo = Convert.ToInt32(reader["idArticulo"] );
                    //GetInt32(0)
                }
                else {

                    idArticulo = 0;
                }

                con.Close();
            return idArticulo;

        }
        //select  IDENT_CURRENT('articulo')+1
        //metodo que trae los datos de la consulta por codigo de articulo o por codigo de barra


        public void ExtraerDatos(long codArticulo, string tipo, string codbarra = "")
        {
            this.sindatos = false;
            string query;
            //string query2 = "";
            query = "";
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            cn.Open();
           
            query = "SELECT a.idarticulo,a.codigo ,a.nombre ,a.descripcion ,a.idcategoria ,a.precio,a.stock_actual,a.pesable,a.cantidadpormayor, a.preciopormayor,a.iva,a.cantidadpormayor2,a.preciopormayor2,a.precio_oferta,a.fechadeoferta,a.habilitarfechaoferta ,a.bulto_cantidad ,a.bulto_codigobarra,c.nombre as nombrecategoria, a.stock_minimo FROM articulo A inner join categoria C on C.idcategoria = A.idcategoria  WHERE estado = 1";
            if (tipo == "poridarticulo")
            {
                query = query + " and idarticulo = @id";
            }
            if (tipo == "porbarra")
            {
                query = query + "and codigo = @id";
            }
            if (tipo == "porbulto")
            {
                query = query + "and bulto_codigobarra = @id";
            }

             
           
            SqlCommand cmd = new SqlCommand(query, cn);
            if (tipo == "porbarra" || tipo == "porbulto")
            {
                cmd.Parameters.AddWithValue("@id", codbarra);
            }
            else
            {
                cmd.Parameters.AddWithValue("@id", codArticulo);
            }
            
             //Convert.ToInt64(codArticulo));
            SqlDataReader reader = cmd.ExecuteReader();

            

            if (reader.Read())
            {

                this.codigo = Convert.ToString(reader["codigo"]);
                this.idArticulo = Convert.ToInt32(reader["idArticulo"]);
                this.idCategoria = Convert.ToInt32(reader["idcategoria"]);
                this.stockActual = Convert.ToInt32(reader["stock_actual"]);
                this.nombre = Convert.ToString(reader["nombre"]);
                this.descripcion = Convert.ToString(reader["descripcion"]);
                this.precio = Convert.ToDecimal(reader["precio"]);
                this.pesable = Convert.ToBoolean(reader["pesable"]) == true ? 1:0;
                this.Cantidadpormayor = Convert.ToDecimal(reader["cantidadpormayor"]);
                this.Preciopormayor = Convert.ToDecimal(reader["preciopormayor"]);
                this.iva = Convert.ToDecimal(reader["iva"]);
                this.cantidadpormayor2 = Convert.ToDecimal(reader["cantidadpormayor2"]);
                this.preciopormayor2 = Convert.ToDecimal(reader["preciopormayor2"]);
                this.precio_oferta = Convert.ToDecimal(reader["precio_oferta"]);
                this.fecha_oferta = Convert.ToDateTime(reader["fechadeoferta"]);
                this.habilitarfechaoferta = Convert.ToBoolean(reader["habilitarfechaoferta"]);
                this.Nombrecategoria = Convert.ToString(reader["nombrecategoria"]);
                this.stock_minimo = Convert.ToDecimal(reader["stock_minimo"]);
                this.sindatos = true;
            }


            cn.Close();


        }




        public void ExtraerDatos(long codArticulo, string tipo,bool pesable)
        {
            this.sindatos = false;
            string query;
            query = "";
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            cn.Open();
            if(pesable==true){

                if (tipo == "poridarticulo")
                {
                    query = "SELECT idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual,cantidadpormayor, preciopormayor FROM articulo WHERE idarticulo = @id and pesable=1";
                }
                if (tipo == "porbarra")
                {
                    query = "SELECT idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual,cantidadpormayor, preciopormayor FROM articulo WHERE codigo = @id  and pesable=1";
                }
            }
           


            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt64(codArticulo));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                this.codigo = Convert.ToString(reader["codigo"]);
                this.idArticulo = Convert.ToInt32(reader["idArticulo"]);
                this.idCategoria = Convert.ToInt32(reader["idcategoria"]);
                this.stockActual = Convert.ToInt32(reader["stock_actual"]);
                this.nombre = Convert.ToString(reader["nombre"]);
                this.descripcion = Convert.ToString(reader["descripcion"]);
                this.precio = Convert.ToDecimal(reader["precio"]);
                this.Cantidadpormayor = Convert.ToDecimal(reader["cantidadpormayor"]);
                this.Preciopormayor = Convert.ToDecimal(reader["preciopormayor"]);
                this.sindatos = true;
            }


            cn.Close();


        }

       

        public  void ExtraerDatos(string nombre, string tipo,bool pesable)
        {
            this.sindatos = false;
            string query;
            query = "";
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            cn.Open();

            if (tipo == "pornombre" && pesable == false)
            {
                query = "SELECT top 1 idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual,cantidadpormayor, preciopormayor FROM articulo WHERE nombre = @nombre and estado=1";
            }
            else if (tipo == "pornombre"&&pesable==true) {
                query = "SELECT top 1 idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual,cantidadpormayor, preciopormayor FROM articulo WHERE nombre = @nombre and estado=1 and pesable=1";
            
            }

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@nombre", nombre);

           
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                this.codigo = Convert.ToString(reader["codigo"]);
                this.idArticulo = Convert.ToInt32(reader["idArticulo"]);
                this.idCategoria = Convert.ToInt32(reader["idcategoria"]);
                this.stockActual = Convert.ToInt32(reader["stock_actual"]);
                this.nombre = Convert.ToString(reader["nombre"]);
                this.descripcion = Convert.ToString(reader["descripcion"]);
                this.precio = Convert.ToDecimal(reader["precio"]);
                this.Cantidadpormayor = Convert.ToDecimal(reader["cantidadpormayor"]);
                this.Preciopormayor = Convert.ToDecimal(reader["preciopormayor"]);
                this.sindatos = true;
            }


            cn.Close();


        }
        public string editarPrecio(DatosArticulo articulo, string opcionsistema)
        {
            //modo 9 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                comando.Parameters.AddWithValue("@modo", 9);
                agregarparametros(articulo,opcionsistema);

                

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {

                    respuesta = "error en la edición";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;

            }
            return respuesta;
        }



        public string editarPrecioMasivo(List<DatosArticulo> listaArticulo,string opcionsistema)
        {


            //modo 9 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlTransaction transaccion = cn.BeginTransaction();

                
               

                respuesta = "ok";

                  
                    //actualizo los datos de los productos
                    foreach (DatosArticulo articulo in listaArticulo)
                    {
                        comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO", transaccion);
                        comando.Parameters.AddWithValue("@modo", 9);
                        agregarparametros(articulo, opcionsistema);

                    //    SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int, articulo.IdArticulo);
                    //    //le paso al sqlcommand los parametros asignados
                    //    comando.Parameters.Add(parIdArticulo);

                    //    SqlParameter parPrecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Money, articulo.Precio);
                    //    comando.Parameters.Add(parPrecio);


                    //    SqlParameter parUtilidad = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Decimal, articulo.Utilidad);
                    //    comando.Parameters.Add(parUtilidad);

                    //    SqlParameter parFlete = ProcAlmacenado.asignarParametros("@flete", SqlDbType.Decimal, articulo.Flete);
                    //    comando.Parameters.Add(parFlete);
                       
                    //    SqlParameter parCosto = ProcAlmacenado.asignarParametros("@precio_compra", SqlDbType.Decimal, articulo.PrecioCompra);
                    //    comando.Parameters.Add(parCosto);

                    //SqlParameter parutilidadpormayor = ProcAlmacenado.asignarParametros("@utilidadpormayor", SqlDbType.Decimal, articulo.Utilidadpreciopormayor);
                    //comando.Parameters.Add(parutilidadpormayor);

                    //SqlParameter parutilidadpormayor2 = ProcAlmacenado.asignarParametros("@utilidadpormayor2", SqlDbType.Decimal, articulo.Utilidadpreciopormayor2);
                    //comando.Parameters.Add(parutilidadpormayor2);

                    //SqlParameter parutilidadoferta = ProcAlmacenado.asignarParametros("@utilidadoferta", SqlDbType.Decimal, articulo.Utilidadoferta);
                    //comando.Parameters.Add(parutilidadoferta);

                    //SqlParameter parpreciopormayor= ProcAlmacenado.asignarParametros("@preciopormayor", SqlDbType.Decimal, articulo.Preciopormayor);
                    //comando.Parameters.Add(parpreciopormayor);

                    //SqlParameter parpreciopormayor2 = ProcAlmacenado.asignarParametros("@preciopormayor2", SqlDbType.Decimal, articulo.Preciopormayor2);
                    //comando.Parameters.Add(parpreciopormayor2);

                    //SqlParameter parprecio_oferta = ProcAlmacenado.asignarParametros("@precio_oferta", SqlDbType.Decimal, articulo.Precio_oferta);
                    //comando.Parameters.Add(parprecio_oferta);



                    if (comando.ExecuteNonQuery() == 1)
                        {
                            respuesta = "ok";
                        }
                        else
                        {
                            //si ocurre un error sale del foreach
                            respuesta = "error en la edición";
                            break;
                        }


                       
                    }
                    //si ocurrio algun error hace un rollback
                    //o sino confirma la trasaccion con un commit
                    if (respuesta.Equals("ok") )
                    {

                        transaccion.Commit();
                    }
                    else
                    {
                        transaccion.Rollback();
                    }
               
               

            
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {

                    cn.Close();
                }
            }
            
            return respuesta;
        }

        //Productos mayoristas

        public DataTable preciomayorista(DatosArticulo objart)
        {
            //Modo 5 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //Modo 5 MOSTRAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modovarchar", SqlDbType.Int, "preciopormayor");
                comando.Parameters.Add(parModo);
                //Asigno al parametro @idcategoria, aunque no lo use
                SqlParameter parcodigo= ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int,objart.idArticulo);
                comando.Parameters.Add(parcodigo);

                SqlParameter parcantidad = ProcAlmacenado.asignarParametros("@stockactual", SqlDbType.Int, objart.stockActual);
                comando.Parameters.Add(parcantidad);

                SqlParameter partipo= ProcAlmacenado.asignarParametros("@tipo", SqlDbType.NVarChar, objart.tipo);
                comando.Parameters.Add(partipo);
                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                throw ex;
            }
            return dtResult;
        }

        public string cargarpreciomayorista(List<DatosArticulo> listaArticulo)
        {

            //modo 9 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);

            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlTransaction transaccion = cn.BeginTransaction();
                
                respuesta = "ok";

                bool eliminar = true;
                //actualizo los datos de los productos
                foreach (DatosArticulo articulo in listaArticulo)
                {
                     comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO", transaccion);

                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modovarchar", SqlDbType.Int, "preciopormayor");
                    comando.Parameters.Add(parModo);
                    //Asigno al parametro @idcategoria, aunque no lo use
                    SqlParameter parcodigo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int, Convert.ToInt32(articulo.idArticulo) );
                    comando.Parameters.Add(parcodigo);

                    SqlParameter parcantidad = ProcAlmacenado.asignarParametros("@stockactual", SqlDbType.Int, articulo.stockActual);
                    comando.Parameters.Add(parcantidad);

                    SqlParameter partipo = ProcAlmacenado.asignarParametros("@tipo", SqlDbType.NVarChar, articulo.tipo);
                    comando.Parameters.Add(partipo);

                    SqlParameter parprecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Decimal, articulo.precio);
                    comando.Parameters.Add(parprecio);


                    SqlParameter pareliminar = ProcAlmacenado.asignarParametros("@eliminar", SqlDbType.Bit, eliminar);
                    comando.Parameters.Add(pareliminar);

                    if (eliminar == true)
                    {
                        eliminar = false;
                    }

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        respuesta = "ok";
                    }
                    else
                    {
                        //si ocurre un error sale del foreach
                        respuesta = "error en la edición";
                        break;
                    }



                }
                //si ocurrio algun error hace un rollback
                //o sino confirma la trasaccion con un commit
                if (respuesta.Equals("ok"))
                {

                    transaccion.Commit();
                }
                else
                {
                    transaccion.Rollback();
                }




            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {

                    cn.Close();
                }
            }

            return respuesta;
            
            

        }
        public string cargarproductogondola(List<DatosArticulo> listaArticulo,string opcionsistema)
        {

            //modo 9 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);

            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlTransaction transaccion = cn.BeginTransaction();

                respuesta = "ok";

                 comando = ProcAlmacenado.CrearProc(cn, "REPORTE_GONDOLA", transaccion);
                 comando.Parameters.AddWithValue("@modo", "eliminar");
                 comando.Parameters.AddWithValue("@idequipo", idequipo);
                        
                comando.ExecuteNonQuery();

                if (respuesta.Equals("ok"))
                {
                    foreach (DatosArticulo articulo in listaArticulo)
                    {
                        comando = ProcAlmacenado.CrearProc(cn, "REPORTE_GONDOLA", transaccion);
                        comando.Parameters.AddWithValue("@modo", "agregar");
                        comando.Parameters.AddWithValue("@idarticulo", Convert.ToInt32(articulo.idArticulo));
                        comando.Parameters.AddWithValue("@idequipo", Convert.ToInt32(idequipo));
                        comando.Parameters.AddWithValue("@precio_unidad", Convert.ToDecimal(articulo.precio));
                        comando.Parameters.AddWithValue("@preciopormayor", Convert.ToDecimal(articulo.preciopormayor));
                        comando.Parameters.AddWithValue("@preciopormayor2", Convert.ToDecimal(articulo.preciopormayor2));
                        comando.Parameters.AddWithValue("@precio_oferta", Convert.ToDecimal(articulo.precio_oferta));
                        comando.Parameters.AddWithValue("@idcategoria", Convert.ToDecimal(articulo.IdCategoria));
                        comando.Parameters.AddWithValue("@codigobarraproducto", Convert.ToDecimal(articulo.codigo));

                        
                        if (comando.ExecuteNonQuery() == 1)
                        {
                            respuesta = "ok";
                        }
                        else
                        {
                            //si ocurre un error sale del foreach
                            respuesta = "error en la edición";
                            break;
                        }



                    }

                }
                    //actualizo los datos de los productos
               
                //si ocurrio algun error hace un rollback
                //o sino confirma la trasaccion con un commit
                if (respuesta.Equals("ok"))
                {

                    transaccion.Commit();
                }
                else
                {
                    transaccion.Rollback();
                }




            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {

                    cn.Close();
                }
            }

            return respuesta;



        }
        public DataTable consultaproductogondola()
        {

            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "REPORTE_GONDOLA");
                //Modo 5 MOSTRAR
                comando.Parameters.AddWithValue("@modo", "consulta");
                comando.Parameters.AddWithValue("@idequipo", idequipo);
                //Asigno al parametro @idcategoria, aunque no lo use
                

                
                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                throw ex;
            }
            return dtResult;

        }
        public DataTable mostrarsqlite ()
        {
            DataTable datadetalle = new DataTable();
            SQLiteConnection cadenaconexion = new SQLiteConnection(ConexionSQLITE.cadenaconexion);

            cadenaconexion.Open();
            using (SQLiteCommand micomando = new SQLiteCommand("select * from articulo ",cadenaconexion))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(micomando);
                adapter.Fill(datadetalle);

            }
            cadenaconexion.Close();
                return datadetalle;

        }
        
        public void insertararticulosqlite(List<DatosArticulo> listaArticulo)
        {
            SQLiteConnection cadenaconexion = new SQLiteConnection(ConexionSQLITE.cadenaconexion);
            ConexionSQLITE conexionSQLITE = new ConexionSQLITE();
            string query1 = " delete from articulo";
            conexionSQLITE.ExecuteQuery(query1);

            cadenaconexion.Open();

            foreach (DatosArticulo articulo in listaArticulo)
                {
                    bool articulopesable = articulo.pesable == 0 ? false : true;
                    
                   using (SQLiteCommand Comando = new SQLiteCommand("INSERT INTO articulo (idarticulo,codigo ,nombre ,descripcion,precio,precio_Compra " +
                    " ,utilidad,pesable ,flete ,cantidadpormayor,preciopormayor,iva ,cantidadpormayor2 ,preciopormayor2,precio_oferta " +
                    ",utilidadpormayor ,utilidadpormayor2,utilidadoferta,stock_minimo,stock_actual,idcategoria,estado,preciomanual,constock,idsubcategoria,bulto_cantidad,bulto_codigobarra) " +
                    " VALUES (@idarticulo,@codigo,@nombre,@descripcion,@precio,@precio_compra,@utilidad,@pesable,@flete,@cantidadpormayor, " +
                    " @preciopormayor,@iva,@cantidadpormayor2,@preciopormayor2,@precio_oferta,@utilidadpormayor,@utilidadpormayor2, " +
                    " @utilidadoferta, @stock_minimo,@stock_actual,@idcategoria,@estado,@preciomanual, @constock, @idsubcategoria,@bulto_cantidad,@bulto_codigobarra)  ", cadenaconexion))
                    {
                        Comando.Parameters.AddWithValue("@idarticulo", articulo.idArticulo);
                        Comando.Parameters.AddWithValue("@codigo", articulo.codigo);
                        Comando.Parameters.AddWithValue("@nombre", articulo.nombre);
                        Comando.Parameters.AddWithValue("@descripcion", articulo.descripcion);
                        Comando.Parameters.AddWithValue("@precio", articulo.precio);
                        Comando.Parameters.AddWithValue("@precio_compra", articulo.PrecioCompra);
                        Comando.Parameters.AddWithValue("@utilidad", articulo.utilidad);
                        Comando.Parameters.AddWithValue("@pesable", articulo.pesable == 0 ? false : true);
                        Comando.Parameters.AddWithValue("@flete", articulo.flete);
                        Comando.Parameters.AddWithValue("@cantidadpormayor", articulo.cantidadpormayor);
                        Comando.Parameters.AddWithValue("@preciopormayor", articulo.preciopormayor);
                        Comando.Parameters.AddWithValue("@iva", articulo.iva);
                        Comando.Parameters.AddWithValue("@cantidadpormayor2", articulo.cantidadpormayor2);
                        Comando.Parameters.AddWithValue("@preciopormayor2", articulo.preciopormayor2);
                        Comando.Parameters.AddWithValue("@precio_oferta", articulo.precio_oferta);
                        Comando.Parameters.AddWithValue("@utilidadpormayor", articulo.utilidadpreciopormayor);
                        Comando.Parameters.AddWithValue("@utilidadpormayor2", articulo.utilidadpreciopormayor2);
                        Comando.Parameters.AddWithValue("@utilidadoferta", articulo.utilidadoferta);
                        Comando.Parameters.AddWithValue("@stock_minimo", articulo.stock_minimo);
                        Comando.Parameters.AddWithValue("@stock_actual", 0);
                        Comando.Parameters.AddWithValue("@idcategoria", articulo.idCategoria);
                        Comando.Parameters.AddWithValue("@estado", 1);
                        Comando.Parameters.AddWithValue("@preciomanual", 1);
                        Comando.Parameters.AddWithValue("@constock", 1);
                        Comando.Parameters.AddWithValue("@idsubcategoria", articulo.idsubcategoria);
                        Comando.Parameters.AddWithValue("@bulto_cantidad", articulo.bulto_cantidad);
                        Comando.Parameters.AddWithValue("@bulto_codigobarra", articulo.bulto_codigobarra);

                    Comando.ExecuteNonQuery();
                       
                   }
            }

            cadenaconexion.Close();


        }

    }
}
