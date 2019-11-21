using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DatosUsuario
    {
        private string reglaprivilegio;

        public string Reglaprivilegio
        {
            get { return reglaprivilegio; }
            set { reglaprivilegio = value; }
        }
        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string turno;

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        private bool sadmin;

        public bool Sadmin
        {
            get { return sadmin; }
            set { sadmin = value; }
        }

        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private bool usuariosa;

        public bool Usuariosa
        {
            get { return usuariosa; }
            set { usuariosa = value; }
        }


        //propiedades de privilegios

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private int idroles;

        public int Idroles
        {
            get { return idroles; }
            set { idroles = value; }
        }
        private int codproceso;

        public int Codproceso
        {
            get { return codproceso; }
            set { codproceso = value; }
        }

        private int codmodulo;

        public int Codmodulo
        {
            get { return codmodulo; }
            set { codmodulo = value; }
        }

        private int codsubproceso;

        public int Codsubproceso
        {
            get { return codsubproceso; }
            set { codsubproceso = value; }
        }
        //constructor

        public DatosUsuario()
        { }

        public DatosUsuario(string usuario, string nombre, string clave, string turno, bool activo, int idusuario, bool sa)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.clave = clave;
            this.turno = turno;
            this.sadmin = sa;
            this.activo = activo;
            this.idusuario = idusuario;
        }

        public DataTable mostrarusuario(string buscarnombre)
        {

            string rpta = "";
            string maquina = System.Environment.MachineName;

            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("cuentas");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_USUARIO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                comando.Parameters.Add(parModo);

                SqlParameter parBnombre = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.NVarChar, buscarnombre);
                comando.Parameters.Add(parBnombre);

                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                rpta = ex.Message;
                //throw ex;
            }
            return dtResult;
        }

        public bool login(string usuario, string clave)
        {
            bool login = true;

            try
            {
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_USUARIO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 8);
                comando.Parameters.Add(parModo);

                SqlParameter parUsuario = ProcAlmacenado.asignarParametros("@usuario", SqlDbType.VarChar, usuario);
                comando.Parameters.Add(parUsuario);

                SqlParameter parClave = ProcAlmacenado.asignarParametros("@clave", SqlDbType.NVarChar, clave);
                comando.Parameters.Add(parClave);

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    this.idusuario = Convert.ToInt32(dr["idusuario"]);
                    this.usuario = Convert.ToString(dr["usuario"]);
                    this.nombre = Convert.ToString(dr["nombre"]);
                    this.usuariosa = Convert.ToBoolean(dr["SA"]);
                    this.reglaprivilegio = Convert.ToString(dr["reglas"]);
                    login = true;

                }
                else
                {
                    login = false;
                }
            }
            catch (Exception ex)
            {

                string msg = ex.Message;

            }



            return login;


        }

        public string agregarusuario(DatosUsuario usuario)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_USUARIO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 9);
                comando.Parameters.Add(parModo);

                SqlParameter parUsuario = ProcAlmacenado.asignarParametros("@usuario", SqlDbType.NVarChar, usuario.usuario);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parUsuario);

                SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.NVarChar, usuario.Nombre, 50);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parNombre);

                SqlParameter parClave = ProcAlmacenado.asignarParametros("@clave", SqlDbType.NVarChar, usuario.clave, 50);
                comando.Parameters.Add(parClave);

                SqlParameter parTurno = ProcAlmacenado.asignarParametros("@turno", SqlDbType.NVarChar, usuario.turno, 50);
                comando.Parameters.Add(parTurno);

                SqlParameter parActivo = ProcAlmacenado.asignarParametros("@activo", SqlDbType.Bit, usuario.sadmin);
                comando.Parameters.Add(parActivo);

                SqlParameter parSadmin = ProcAlmacenado.asignarParametros("@sa", SqlDbType.Int, usuario.sadmin);
                comando.Parameters.Add(parSadmin);

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

        public string actualizarusuario(DatosUsuario usuario)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_USUARIO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 10);
                comando.Parameters.Add(parModo);

                SqlParameter parUsuario = ProcAlmacenado.asignarParametros("@usuario", SqlDbType.NVarChar, usuario.usuario);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parUsuario);

                SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.NVarChar, usuario.Nombre, 50);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parNombre);

                SqlParameter parClave = ProcAlmacenado.asignarParametros("@clave", SqlDbType.NVarChar, usuario.clave, 50);
                comando.Parameters.Add(parClave);

                SqlParameter parTurno = ProcAlmacenado.asignarParametros("@turno", SqlDbType.NVarChar, usuario.turno, 50);
                comando.Parameters.Add(parTurno);

                SqlParameter parActivo = ProcAlmacenado.asignarParametros("@activo", SqlDbType.Bit, usuario.activo);
                comando.Parameters.Add(parActivo);

                SqlParameter parIdusuario = ProcAlmacenado.asignarParametros("@idusuario", SqlDbType.Int, usuario.idusuario);
                comando.Parameters.Add(parIdusuario);

                SqlParameter parSadmin = ProcAlmacenado.asignarParametros("@sa", SqlDbType.Int, usuario.sadmin);
                comando.Parameters.Add(parSadmin);




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

        public DataTable mostrartabla(string tabla)
        {
            DataTable datotabla = new DataTable(tabla);
            try
            {
                string query = "";
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();

                if (tabla == "roles")
                {
                    query = "select codroles, roles from roles where codroles != 0";
                }

                if (tabla == "procesos")
                {
                    query = "select codigo,proceso  from procesos";
                }

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter trolesadapter = new SqlDataAdapter(cmd);
                trolesadapter.Fill(datotabla);

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return datotabla;
        }

        public DataTable mostrarprivilegios(int idroles, int codproceso)
        {
            //modo 1 para DB
            DataTable midatatable = new DataTable();
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_USUARIO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 11);
                comando.Parameters.Add(parModo);

                SqlParameter parRoles = ProcAlmacenado.asignarParametros("@idroles", SqlDbType.Int, idroles);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRoles);

                SqlParameter parproceso = ProcAlmacenado.asignarParametros("@codproceso", SqlDbType.Int, codproceso);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parproceso);


                SqlDataAdapter trolesadapter = new SqlDataAdapter(comando);
                trolesadapter.Fill(midatatable);





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
                respuesta = ex.Message;
            }
            return midatatable;

        }

        public DataTable gestionprivilegio(int idroles, int codproceso)
        {
            //modo 1 para DB
            DataTable midatatable = new DataTable();
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_USUARIO");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 11);
                comando.Parameters.Add(parModo);

                SqlParameter parRoles = ProcAlmacenado.asignarParametros("@idroles", SqlDbType.Int, idroles);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parRoles);

                SqlParameter parproceso = ProcAlmacenado.asignarParametros("@codproceso", SqlDbType.Int, codproceso);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parproceso);


                SqlDataAdapter trolesadapter = new SqlDataAdapter(comando);
                trolesadapter.Fill(midatatable);





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
                respuesta = ex.Message;
            }
            return midatatable;

        }

        public string actualizarprivilegios(DatosUsuario objusuario,  List<DatosUsuario> Detalle)
        {
            string msg = "OK";
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = Conexion.conexion;
            sqlcon.Open();
            SqlTransaction sqltra = sqlcon.BeginTransaction();
            
            try
            {
                
               
                // primero eliminar privilegio y codigo de procesos para luego agregarlos nuevamente
                 
                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_USUARIO", sqltra);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int,12);
                sqlcmd.Parameters.Add(parModo);

                SqlParameter parCodproceso = ProcAlmacenado.asignarParametros("@codproceso", SqlDbType.Int, objusuario.codmodulo);
                sqlcmd.Parameters.Add(parCodproceso);

                
                SqlParameter parRoles = ProcAlmacenado.asignarParametros("@idroles", SqlDbType.Int, objusuario.idroles);
                sqlcmd.Parameters.Add(parRoles);

                msg = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ingreso el registro";

                foreach (DatosUsuario det in Detalle)
                {
                    SqlCommand sqlcmd2 = ProcAlmacenado.CrearProc(sqlcon, "SP_USUARIO", sqltra);

                    SqlParameter parModo2 = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 13);
                    sqlcmd2.Parameters.Add(parModo2);

                    SqlParameter parCodigo = ProcAlmacenado.asignarParametros("@codSP", SqlDbType.Int, det.codigo);
                    sqlcmd2.Parameters.Add(parCodigo);
                   
                    SqlParameter parIdroles = ProcAlmacenado.asignarParametros("@idroles", SqlDbType.Int, objusuario.idroles);
                    sqlcmd2.Parameters.Add(parIdroles);
                   
                    SqlParameter parEstado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.Bit, det.estado);
                    sqlcmd2.Parameters.Add(parEstado);

                    SqlParameter parCodsubproceso = ProcAlmacenado.asignarParametros("@codsubproceso", SqlDbType.Int, det.codsubproceso);
                    sqlcmd2.Parameters.Add(parCodsubproceso);

                    
                    SqlParameter parCodproceso2 = ProcAlmacenado.asignarParametros("@codproceso", SqlDbType.Int, det.codproceso);
                    sqlcmd2.Parameters.Add(parCodproceso2);

                    msg = sqlcmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se ingreso el registro";
                    
                    
                }
                

            }
                catch (Exception ex)
            {
                msg = ex.Message;
            }

            if (msg.Equals("OK"))
            {
                sqltra.Commit();
                
            }
            else
            {
                sqltra.Rollback();
            }
            sqlcon.Close();
            return msg;

        
        }
    }
}
