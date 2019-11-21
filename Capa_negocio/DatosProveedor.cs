using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class DatosProveedor
    {
        //campos
        private int idProveedor;
        private string razonSocial;
        private string direccion;
        private int cuit;
        private int tel;
        private int numDocumento;
        private string email;
        private string buscarProveedor;

       
      
        //constructores
        public DatosProveedor() { 
        
        }
        public DatosProveedor(string razonSocial,string direccion,int cuit,int tel,int numDocumento,string email)
        {
           this.razonSocial=razonSocial;
            this.direccion=direccion;
            this.cuit=cuit;
            this.tel=tel;
            this.numDocumento = numDocumento;
            this.email=email;
         }
        
        //crud
        public string agregar(DatosProveedor proveedor)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_PROVEEDOR");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                comando.Parameters.Add(parModo);

                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdProveedor);

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, proveedor.RazonSocial,150);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit= ProcAlmacenado.asignarParametros("@cuit", SqlDbType.Int , proveedor.Cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parTel = ProcAlmacenado.asignarParametros("@telefono", SqlDbType.Int, proveedor.Tel, 50);
                comando.Parameters.Add(parTel);

                SqlParameter parNumDocumento = ProcAlmacenado.asignarParametros("@num_documento", SqlDbType.Int, proveedor.NumDocumento);
                comando.Parameters.Add(parCuit);

                SqlParameter parEmail = ProcAlmacenado.asignarParametros("@email", SqlDbType.VarChar, proveedor.Email, 50);
                comando.Parameters.Add(parEmail);
                
                SqlParameter parDireccion = ProcAlmacenado.asignarParametros("@direccion", SqlDbType.VarChar, proveedor.Direccion, 50);
                comando.Parameters.Add(parEmail);
                

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
        public string editar(DatosProveedor proveedor)
        {
            //modo 2 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_PROVEEDOR");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                comando.Parameters.Add(parModo);

                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int,proveedor.IdProveedor);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdProveedor);

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, proveedor.RazonSocial, 150);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit = ProcAlmacenado.asignarParametros("@cuit", SqlDbType.Int, proveedor.Cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parTel = ProcAlmacenado.asignarParametros("@telefono", SqlDbType.Int, proveedor.Tel, 50);
                comando.Parameters.Add(parTel);

                SqlParameter parNumDocumento = ProcAlmacenado.asignarParametros("@num_documento", SqlDbType.Int, proveedor.NumDocumento);
                comando.Parameters.Add(parCuit);

                SqlParameter parEmail = ProcAlmacenado.asignarParametros("@email", SqlDbType.VarChar, proveedor.Email, 50);
                comando.Parameters.Add(parEmail);

                SqlParameter parDireccion = ProcAlmacenado.asignarParametros("@direccion", SqlDbType.VarChar, proveedor.Direccion, 50);
                comando.Parameters.Add(parEmail);

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
        public string eliminar(DatosProveedor proveedor)
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
           
                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int, proveedor.IdProveedor);
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
        public DataTable buscarTexto(DatosProveedor proveedor)
        {
            //Modo 4 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("proveedor");
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_PROVEEDOR");

                SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.VarChar,proveedor.buscarProveedor, 50);
                //le paso al comando el parametro
                comando.Parameters.Add(parBuscarTexto);
                //modo buscar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                comando.Parameters.Add(parModo);

                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int, proveedor.IdProveedor);
                comando.Parameters.Add(parIdProveedor);
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
            DataTable dtResult = new DataTable("proveedor");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_PROVEEDOR");
                

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 5);
                comando.Parameters.Add(parModo);
                //Asigno al parametro @idcategoria, aunque no lo use
                SqlParameter parIdProveedor = ProcAlmacenado.asignarParametros("@idproveedor", SqlDbType.Int);
                comando.Parameters.Add(parIdProveedor);

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
    
    
        //Getters and setters
        public int IdProveedor
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
        public int Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public int NumDocumento
        {
            get { return numDocumento; }
            set { numDocumento = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string BuscarProveedor
        {
            get { return buscarProveedor; }
            set { buscarProveedor = value; }
        }

    }
}
