using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Datos
{
    public class DatosMovStock
    {
        //campos
        private int idmovStock;
        private int idProveedor;
        private DateTime fecha;
        private string tipoComprobante;
        private string serie;
        private string correlativa;
        private float iva;
        private string buscarMovStock;
        private string estado;
        private string movimiento;

     
        public DatosMovStock() { 
        
        
        }
        public DatosMovStock(int idMovStock,int idProveedor,DateTime fecha,string tipoComprobante,string serie
            ,string correlativa,float iva,string estado,string movimiento) {
                this.idmovStock = idMovStock;
                this.idProveedor = idProveedor;
                this.fecha = fecha;
                this.tipoComprobante = tipoComprobante;
                this.serie = serie;
                this.correlativa = correlativa;
                this.iva = iva;
                this.estado = estado;
                this.movimiento = movimiento;
        }

        public string agregar(DatosMovStock movStock,List<DatosDetalleMovStock> detalleMovStock,List<DatosArticulo>listaArticulos)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            string respuesta2 = "";
            try
            {

                cn.Open();
                //abro conexion
                //una unica transaccion por ingreso, y sus detalles de ingreso
                SqlTransaction transaccion = cn.BeginTransaction();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_MOVSTOCK", transaccion);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                comando.Parameters.Add(parModo);

                SqlParameter parIdMovStock = ProcAlmacenado.asignarParametros("@idmov_stock", SqlDbType.Int);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdMovStock);

                SqlParameter parFecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.Date, movStock.fecha);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parFecha);

                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int, movStock.idProveedor);
                comando.Parameters.Add(parIdProveedor);

                SqlParameter parTipoComprobante = ProcAlmacenado.asignarParametros("@tipo_comprobante", SqlDbType.VarChar, movStock.tipoComprobante, 7);
                comando.Parameters.Add(parTipoComprobante);

                SqlParameter parIva = ProcAlmacenado.asignarParametros("@iva", SqlDbType.Decimal, movStock.iva);
                comando.Parameters.Add(parIva);

                SqlParameter parSerie = ProcAlmacenado.asignarParametros("@serie", SqlDbType.VarChar, movStock.serie, 4);
                comando.Parameters.Add(parSerie);

                SqlParameter parCorrelativa = ProcAlmacenado.asignarParametros("@correlativa", SqlDbType.VarChar, movStock.correlativa, 8);
                comando.Parameters.Add(parCorrelativa);

                SqlParameter parEstado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.VarChar, movStock.estado, 7);
                comando.Parameters.Add(parEstado);

                //cambiar movimiento!!!
                SqlParameter parMovimiento = ProcAlmacenado.asignarParametros("@movimiento", SqlDbType.VarChar,movStock.Movimiento, 7);
                comando.Parameters.Add(parMovimiento);
                if (comando.ExecuteNonQuery() == 1)
                {

                    respuesta = "ok";
                    movStock.IdmovStock = Convert.ToInt32(comando.Parameters["@idmov_stock"].Value);
                    //agrego los de talle de movstock
                    foreach (DatosDetalleMovStock detalle in detalleMovStock)
                    {
                        detalle.IdMovStock = movStock.idmovStock;
                        respuesta = detalle.agregar(detalle, ref cn, ref transaccion);
                        if (!respuesta.Equals("ok"))
                        {
                            break;

                        }
                    }
                    //actualizo los datos de los productos
                    foreach (DatosArticulo articulos in listaArticulos)
                    {
                        //le paso el string de movimiento realizado para diferencia entre egreso y egreso
                        respuesta2 = articulos.actualizarPrecioStock(articulos,ref cn,ref transaccion,movStock.Movimiento);
                        if (!respuesta.Equals("ok"))
                        {
                            break;

                        }
                    }
                    //si ocurrio algun error hace un rollback
                    //o sino confirma la trasaccion con un commit
                    if (respuesta.Equals("ok")&&respuesta2.Equals("ok"))
                    {

                        transaccion.Commit();
                    }
                    else
                    {
                        transaccion.Rollback();
                    }
                }
                else
                {

                    respuesta = "error al intentar agregar detalles de movStock";
                }
             
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                cn.Close();
            }
            finally {
                if (cn.State == ConnectionState.Open) {

                    cn.Close();
                }
            }
            return respuesta;
        }

        public string anular(DatosMovStock detalleMovStock)
        {
            //modo 3 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_MOVSTOCK");
                //MODO 3 ELIMINAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                comando.Parameters.Add(parModo);

                SqlParameter parIdMovStock = ProcAlmacenado.asignarParametros("@idmov_stock", SqlDbType.Int, detalleMovStock.idmovStock);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdMovStock);


                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {
                    respuesta = "error: no se ha podido anular";
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
        public DataTable buscarTexto(string textoBuscar, string textoBuscar2)
        {
            //Modo 4 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("mov_stock");
            try
            {


                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_MOVSTOCK");
                //MODO 3 buscartexto
               
                    //busca por fecha
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                    comando.Parameters.Add(parModo);
                
               
                SqlParameter parIdMovStock = ProcAlmacenado.asignarParametros("@idmov_stock", SqlDbType.Int);
                comando.Parameters.Add(parIdMovStock);
                //le paso al sqlcommand los parametros asignados
                SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTextoFecha", SqlDbType.VarChar, textoBuscar, 50);
                //le paso al comando el parametro
                comando.Parameters.Add(parBuscarTexto);

                SqlParameter parBuscarTexto2 = ProcAlmacenado.asignarParametros("@buscarTextoFecha2", SqlDbType.VarChar, textoBuscar2, 50);
                //le paso al comando el parametro
                comando.Parameters.Add(parBuscarTexto2);
               

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
        //MUESTRA LOS DETALLES DEL MOVIMIENTO DE STOCK P/EJ LOS PRODUCTOS,PRECIO ETC
        public DataTable mostrarDetalleMovStock(int idmovstock)
        {
            //Modo 4 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("detalle_movstock");
            try
            {


                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_DETALLEMOVSTOCK");
                //MODO 3 buscartexto

                //busca por fecha
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                comando.Parameters.Add(parModo);


                SqlParameter parIddetalle_movstock = ProcAlmacenado.asignarParametros("@iddetalle_movstock", SqlDbType.Int);
                comando.Parameters.Add(parIddetalle_movstock);
                //le paso al sqlcommand los parametros asignados
                SqlParameter parIdMovStock = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.Int, idmovstock, 50);
                //le paso al comando el parametro
                comando.Parameters.Add(parIdMovStock);


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
        //MUESTRA LOS MOVIMIENTO DE STOCK
        public DataTable mostrarMovStock()
        {
            //Modo 5 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("mov_stock");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_MOVSTOCK");
                //Modo 5 MOSTRAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                comando.Parameters.Add(parModo);
                //Asigno al parametro @idMovStock, aunque no lo use
                SqlParameter parIdMovStock= ProcAlmacenado.asignarParametros("@idmov_stock", SqlDbType.Int);
                comando.Parameters.Add(parIdMovStock);

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

        //PROPIEDADES
        public int IdmovStock
        {
            get { return idmovStock; }
            set { idmovStock = value; }
        }
        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string TipoComprante
        {
            get { return tipoComprobante; }
            set { tipoComprobante = value; }
        }
        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }
        public string Correlativa
        {
            get { return correlativa; }
            set { correlativa = value; }
        }

        public float IVA
        {
            get { return iva; }
            set { iva = value; }
        }

        public string BuscarMovStock
        {
            get { return buscarMovStock; }
            set { buscarMovStock = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Movimiento
        {
            get { return movimiento; }
            set { movimiento = value; }
        }
       
    }
}
