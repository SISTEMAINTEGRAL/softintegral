using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DatosArticulo
    {
        //campos
        private int idArticulo;
        private string nombre;
        private string codigo;
        private string descripcion;
        private int idCategoria;
        private string buscarArticulo;
        private decimal precio;
        private decimal stockActual;
        private Boolean sindatos;
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




        //constructores
        public DatosArticulo() { 
        
        }
        public DatosArticulo(string nombre,string codigo,string descripcion,int idCategoria,decimal precio,decimal cantInicial,
            int pesable,decimal varpreciocompra, decimal varutilidad,decimal varflete, DateTime varfecha,DateTime varfechaoferta, int varedicionusuario = 0,
            string varlugaredicion = "", int varidsubcategoria = 0,decimal varcantidadpormayor = 0, decimal varpreciopormayor = 0, 
            decimal iva = 0, decimal varcantidadpormayor2 = 0, decimal varpreciopormayor2 = 0, decimal varprecio_oferta = 0,
             bool varhabilitarfechaoferta = false, decimal varbulto_cantidad = 0, string varbulto_codigobarra = "",
             decimal varutilidadpormayor = 0, decimal varutilidadpormayor2 = 0,decimal varutilidadoferta = 0)
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
        
        public string agregar(DatosArticulo articulo)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                comando.Parameters.Add(parModo);

                SqlParameter parIdArticulo= ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int,articulo.idArticulo);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdArticulo);

                SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar, articulo.Nombre, 50);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parNombre);

                SqlParameter parDescripcion = ProcAlmacenado.asignarParametros("@descripcion", SqlDbType.VarChar, articulo.Descripcion, 50);
                comando.Parameters.Add(parDescripcion);

                SqlParameter parCodigo = ProcAlmacenado.asignarParametros("@codigo", SqlDbType.VarChar, articulo.codigo,50);
                comando.Parameters.Add(parCodigo);

                SqlParameter parIdCategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int, articulo.idCategoria);
                comando.Parameters.Add(parIdCategoria);

                SqlParameter parPrecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Money, articulo.Precio);
                comando.Parameters.Add(parPrecio);

                SqlParameter parStockActual = ProcAlmacenado.asignarParametros("@stockActual", SqlDbType.Int, articulo.StockActual);
                comando.Parameters.Add(parStockActual);

                SqlParameter parPesable = ProcAlmacenado.asignarParametros("@pesable", SqlDbType.Bit, articulo.Pesable);
                comando.Parameters.Add(parPesable);

                SqlParameter parPreciocompra = ProcAlmacenado.asignarParametros("@precio_compra", SqlDbType.Money, articulo.precioCompra);
                comando.Parameters.Add(parPreciocompra);

                SqlParameter parUtilidad = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Money, articulo.utilidad);
                comando.Parameters.Add(parUtilidad);

                SqlParameter parFlete = ProcAlmacenado.asignarParametros("@flete", SqlDbType.Money, articulo.flete);
                comando.Parameters.Add(parFlete);

                SqlParameter paridsubcategoria = ProcAlmacenado.asignarParametros("@idsubcategoria", SqlDbType.Int, articulo.Idsubcategoria);
                comando.Parameters.Add(paridsubcategoria);

                SqlParameter parpreciopormayor = ProcAlmacenado.asignarParametros("@preciopormayor", SqlDbType.Money, articulo.Preciopormayor);
                comando.Parameters.Add(parpreciopormayor);

                SqlParameter parcantidadmayorista = ProcAlmacenado.asignarParametros("@cantidadpormayor", SqlDbType.Money, articulo.Cantidadpormayor );
                comando.Parameters.Add(parcantidadmayorista);

                SqlParameter pariva = ProcAlmacenado.asignarParametros("@iva", SqlDbType.Decimal , articulo.Iva);
                comando.Parameters.Add(pariva);

                SqlParameter parcantidadpormayor2 = ProcAlmacenado.asignarParametros("@cantidadpormayor2", SqlDbType.Decimal, articulo.cantidadpormayor2);
                comando.Parameters.Add(parcantidadpormayor2);

                SqlParameter parpreciopormayor2 = ProcAlmacenado.asignarParametros("@preciopormayor2", SqlDbType.Decimal, articulo.preciopormayor2);
                comando.Parameters.Add(parpreciopormayor2);

                SqlParameter parprecio_oferta = ProcAlmacenado.asignarParametros("@precio_oferta", SqlDbType.Decimal, articulo.precio_oferta);
                comando.Parameters.Add(parprecio_oferta);

                SqlParameter parfechadeoferta = ProcAlmacenado.asignarParametros("@fechadeoferta", SqlDbType.DateTime, articulo.fecha_oferta);
                comando.Parameters.Add(parfechadeoferta);

                SqlParameter parhabilitarfechaoferta = ProcAlmacenado.asignarParametros("@habilitarfechaoferta", SqlDbType.Bit, articulo.habilitarfechaoferta);
                comando.Parameters.Add(parhabilitarfechaoferta);

                SqlParameter parbulto_cantidad = ProcAlmacenado.asignarParametros("@bulto_cantidad", SqlDbType.Decimal, articulo.bulto_cantidad);
                comando.Parameters.Add(parbulto_cantidad);

                SqlParameter parbulto_codigobarra= ProcAlmacenado.asignarParametros("@bulto_codigobarra", SqlDbType.VarChar, articulo.bulto_codigobarra);
                comando.Parameters.Add(parbulto_codigobarra);

                SqlParameter parutilidadpreciomayorista = ProcAlmacenado.asignarParametros("@utilidadpormayor", SqlDbType.Decimal, articulo.utilidadpreciopormayor);
                comando.Parameters.Add(parutilidadpreciomayorista);

                SqlParameter parutilidadpreciomayorista2 = ProcAlmacenado.asignarParametros("@utilidadpormayor2", SqlDbType.Decimal, articulo.utilidadpreciopormayor2);
                comando.Parameters.Add(parutilidadpreciomayorista2);

                SqlParameter parutilidadoferta = ProcAlmacenado.asignarParametros("@utilidadoferta", SqlDbType.Decimal, articulo.utilidadoferta);
                comando.Parameters.Add(parutilidadoferta);



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
        public string editar(DatosArticulo articulo, int modo = 2)
        {
            //modo 2 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, modo);
                comando.Parameters.Add(parModo);

                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int, articulo.IdArticulo);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdArticulo);

                SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar, articulo.Nombre, 50);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parNombre);

                SqlParameter parDescripcion = ProcAlmacenado.asignarParametros("@descripcion", SqlDbType.VarChar, articulo.Descripcion, 50);
                comando.Parameters.Add(parDescripcion);

                SqlParameter parCodigo = ProcAlmacenado.asignarParametros("@codigo", SqlDbType.VarChar, articulo.codigo,50);
                comando.Parameters.Add(parCodigo);

                SqlParameter parPrecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Money, articulo.Precio);
                comando.Parameters.Add(parPrecio);
                
                SqlParameter parStockActual = ProcAlmacenado.asignarParametros("@stockActual", SqlDbType.Int, articulo.StockActual);
                comando.Parameters.Add(parStockActual);

                SqlParameter parIdCategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int, articulo.idCategoria);
                comando.Parameters.Add(parIdCategoria);

                SqlParameter parPesable = ProcAlmacenado.asignarParametros("@pesable", SqlDbType.Bit, articulo.Pesable);
                comando.Parameters.Add(parPesable);

                SqlParameter parPcompra = ProcAlmacenado.asignarParametros("@precio_compra", SqlDbType.Decimal, articulo.precioCompra);
                comando.Parameters.Add(parPcompra);

                SqlParameter parUtilidad = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Decimal, articulo.utilidad);
                comando.Parameters.Add(parUtilidad);

                SqlParameter parFlete = ProcAlmacenado.asignarParametros("@flete", SqlDbType.Decimal, articulo.flete);
                comando.Parameters.Add(parFlete);

                SqlParameter paredicionusuario = ProcAlmacenado.asignarParametros("@edicionusuario", SqlDbType.Int, articulo.editarusuario);
                comando.Parameters.Add(paredicionusuario);

                SqlParameter paredicionfecha = ProcAlmacenado.asignarParametros("@edicionfecha", SqlDbType.DateTime, articulo.fecha);
                comando.Parameters.Add(paredicionfecha);

                SqlParameter paredicionlugar = ProcAlmacenado.asignarParametros("@edicionlugar", SqlDbType.NVarChar, articulo.editarlugar);
                comando.Parameters.Add(paredicionlugar);

                SqlParameter parpreciopormayor = ProcAlmacenado.asignarParametros("@preciopormayor", SqlDbType.Decimal, articulo.Preciopormayor);
                comando.Parameters.Add(parpreciopormayor);

                SqlParameter parcantidadpormayor = ProcAlmacenado.asignarParametros("@cantidadpormayor", SqlDbType.Decimal, articulo.Cantidadpormayor);
                comando.Parameters.Add(parcantidadpormayor);

                SqlParameter paridsubcategoria= ProcAlmacenado.asignarParametros("@idsubcategoria", SqlDbType.Int, articulo.Idsubcategoria);
                comando.Parameters.Add(paridsubcategoria);

                SqlParameter pariva = ProcAlmacenado.asignarParametros("@iva", SqlDbType.Decimal, articulo.iva);
                comando.Parameters.Add(pariva);

                SqlParameter parcantidadpormayor2 = ProcAlmacenado.asignarParametros("@cantidadpormayor2", SqlDbType.Decimal, articulo.cantidadpormayor2);
                comando.Parameters.Add(parcantidadpormayor2);

                SqlParameter parpreciopormayor2 = ProcAlmacenado.asignarParametros("@preciopormayor2", SqlDbType.Decimal, articulo.preciopormayor2);
                comando.Parameters.Add(parpreciopormayor2);

                SqlParameter parprecio_oferta = ProcAlmacenado.asignarParametros("@precio_oferta", SqlDbType.Decimal, articulo.precio_oferta);
                comando.Parameters.Add(parprecio_oferta);

                SqlParameter parfechadeoferta = ProcAlmacenado.asignarParametros("@fechadeoferta", SqlDbType.DateTime, articulo.fecha_oferta);
                comando.Parameters.Add(parfechadeoferta);

                SqlParameter parhabilitarfechaoferta = ProcAlmacenado.asignarParametros("@habilitarfechaoferta", SqlDbType.Bit, articulo.habilitarfechaoferta);
                comando.Parameters.Add(parhabilitarfechaoferta);

                SqlParameter parbulto_cantidad = ProcAlmacenado.asignarParametros("@bulto_cantidad", SqlDbType.Decimal, articulo.bulto_cantidad);
                comando.Parameters.Add(parbulto_cantidad);

                SqlParameter parbulto_codigobarra = ProcAlmacenado.asignarParametros("@bulto_codigobarra", SqlDbType.VarChar, articulo.bulto_codigobarra);
                comando.Parameters.Add(parbulto_codigobarra);

                SqlParameter parutilidadpreciomayorista = ProcAlmacenado.asignarParametros("@utilidadpormayor", SqlDbType.Decimal, articulo.utilidadpreciopormayor);
                comando.Parameters.Add(parutilidadpreciomayorista);

                SqlParameter parutilidadpreciomayorista2 = ProcAlmacenado.asignarParametros("@utilidadpormayor2", SqlDbType.Decimal, articulo.utilidadpreciopormayor2);
                comando.Parameters.Add(parutilidadpreciomayorista2);

                SqlParameter parutilidadoferta = ProcAlmacenado.asignarParametros("@utilidadoferta", SqlDbType.Decimal, articulo.utilidadoferta);
                comando.Parameters.Add(parutilidadoferta);


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

        public void edicionmasiva(List <DatosArticulo> Articulos)
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
                   rpta = art.editar(art);
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
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //MODO 3 ELIMINAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                comando.Parameters.Add(parModo);

                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int,articulo.idArticulo);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdArticulo);

               
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
                

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //MODO 4 buscartexto

                //buscartexto=0 busca por nombre
                //buscartexto=1 busca por codigoBarra   
                //buscartexto=2 busca por categoria
                if (buscarTexto == 0)
                {
                    //busca por nombre de producto
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                    comando.Parameters.Add(parModo);
                    SqlParameter parCategoria = ProcAlmacenado.asignarParametros("@nombrecategoria", SqlDbType.NVarChar,articulo.nombrecategoria);
                    comando.Parameters.Add(parCategoria);
                    SqlParameter parDescripcion = ProcAlmacenado.asignarParametros("@descripcion", SqlDbType.NVarChar,articulo.descripcion);
                    comando.Parameters.Add(parDescripcion);
                }
                else if(buscarTexto==1) {
                    //busca por codigo de barra del producto
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 6);
                    comando.Parameters.Add(parModo);
                }
                else if (buscarTexto == 2)
                {
                    //busca por categoria de producto
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 7);
                    comando.Parameters.Add(parModo);
                
                }
                else if (buscarTexto == 3)
                {
                    //busca por idarticulo
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 8);
                    comando.Parameters.Add(parModo);

                }
                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int);
                comando.Parameters.Add(parIdArticulo);
                //le paso al sqlcommand los parametros asignados
                SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.VarChar, articulo.buscarArticulo, 50);
                //le paso al comando el parametro
                comando.Parameters.Add(parBuscarTexto);
                //modo buscar
              
                SqlParameter parIdCategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int,articulo.idCategoria);
                comando.Parameters.Add(parIdCategoria);

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
        public DataTable mostrar()
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
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 5);
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

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //Modo 12 MOSTRAR pesables
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 12);
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
        public DataTable mostrarPesableXbusqueda(DatosArticulo articulo,string tipoDeBusqueda)
        {
            //Modo 13 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("articulo");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
                //Modo 13 MOSTRAR pesables
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 13);
                comando.Parameters.Add(parModo);
                //tipo de busqueda si es por idarticulo,codigodebarra,categoria,nombre
                SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.VarChar, tipoDeBusqueda);
                comando.Parameters.Add(parBuscarTexto);

                //Asigno al parametro @idcategoria, aunque no lo use
                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int,articulo.IdArticulo);
                comando.Parameters.Add(parIdArticulo);

                SqlParameter parCodigo = ProcAlmacenado.asignarParametros("@codigo", SqlDbType.VarChar, articulo.Codigo);
                comando.Parameters.Add(parCodigo);

                SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar,articulo.Nombre);
                comando.Parameters.Add(parNombre);

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

                SqlCommand comando = ProcAlmacenado.CrearTransaccion(con, transaccion);
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

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");
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
            //      ,[cantidadpormayor2]
            //,[preciopormayor2]
            //,[precio_oferta]
            //,[fechadeoferta]
            //,[habilitarfechaoferta]
            //,[bulto_cantidad]
            //,[bulto_codigobarra]
            query = "SELECT a.idarticulo,a.codigo ,a.nombre ,a.descripcion ,a.idcategoria ,a.precio,a.stock_actual,a.pesable,a.cantidadpormayor, a.preciopormayor,a.iva,a.cantidadpormayor2,a.preciopormayor2,a.precio_oferta,a.fechadeoferta,a.habilitarfechaoferta ,a.bulto_cantidad ,a.bulto_codigobarra,c.nombre as nombrecategoria FROM articulo A inner join categoria C on C.idcategoria = A.idcategoria  WHERE ";
            if (tipo == "poridarticulo")
            {
                query = query + " idarticulo = @id";
            }
            if (tipo == "porbarra")
            {
                query = query + " codigo = @id";
            }
            if (tipo == "porbulto")
            {
                query = query + " bulto_codigobarra = @id";
            }

           
            SqlCommand cmd = new SqlCommand(query, cn);
            if (tipo == "porbarra" || tipo == "porbulto")
            {
                cmd.Parameters.AddWithValue("@id", codbarra);
            }
            else
            {
                cmd.Parameters.AddWithValue("@id", codArticulo.ToString());
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
        public string editarPrecio(DatosArticulo articulo)
        {
            //modo 9 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 9);
                comando.Parameters.Add(parModo);

                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int, articulo.IdArticulo);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdArticulo);

                SqlParameter parPrecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Money, articulo.Precio);
                comando.Parameters.Add(parPrecio);

                SqlParameter parPrecioCompra = ProcAlmacenado.asignarParametros("@precio_compra", SqlDbType.Money, articulo.PrecioCompra);
                comando.Parameters.Add(parPrecioCompra);

                SqlParameter parUtilidad = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Int, articulo.Utilidad, 50);
                comando.Parameters.Add(parUtilidad);

                //SqlParameter par = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Int, articulo.Utilidad, 50);
                //comando.Parameters.Add(parUtilidad);

                //SqlParameter parUtilidad = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Int, articulo.Utilidad, 50);
                //comando.Parameters.Add(parUtilidad);

                //SqlParameter parUtilidad = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Int, articulo.Utilidad, 50);
                //comando.Parameters.Add(parUtilidad);

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



        public string editarPrecioMasivo(List<DatosArticulo> listaArticulo)
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
                        SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO", transaccion);

                        SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 9);
                        comando.Parameters.Add(parModo);

                        SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int, articulo.IdArticulo);
                        //le paso al sqlcommand los parametros asignados
                        comando.Parameters.Add(parIdArticulo);

                        SqlParameter parPrecio = ProcAlmacenado.asignarParametros("@precio", SqlDbType.Money, articulo.Precio);
                        comando.Parameters.Add(parPrecio);


                        SqlParameter parUtilidad = ProcAlmacenado.asignarParametros("@utilidad", SqlDbType.Decimal, articulo.Utilidad);
                        comando.Parameters.Add(parUtilidad);

                        SqlParameter parFlete = ProcAlmacenado.asignarParametros("@flete", SqlDbType.Decimal, articulo.Flete);
                        comando.Parameters.Add(parFlete);
                       
                        SqlParameter parCosto = ProcAlmacenado.asignarParametros("@precio_compra", SqlDbType.Decimal, articulo.PrecioCompra);
                        comando.Parameters.Add(parCosto);

                    SqlParameter parutilidadpormayor = ProcAlmacenado.asignarParametros("@utilidadpormayor", SqlDbType.Decimal, articulo.Utilidadpreciopormayor);
                    comando.Parameters.Add(parutilidadpormayor);

                    SqlParameter parutilidadpormayor2 = ProcAlmacenado.asignarParametros("@utilidadpormayor2", SqlDbType.Decimal, articulo.Utilidadpreciopormayor2);
                    comando.Parameters.Add(parutilidadpormayor2);

                    SqlParameter parutilidadoferta = ProcAlmacenado.asignarParametros("@utilidadoferta", SqlDbType.Decimal, articulo.Utilidadoferta);
                    comando.Parameters.Add(parutilidadoferta);

                    SqlParameter parpreciopormayor= ProcAlmacenado.asignarParametros("@preciopormayor", SqlDbType.Decimal, articulo.Preciopormayor);
                    comando.Parameters.Add(parpreciopormayor);

                    SqlParameter parpreciopormayor2 = ProcAlmacenado.asignarParametros("@preciopormayor2", SqlDbType.Decimal, articulo.Preciopormayor2);
                    comando.Parameters.Add(parpreciopormayor2);

                    SqlParameter parprecio_oferta = ProcAlmacenado.asignarParametros("@precio_oferta", SqlDbType.Decimal, articulo.Precio_oferta);
                    comando.Parameters.Add(parprecio_oferta);



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
                    SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ARTICULO", transaccion);

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
        public string cargarproductogondola(List<DatosArticulo> listaArticulo)
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

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "REPORTE_GONDOLA", transaccion);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "eliminar");
                comando.Parameters.Add(parModo);

                SqlParameter paridequipo = ProcAlmacenado.asignarParametros("@idequipo", SqlDbType.Int, idequipo);
                comando.Parameters.Add(paridequipo);
                comando.ExecuteNonQuery();

                if (respuesta.Equals("ok"))
                {
                    foreach (DatosArticulo articulo in listaArticulo)
                    {
                        comando = ProcAlmacenado.CrearProc(cn, "REPORTE_GONDOLA", transaccion);

                        parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "agregar");
                        comando.Parameters.Add(parModo);
                        //Asigno al parametro @idcategoria, aunque no lo use
                        SqlParameter parcodigo = ProcAlmacenado.asignarParametros("@idarticulo", SqlDbType.Int, Convert.ToInt32(articulo.idArticulo));
                        comando.Parameters.Add(parcodigo);

                        paridequipo = ProcAlmacenado.asignarParametros("@idequipo", SqlDbType.Int, idequipo);
                        comando.Parameters.Add(paridequipo);

                        SqlParameter parprecio_unidad = ProcAlmacenado.asignarParametros("@precio_unidad", SqlDbType.Decimal, articulo.precio);
                        comando.Parameters.Add(parprecio_unidad);

                        SqlParameter parpreciopormayor = ProcAlmacenado.asignarParametros("@preciopormayor", SqlDbType.Decimal, articulo.preciopormayor);
                        comando.Parameters.Add(parpreciopormayor);

                        SqlParameter parpreciopormayor2 = ProcAlmacenado.asignarParametros("@preciopormayor2", SqlDbType.Decimal, articulo.preciopormayor2);
                        comando.Parameters.Add(parpreciopormayor2);


                        SqlParameter parprecio_oferta = ProcAlmacenado.asignarParametros("@precio_oferta", SqlDbType.Decimal, articulo.precio_oferta);
                        comando.Parameters.Add(parprecio_oferta);

                        SqlParameter paridcategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int, articulo.idCategoria);
                        comando.Parameters.Add(paridcategoria);

                        SqlParameter parcodigobarra = ProcAlmacenado.asignarParametros("@codigobarraproducto", SqlDbType.NVarChar, articulo.codigo);
                        comando.Parameters.Add(parcodigobarra);



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
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "consulta");
                comando.Parameters.Add(parModo);
                //Asigno al parametro @idcategoria, aunque no lo use
                SqlParameter parcodigo = ProcAlmacenado.asignarParametros("@idequipo", SqlDbType.Int, idequipo);
                comando.Parameters.Add(parcodigo);

                
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

    }
}
