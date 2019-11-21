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

        public int Idlocalidad
        {
            get { return idlocalidad; }
            set { idlocalidad = value; }
        }

        public int Idprovincia
        {
            get { return idprovincia; }
            set { idprovincia = value; }
        }

        public string Responsableiva
        {
            get { return responsableiva; }
            set { responsableiva = value; }
        }
       
      
        //constructores
        public DatosCliente() { 
        
        }
        public DatosCliente(string razonSocial,string direccion,int cuit,int tel,int numDocumento,string email, string responsableiva, int varidprovincia, int varidlocalidad)
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

        public DatosCliente(int varidprovincia)
        {
            idprovincia = varidprovincia;
        
        }
        
        //crud
        public string agregar(DatosCliente cliente)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
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

                SqlParameter parFechaNacimiento = ProcAlmacenado.asignarParametros("@fecha_nacimiento", SqlDbType.Date, cliente.FechaNacimiento);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CLIENTE");



                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                comando.Parameters.Add(parModo);

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int,cliente.IdCliente);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_PROVEEDOR");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                comando.Parameters.Add(parModo);
           
                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int, cliente.IdCliente);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
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

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, cliente.IdCliente);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
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

                SqlParameter parIdCliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, cliente.IdCliente);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
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
            SqlConnection cn = new SqlConnection(Conexion.conexion);
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
    
        //Getters and setters
        public int IdCliente
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public long Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public long Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public long NumDocumento
        {
            get { return numDocumento; }
            set { numDocumento = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string BuscarCliente
        {
            get { return buscarCliente; }
            set { buscarCliente = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
       
    }
}
