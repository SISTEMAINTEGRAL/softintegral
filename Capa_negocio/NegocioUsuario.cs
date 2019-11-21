using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_negocio
{
    public class NegocioUsuario
    {
        private bool usuariosa;

        public bool Usuariosa
        {
            get { return usuariosa; }
            set { usuariosa = value; }
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

        private string nombreusuario;

        public string Nombreusuario
        {
            get { return nombreusuario; }
            set { nombreusuario = value; }
        }

        private string reglaprivilegio;

        public string Reglaprivilegio
        {
            get { return reglaprivilegio; }
            set { reglaprivilegio = value; }
        }

        public static DataTable mostrarusuario(string buscarnombre)
        {
            
                return new DatosUsuario().mostrarusuario(buscarnombre);
        
        }

        public bool login(string usuario, string clave)
        {
            DatosUsuario objusuario = new DatosUsuario();
            bool log =objusuario.login(usuario, clave);
            idusuario = objusuario.Idusuario;
            this.usuario = objusuario.Usuario;
            this.nombreusuario = objusuario.Nombre;
            this.usuariosa = objusuario.Usuariosa;
            this.reglaprivilegio = objusuario.Reglaprivilegio;
            
            return log;

        }

        public string agregarusuario(string usuario, string nombre, string clave, string turno, bool activo, bool sadmin,int idusuario)
        {
            
            DatosUsuario objusuario = new DatosUsuario(usuario, nombre, clave, turno, activo, idusuario, sadmin);
            
            return objusuario.agregarusuario(objusuario); 



        }

        public string actualizarusuario(string usuario, string nombre, string clave, string turno, bool activo, bool sadmin, int idusuario)
        {
            DatosUsuario objusuario = new DatosUsuario(usuario, nombre, clave, turno, activo, idusuario, sadmin);

            return objusuario.actualizarusuario(objusuario); 
        
        }

        public DataTable mostrartabla(string tabla)
        {

            DatosUsuario objusuario = new DatosUsuario();
            return objusuario.mostrartabla(tabla);
        
        }

        public DataTable mostrarprivilegio(int idroles, int codproceso)
        {
            
            DatosUsuario objusuario = new DatosUsuario();
            return objusuario.mostrarprivilegios (idroles,codproceso);
        
        }
        public string actualizarprivilegio (int idroles, int codmodulo, DataTable dt)
        {
            
            DatosUsuario objusuario = new DatosUsuario(); 
            string msg = "";
            List<DatosUsuario> detalles = new List<DatosUsuario>();

            foreach (DataRow row in dt.Rows)
            {
                objusuario =  new DatosUsuario();
                objusuario.Idroles = idroles;
                objusuario.Codmodulo = codmodulo;
                objusuario.Codigo = Convert.ToInt32(row["codigo"].ToString());
                objusuario.Descripcion = row["descripcion"].ToString();
                objusuario.Observacion  = row["observacion"].ToString();
                objusuario.Estado = Convert.ToBoolean(row["estado"].ToString());
                objusuario.Codsubproceso = Convert.ToInt32(row["codsubproceso"].ToString());
                objusuario.Codproceso = Convert.ToInt32(row["codproceso"].ToString());
                //agrego el item a la lista detalles
                detalles.Add(objusuario);
            
            }
            msg = objusuario.actualizarprivilegios(objusuario, detalles);
            return  msg ;
        
        }
        // VERIFICA EL PRIVILEGIO DE USUARIO EN UN STRING TRAIDO DEL PROCEDIMIENTO USUARIO
        public  bool TieneRegla(string reglas_a_verificar)
        {
            string[] aReglas_a_Verificar = reglas_a_verificar.Split(',');
            foreach (var s in aReglas_a_Verificar)
            {
                if (s != "" && NegocioConfigEmpresa.ReglasUsuario.Contains(s))
                {
                    return true;
                }
            }
            return false;

        }

    }
}
