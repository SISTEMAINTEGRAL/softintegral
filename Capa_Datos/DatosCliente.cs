using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
   public class DatosCliente
    {
         //campos
        private int idProveedor;
        private string razonSocial;
        private string direccion;
        private long cuit;
        private long tel;
        private long numDocumento;
        private string email;
        private string buscarCliente;
        private DateTime fechaNacimiento;
        private string responsableiva;
        private int idprovincia;
        private int idlocalidad;
        private int idcliente;
        //para ctacte
        private int codventa;
        private string estado;
        private decimal saldo;
        private decimal pagado;
        private decimal total;
        private string modoctacte;
        private SqlConnection cn;
        private SqlTransaction sqltra;
        private string  fechaD;
        private string fechaH;
        public string BuscarCliente
        {
            get
            {
                return buscarCliente;
            }

            set
            {
                buscarCliente = value;
            }
        }

        public int Codventa
        {
            get
            {
                return codventa;
            }

            set
            {
                codventa = value;
            }
        }

        //     @Codcliente as int = 0,
        //   @Codventa as int = 0,
        //   @Estado as nvarchar(50) = 'Pendiente',
        //   @Saldo as money = 0,
        //   @Pagado as money = 0,
        //   @Total as money = 0,
        //@modo as nvarchar(50) = ''

        //Getters and setters




        //constructores
        public DatosCliente() { 
        
        }
        public DatosCliente(int varcodcliente, string  varfechaD, string varfechaH)
        {
            this.idcliente = varcodcliente;
            this.fechaD = varfechaD;
            this.fechaH = varfechaH;
        }
        public DatosCliente(ref SqlConnection miconexion, ref SqlTransaction mitransaccion,int varcodcliente, int varcodventa, decimal varsaldo, decimal vartotal, decimal varpagado, string varestado, string varmodoctacte)

        {
            this.cn = miconexion;
            this.sqltra = mitransaccion;
            this.idcliente = varcodcliente;
            this.Codventa = varcodventa;
            this.saldo = varsaldo;
            this.total = vartotal;
            this.pagado = varpagado;
            this.estado = varestado;
            this.modoctacte = varmodoctacte;
        }
        public DatosCliente(string razonSocial,string direccion,long cuit,long tel,long numDocumento,string email, string responsableiva, int varidprovincia, int varidlocalidad)
        {
            
           this.razonSocial=razonSocial;
            this.direccion=direccion;
            this.cuit=cuit;
            this.tel=tel;
            this.numDocumento = numDocumento;
            this.email=email;
            this.responsableiva = responsableiva;
            this.idprovincia = varidprovincia;
            this.idlocalidad = varidlocalidad;
         }

        public DatosCliente(int varidcliente)
        {
            idcliente = varidcliente;
        
        }
        public DatosCliente(int idprovincia =0, int idlocalidad = 0 )
        {
            this.idlocalidad = idlocalidad;
            this.idprovincia = idprovincia;
        }
        public DatosCliente (int varcodcliente, int varcodventa, decimal varsaldo, decimal vartotal, decimal varpagado, string varestado, string varmodoctacte)
        {
            this.idcliente = varcodcliente;
            this.Codventa = varcodventa;
            this.saldo = varsaldo;
            this.total = vartotal;
            this.pagado = varpagado;
            this.estado = varestado;
            this.modoctacte = varmodoctacte;

        }
        //crud
        public string agregar(DatosCliente cliente)
        {
            //modo 1 para DB
             cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdCliente);

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, cliente.razonSocial,150);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit= ProcAlmacenado.asignarParametros("@cuit", SqlDbType.BigInt, cliente.cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parTel = ProcAlmacenado.asignarParametros("@telefono", SqlDbType.BigInt, cliente.tel, 50);
                comando.Parameters.Add(parTel);

                SqlParameter parNumDocumento = ProcAlmacenado.asignarParametros("@num_documento", SqlDbType.BigInt, cliente.numDocumento);
                comando.Parameters.Add(parNumDocumento);

                SqlParameter parEmail = ProcAlmacenado.asignarParametros("@email", SqlDbType.VarChar, cliente.email, 50);
                comando.Parameters.Add(parEmail);
                
                SqlParameter parDireccion = ProcAlmacenado.asignarParametros("@direccion", SqlDbType.VarChar, cliente.direccion, 50);
                comando.Parameters.Add(parDireccion);

                SqlParameter parFechaNacimiento = ProcAlmacenado.asignarParametros("@fecha_nacimiento", SqlDbType.Date, cliente.fechaNacimiento);
                comando.Parameters.Add(parFechaNacimiento);

                SqlParameter parResponsableiva = ProcAlmacenado.asignarParametros("@responsableiva", SqlDbType.NVarChar, cliente.responsableiva);
                comando.Parameters.Add(parResponsableiva);

                SqlParameter parIdprovincia = ProcAlmacenado.asignarParametros("@idprovincia", SqlDbType.Int, cliente.idprovincia);
                comando.Parameters.Add(parIdprovincia);

                SqlParameter parIdlocalidad = ProcAlmacenado.asignarParametros("@idlocalidad", SqlDbType.Int, cliente.idlocalidad);
                comando.Parameters.Add(parIdlocalidad);

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
        public string editar(DatosCliente cliente)
        {
            //modo 2 para DB
             cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE");



                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int,cliente.idcliente);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdCliente);

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, cliente.razonSocial, 150);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit = ProcAlmacenado.asignarParametros("@cuit", SqlDbType.BigInt, cliente.cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parTel = ProcAlmacenado.asignarParametros("@telefono", SqlDbType.BigInt, cliente.tel, 50);
                comando.Parameters.Add(parTel);

                SqlParameter parNumDocumento = ProcAlmacenado.asignarParametros("@num_documento", SqlDbType.BigInt, cliente.numDocumento);
                comando.Parameters.Add(parNumDocumento);

                SqlParameter parEmail = ProcAlmacenado.asignarParametros("@email", SqlDbType.VarChar, cliente.email, 50);
                comando.Parameters.Add(parEmail);

                SqlParameter parDireccion = ProcAlmacenado.asignarParametros("@direccion", SqlDbType.VarChar, cliente.direccion, 50);
                comando.Parameters.Add(parDireccion);
                SqlParameter parFechaNacimiento = ProcAlmacenado.asignarParametros("@fecha_nacimiento", SqlDbType.Date, cliente.fechaNacimiento, 50);
                comando.Parameters.Add(parFechaNacimiento);

                SqlParameter parResponsableiva = ProcAlmacenado.asignarParametros("@responsableiva", SqlDbType.NVarChar, cliente.responsableiva );
                comando.Parameters.Add(parResponsableiva);

                SqlParameter parIdprovincia = ProcAlmacenado.asignarParametros("@idprovincia", SqlDbType.Int, cliente.idprovincia);
                comando.Parameters.Add(parIdprovincia);
                
                SqlParameter parIdlocalidad = ProcAlmacenado.asignarParametros("@idlocalidad", SqlDbType.Int, cliente.idlocalidad);
                comando.Parameters.Add(parIdlocalidad);
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {

                    respuesta = "error de ingreso";
                }
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                cn.Close();
            }
            return respuesta;

        }
        public string eliminar(DatosCliente cliente)
        {
            //modo 3 para DB
             cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_PROVEEDOR");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                comando.Parameters.Add(parModo);
           
                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int, cliente.idProveedor);
                comando.Parameters.Add(parIdProveedor);


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
        public DataTable buscarTexto(DatosCliente cliente)
        {
            //Modo 4 para DB
             cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("cliente");
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE");

                SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.VarChar,cliente.BuscarCliente, 50);
                //le paso al comando el parametro
                comando.Parameters.Add(parBuscarTexto);
                //modo buscar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, cliente.idcliente);
                comando.Parameters.Add(parIdCliente);
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
             cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("cliente");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 5);
                comando.Parameters.Add(parModo);
                //Asigno al parametro @idcliente, aunque no lo use
                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int);
                comando.Parameters.Add(parIdCliente);

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
                throw ex;
            }
            return dtResult;
        }
        public DataTable buscarCodigoCliente(DatosCliente cliente, int modo = 6)
        {
            //Modo 6 para DB
             cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("cliente");
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE");

                SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.VarChar, cliente.BuscarCliente, 50);
                //le paso al comando el parametro
                comando.Parameters.Add(parBuscarTexto);
                //modo buscar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, modo);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, cliente.idcliente);
                comando.Parameters.Add(parIdCliente);
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
        public DataTable provincia()
        {
           
            //Modo 3 para DB
             cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("cliente");
            cn.Open();
            try
            {
                //probar mas adelante 
                SqlParameter[] dbParams = new SqlParameter[]
                 {
                     ProcAlmacenado2.MakeParam("@modo", SqlDbType.Int, 0, 9),
                     ProcAlmacenado2.MakeParam("@idcliente", SqlDbType.Int, 0, 0)
                    //SqlParameter parCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, 0);
               // comando.Parameters.Add(parCliente);
                 
                 };
               dtResult = ProcAlmacenado2.ExecuteDatatable("SP_CLIENTE", dbParams);
                cn.Close();
                return dtResult;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        
        }
        public DataTable localidad()
        {
            //Modo 3 para DB
             cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("cliente");
            cn.Open();
            try
            {
                //probar mas adelante 
                SqlParameter[] dbParams = new SqlParameter[]
                 {
                     ProcAlmacenado2.MakeParam("@modo", SqlDbType.Int, 0, 10),
                     ProcAlmacenado2.MakeParam("@idcliente", SqlDbType.Int, 0, 0),
                     ProcAlmacenado2.MakeParam("@idprovincia", SqlDbType.Int, 0,idprovincia)
                    //SqlParameter parCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, 0);
               // comando.Parameters.Add(parCliente);
                 
                 };
               dtResult = ProcAlmacenado2.ExecuteDatatable ("SP_CLIENTE", dbParams);
                cn.Close();
                return dtResult;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        
        }
        public DataTable Responsabilidadiva()
        { 
            //Modo 6 para DB
             cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("cliente");
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE");

               
                //modo buscar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 8);
                comando.Parameters.Add(parModo);

                SqlParameter parCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, 0);
                comando.Parameters.Add(parCliente);

                
                
                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);
                cn.Close();
        }
            catch(Exception ) 
            {
                throw;

            }
                return dtResult ;
            }
        //cta cte de clientes ------------------------------------------------------
        public string agregaromodificarctacte(DatosCliente cliente)
        {
            string transaccion = "";
            //modo 1 para DB
            if (cn.State == ConnectionState.Closed )
            {
                cn = new SqlConnection(Conexion.conexion);

                cn.ConnectionString = Conexion.conexion;
                cn.Open();

                 sqltra = cn.BeginTransaction();
                transaccion = "cerrartransaccion";

            }
            
            string respuesta = "";
            try
            {

                
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE_CTACTE",sqltra);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, modoctacte);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int,cliente.idcliente);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdCliente);

                SqlParameter parcodventa = ProcAlmacenado.asignarParametros("@codventa", SqlDbType.Int, cliente.Codventa);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parcodventa);

                SqlParameter parestado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.NVarChar, cliente.estado);
                comando.Parameters.Add(parestado);

                SqlParameter parsaldo = ProcAlmacenado.asignarParametros("@saldo", SqlDbType.Money, cliente.saldo);
                comando.Parameters.Add(parsaldo);

                SqlParameter partotal = ProcAlmacenado.asignarParametros("@total", SqlDbType.Money, cliente.total);
                comando.Parameters.Add(partotal);

                SqlParameter parpagado = ProcAlmacenado.asignarParametros("@pagado", SqlDbType.Money, cliente.pagado);
                comando.Parameters.Add(parpagado);
                                               
                

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";

                }
                else
                {

                    respuesta = "error";
                }

                if (respuesta.Equals("ok") && transaccion == "cerrartransaccion")
                {
                    if (transaccion == "cerrartransaccion")
                    {
                        sqltra.Commit();
                        cn.Close();
                    }
                    
                }
                else if (transaccion == "cerrartransaccion")
                {
                    sqltra.Rollback();
                    cn.Close();
                }
                
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                cn.Close();
            }
            finally
            {
                // && transaccion == "cerrartransaccion"
                if (cn.State == ConnectionState.Open && transaccion == "cerrartransaccion") cn.Close();
            }
            return respuesta;
        }
        public DataTable buscarporcodigoctacte (DatosCliente objcliente)
        {
            DataTable DtResultado = new DataTable("clientes_ctacte");
            SqlConnection cn = new SqlConnection(Conexion.conexion);

            try
            {
                cn.Open();

                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE_CTACTE");
                //Modo 4 Mostrar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "buscarporcodigo");
                sqlcmd.Parameters.Add(parModo);
                SqlParameter parcodcliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int, idcliente);
                sqlcmd.Parameters.Add(parcodcliente);
                SqlParameter parfechaD = ProcAlmacenado.asignarParametros("@fechaD", SqlDbType.NVarChar, fechaD);
                sqlcmd.Parameters.Add(parfechaD);
                SqlParameter parfechaH = ProcAlmacenado.asignarParametros("@FechaH", SqlDbType.NVarChar, fechaH);
                sqlcmd.Parameters.Add(parfechaH);
                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                throw ex;
            }
            return DtResultado;

        }
        public string actualizacionesctacte(DataTable midata)
        {
            string respuesta = "";
            DatosCliente objcliente = new DatosCliente();
            cn = new SqlConnection(Conexion.conexion);

            cn.ConnectionString = Conexion.conexion;
            cn.Open();

            sqltra = cn.BeginTransaction();

            try
            {
                foreach (DataRow row in midata.Rows)
                {
                    objcliente.saldo = Convert.ToDecimal(row["saldo"].ToString());
                    objcliente.total = Convert.ToDecimal(row["total"].ToString());
                    objcliente.pagado = Convert.ToDecimal(row["pagado"].ToString());
                    objcliente.estado = row["saldo"].ToString();
                    objcliente.codventa = Convert.ToInt32(row["codventa"].ToString()) ;
                    agregaromodificarctacte(objcliente);
                }
                
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                cn.Close();
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
            return respuesta;

        }


    }
}
