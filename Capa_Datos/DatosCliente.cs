﻿using System;
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
        private int codrecibo;
        private string codinterno;
        private bool concaja;
        private bool porcaja;
        private decimal limitectacte;
        private bool habilitarlimitectacte;
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

        public int IdProveedor
        {
            get
            {
                return idProveedor;
            }

            set
            {
                idProveedor = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }

            set
            {
                razonSocial = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public long Cuit
        {
            get
            {
                return cuit;
            }

            set
            {
                cuit = value;
            }
        }

        public long Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public long NumDocumento
        {
            get
            {
                return numDocumento;
            }

            set
            {
                numDocumento = value;
            }
        }

        public string Email
        {
            get
            {
                return Email1;
            }

            set
            {
                Email1 = value;
            }
        }

        public string Email1
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Responsableiva
        {
            get
            {
                return responsableiva;
            }

            set
            {
                responsableiva = value;
            }
        }

        public int Idprovincia
        {
            get
            {
                return idprovincia;
            }

            set
            {
                idprovincia = value;
            }
        }

        public int Idlocalidad
        {
            get
            {
                return idlocalidad;
            }

            set
            {
                idlocalidad = value;
            }
        }

        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public string Codinterno { get => codinterno; set => codinterno = value; }
        public bool Concaja { get => concaja; set => concaja = value; }
        public bool Porcaja { get => porcaja; set => porcaja = value; }
        public int Codrecibo { get => codrecibo; set => codrecibo = value; }
        public decimal Limitectacte { get => limitectacte; set => limitectacte = value; }
        public bool Habilitarlimitectacte { get => habilitarlimitectacte; set => habilitarlimitectacte = value; }

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
        public DatosCliente(int varcodcliente, string  varestado)
        {
            this.Idcliente = varcodcliente;
            this.estado = varestado;
        }
        public DatosCliente(ref SqlConnection miconexion, ref SqlTransaction mitransaccion,int varcodcliente, int varcodventa, decimal varsaldo, decimal vartotal, decimal varpagado, string varestado, string varmodoctacte)

        {
            this.cn = miconexion;
            this.sqltra = mitransaccion;
            this.Idcliente = varcodcliente;
            this.Codventa = varcodventa;
            this.saldo = varsaldo;
            this.total = vartotal;
            this.pagado = varpagado;
            this.estado = varestado;
            this.modoctacte = varmodoctacte;
        }
        public DatosCliente(string razonSocial,string direccion,long cuit,long tel,long numDocumento,string email, string responsableiva, int varidprovincia, int varidlocalidad, string varcodinterno, decimal varlimitectacte, bool varhabilitarctacte)
        {
            
           this.RazonSocial=razonSocial;
            this.Direccion=direccion;
            this.Cuit=cuit;
            this.Tel=tel;
            this.NumDocumento = numDocumento;
            this.Email=email;
            this.Responsableiva = responsableiva;
            this.Idprovincia = varidprovincia;
            this.Idlocalidad = varidlocalidad;
            this.codinterno = varcodinterno;
            this.limitectacte = varlimitectacte;
            this.habilitarlimitectacte = varhabilitarctacte;
         }

        public DatosCliente(int varidcliente)
        {
            Idcliente = varidcliente;
        
        }
        public DatosCliente(int idprovincia =0, int idlocalidad = 0 )
        {
            this.Idlocalidad = idlocalidad;
            this.Idprovincia = idprovincia;
        }
        public DatosCliente (int varcodcliente, int varcodventa, decimal varsaldo, decimal vartotal, decimal varpagado, string varestado, string varmodoctacte)
        {
            this.Idcliente = varcodcliente;
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

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, cliente.RazonSocial,150);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit= ProcAlmacenado.asignarParametros("@cuit", SqlDbType.BigInt, cliente.Cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parTel = ProcAlmacenado.asignarParametros("@telefono", SqlDbType.BigInt, cliente.Tel, 50);
                comando.Parameters.Add(parTel);

                SqlParameter parNumDocumento = ProcAlmacenado.asignarParametros("@num_documento", SqlDbType.BigInt, cliente.NumDocumento);
                comando.Parameters.Add(parNumDocumento);

                SqlParameter parEmail = ProcAlmacenado.asignarParametros("@email", SqlDbType.VarChar, cliente.Email, 50);
                comando.Parameters.Add(parEmail);
                
                SqlParameter parDireccion = ProcAlmacenado.asignarParametros("@direccion", SqlDbType.VarChar, cliente.Direccion, 50);
                comando.Parameters.Add(parDireccion);
                                
                SqlParameter parResponsableiva = ProcAlmacenado.asignarParametros("@responsableiva", SqlDbType.NVarChar, cliente.Responsableiva);
                comando.Parameters.Add(parResponsableiva);

                SqlParameter parIdprovincia = ProcAlmacenado.asignarParametros("@idprovincia", SqlDbType.Int, cliente.Idprovincia);
                comando.Parameters.Add(parIdprovincia);

                SqlParameter parIdlocalidad = ProcAlmacenado.asignarParametros("@idlocalidad", SqlDbType.Int, cliente.Idlocalidad);
                comando.Parameters.Add(parIdlocalidad);

                SqlParameter parCodinterno = ProcAlmacenado.asignarParametros("@codigointerno", SqlDbType.NVarChar, cliente.codinterno);
                comando.Parameters.Add(parCodinterno);

                SqlParameter parhabilitarctacte = ProcAlmacenado.asignarParametros("@habilitarctacte", SqlDbType.Bit, cliente.habilitarlimitectacte);
                comando.Parameters.Add(parhabilitarctacte);

                SqlParameter parlimitectacte = ProcAlmacenado.asignarParametros("@limitedectacte", SqlDbType.Decimal, cliente.limitectacte);
                comando.Parameters.Add(parlimitectacte);


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

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int,cliente.Idcliente);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdCliente);

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, cliente.RazonSocial, 150);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit = ProcAlmacenado.asignarParametros("@cuit", SqlDbType.BigInt, cliente.Cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parTel = ProcAlmacenado.asignarParametros("@telefono", SqlDbType.BigInt, cliente.Tel, 50);
                comando.Parameters.Add(parTel);

                SqlParameter parNumDocumento = ProcAlmacenado.asignarParametros("@num_documento", SqlDbType.BigInt, cliente.NumDocumento);
                comando.Parameters.Add(parNumDocumento);

                SqlParameter parEmail = ProcAlmacenado.asignarParametros("@email", SqlDbType.VarChar, cliente.Email, 50);
                comando.Parameters.Add(parEmail);

                SqlParameter parDireccion = ProcAlmacenado.asignarParametros("@direccion", SqlDbType.VarChar, cliente.Direccion, 50);
                comando.Parameters.Add(parDireccion);
                
                SqlParameter parResponsableiva = ProcAlmacenado.asignarParametros("@responsableiva", SqlDbType.NVarChar, cliente.Responsableiva );
                comando.Parameters.Add(parResponsableiva);

                SqlParameter parIdprovincia = ProcAlmacenado.asignarParametros("@idprovincia", SqlDbType.Int, cliente.Idprovincia);
                comando.Parameters.Add(parIdprovincia);
                
                SqlParameter parIdlocalidad = ProcAlmacenado.asignarParametros("@idlocalidad", SqlDbType.Int, cliente.Idlocalidad);
                comando.Parameters.Add(parIdlocalidad);

                SqlParameter parCodinterno = ProcAlmacenado.asignarParametros("@codigointerno", SqlDbType.NVarChar, cliente.codinterno);
                comando.Parameters.Add(parCodinterno);

                SqlParameter parlimitectacte = ProcAlmacenado.asignarParametros("@limitedectacte", SqlDbType.Decimal, cliente.limitectacte);
                comando.Parameters.Add(parlimitectacte);

                SqlParameter parhabilitarctacte = ProcAlmacenado.asignarParametros("@habilitarctacte", SqlDbType.Bit, cliente.habilitarlimitectacte);
                comando.Parameters.Add(parhabilitarctacte);
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
           
                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int, cliente.IdProveedor);
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
        public DataTable buscarTexto(DatosCliente cliente, int modo = 4)
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
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, modo);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, cliente.Idcliente);
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

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, cliente.Idcliente);
                comando.Parameters.Add(parIdCliente);
                if (modo == 11)
                {
                    SqlParameter parCodigointerno = ProcAlmacenado.asignarParametros("@codigointerno", SqlDbType.NVarChar, cliente.buscarCliente);
                    comando.Parameters.Add(parCodigointerno);
                }
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
                     ProcAlmacenado2.MakeParam("@idprovincia", SqlDbType.Int, 0,Idprovincia)
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
        public string agregaromodificarctacte(DatosCliente cliente, string varmodo = "modificarctacte")
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

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, varmodo);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int,cliente.Idcliente);
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

        public string guardardetallerecibo(DatosCliente cliente, int codrecibo = 0)
        {
            string transaccion = "";
            string respuesta = "";
            //modo 1 para DB
            if (cn.State == ConnectionState.Closed)
            {
                cn = new SqlConnection(Conexion.conexion);

                cn.ConnectionString = Conexion.conexion;
                cn.Open();

                sqltra = cn.BeginTransaction();
                transaccion = "cerrartransaccion";

            }
            try
            {

     //           @codrecibo,
		   //@Codcliente,
		   //@codventa
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE_CTACTE", sqltra);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "grabarrecibodetalle");
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int,cliente.Idcliente);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdCliente);

                SqlParameter parcodventa = ProcAlmacenado.asignarParametros("@codventa", SqlDbType.Int, cliente.Codventa);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parcodventa);

                SqlParameter parcodrecibo = ProcAlmacenado.asignarParametros("@codrecibo", SqlDbType.Int, codrecibo);
                comando.Parameters.Add(parcodrecibo);

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

               
                return respuesta;
            }
            catch (Exception ex)
            {
                throw;
            }
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
                SqlParameter parcodcliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int, Idcliente);
                sqlcmd.Parameters.Add(parcodcliente);
                SqlParameter parestadocliente = ProcAlmacenado.asignarParametros("@estado", SqlDbType.NVarChar, estado);
                sqlcmd.Parameters.Add(parestadocliente);
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
        public string agregarrecibo( ref int varcodrecibo,DatosCliente objcliente,DataTable midata, decimal totalpagado = 0, bool concaja = false,int idusuario = 0  )
        {
            string respuesta = "";
            
            cn = new SqlConnection(Conexion.conexion);

            cn.ConnectionString = Conexion.conexion;
            cn.Open();

            sqltra = cn.BeginTransaction();
            

            try
            {
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE_CTACTE", sqltra);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "grabarrecibocabecera");
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int, objcliente.Idcliente);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdCliente);

                SqlParameter parpagado = ProcAlmacenado.asignarParametros("@pagado", SqlDbType.Int, totalpagado);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parpagado);

                SqlParameter parconcaja = ProcAlmacenado.asignarParametros("@concaja", SqlDbType.NVarChar, concaja);
                comando.Parameters.Add(parconcaja);

                SqlParameter parcodrecibo= ProcAlmacenado.asignarParametros("@codreciboinsert", SqlDbType.Int);
                comando.Parameters.Add(parcodrecibo);

                SqlParameter paridusuario = ProcAlmacenado.asignarParametros("@idusuario", SqlDbType.Int,idusuario);
                comando.Parameters.Add(paridusuario);

                SqlParameter parfecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime, DateTime.Now);
                comando.Parameters.Add(parfecha);


                if (comando.ExecuteNonQuery() == 1)


                {
                    varcodrecibo = Convert.ToInt32(comando.Parameters["@codreciboinsert"].Value);
                    foreach (DataRow row in midata.Rows)
                    {
                        if (row["grabar"].ToString() == "grabar")
                        {
                            objcliente.saldo = Convert.ToDecimal(row["saldo"].ToString());
                            objcliente.total = Convert.ToDecimal(row["total"].ToString());
                            objcliente.pagado = Convert.ToDecimal(row["pagado"].ToString());
                            objcliente.estado = row["estado"].ToString();
                            objcliente.codventa = Convert.ToInt32(row["idventa"].ToString());

                            guardardetallerecibo(objcliente,varcodrecibo);
                            agregaromodificarctacte(objcliente);
                        }

                    }
                    respuesta = "ok";


                    sqltra.Commit();

                }
                else
                {

                    respuesta = "error";
                }
                //guardarcabecerarecibo(midata);
               
                
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                sqltra.Rollback();
                cn.Close();
            }
            finally
            {

                if (cn.State == ConnectionState.Open) cn.Close();
            }
            return respuesta;

        }

        public DataTable reporterecibo(int codrecibo)
        {
            DataTable DtResultado = new DataTable("clientes_ctacte");
            SqlConnection cn = new SqlConnection(Conexion.conexion);

            try
            {
                cn.Open();

                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(cn, "REPORTE_RECIBO");
                //Modo 4 Mostrar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@codrecibo", SqlDbType.Int, codrecibo);
                sqlcmd.Parameters.Add(parModo);
                
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
        public string modificarcajarecibo(int codrecibo = 0, string transaccion = "")
        {
            
            string respuesta = "";
            //modo 1 para DB
            if (transaccion != "")
            {
                cn = new SqlConnection(Conexion.conexion);

                cn.ConnectionString = Conexion.conexion;
                cn.Open();

                sqltra = cn.BeginTransaction();
                transaccion = "cerrartransaccion";

            }
            try
            {

                //           @codrecibo,
                //@Codcliente,
                //@codventa
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE_CTACTE", sqltra);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "actualizarcaja");
                comando.Parameters.Add(parModo);

                SqlParameter parcodrecibo = ProcAlmacenado.asignarParametros("@codrecibo", SqlDbType.Int, codrecibo);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parcodrecibo);



               

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


                return respuesta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
         
        public DataTable BuscarFechasRecibo(string TextoBuscar, string TextoBuscar2, DatosCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection sqlcon = new SqlConnection(Conexion.conexion);
            try
            {


                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_CLIENTE_CTACTE");

                //modo 2 para la busqueda
                sqlcmd.Parameters.AddWithValue("@modo", "buscarrecibo");
                sqlcmd.Parameters.AddWithValue("@fechad", TextoBuscar);
                sqlcmd.Parameters.AddWithValue("@fechah", TextoBuscar2);
                
                sqlcmd.Parameters.AddWithValue("@concaja", Cliente.Concaja);
                sqlcmd.Parameters.AddWithValue("@codcliente", Cliente.idcliente);
                sqlcmd.Parameters.AddWithValue("@codrecibo", Cliente.codrecibo);
                sqlcmd.Parameters.AddWithValue("@porcaja", Cliente.porcaja);

                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                sqlcon.Close();
                //lanzo una excepcion en el caso de problemas con bd
                throw ex;
            }

            return DtResultado;
        }

       

    }
}
