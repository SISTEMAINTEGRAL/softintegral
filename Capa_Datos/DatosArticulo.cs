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




        //constructores
        public DatosArticulo() { 
        
        }
        public DatosArticulo(string nombre,string codigo,string descripcion,int idCategoria,decimal precio,decimal cantInicial, int pesable,decimal varpreciocompra, decimal varutilidad, decimal varflete, DateTime varfecha, int varedicionusuario = 0, string varlugaredicion = "")
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

         }
        public DatosArticulo(int idArticulo,decimal precio)
        {
            this.idArticulo = idArticulo;
            this.precio = precio;
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
            query = "";
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            cn.Open();

            if (tipo == "poridarticulo")
            {
                query = "SELECT idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual,pesable FROM articulo WHERE idarticulo = @id";
            }
            if (tipo == "porbarra")
            {
                query = "SELECT idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual,pesable FROM articulo WHERE codigo = @id";
            }

           
            SqlCommand cmd = new SqlCommand(query, cn);
            if (tipo == "porbarra")
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
                    query = "SELECT idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual FROM articulo WHERE idarticulo = @id and pesable=1";
                }
                if (tipo == "porbarra")
                {
                    query = "SELECT idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual FROM articulo WHERE codigo = @id  and pesable=1";
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
                query = "SELECT top 1 idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual FROM articulo WHERE nombre = @nombre and estado=1";
            }
            else if (tipo == "pornombre"&&pesable==true) {
                query = "SELECT top 1 idarticulo,codigo ,nombre ,descripcion ,idcategoria ,precio,stock_actual FROM articulo WHERE nombre = @nombre and estado=1 and pesable=1";
            
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

      
    }
}
