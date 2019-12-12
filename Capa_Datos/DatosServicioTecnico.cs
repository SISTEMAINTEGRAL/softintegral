using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class DatosServicioTecnico
    {
        private int idserieyequipo;
        private int idordenservicio;

        public int Idordenservicio
        {
            get
            {
                return idordenservicio;
            }

            set
            {
                idordenservicio = value;
            }
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

        public string Idestado
        {
            get
            {
                return idestado;
            }

            set
            {
                idestado = value;
            }
        }

        public string Estadoequipo
        {
            get
            {
                return estadoequipo;
            }

            set
            {
                estadoequipo = value;
            }
        }

        public string Piezafaltante
        {
            get
            {
                return piezafaltante;
            }

            set
            {
                piezafaltante = value;
            }
        }

        public string Problema
        {
            get
            {
                return problema;
            }

            set
            {
                problema = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
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

        public int Idcomercio
        {
            get
            {
                return idcomercio;
            }

            set
            {
                idcomercio = value;
            }
        }

        public string Nrofactura
        {
            get
            {
                return nrofactura;
            }

            set
            {
                nrofactura = value;
            }
        }

        public int Tecnico
        {
            get
            {
                return tecnico;
            }

            set
            {
                tecnico = value;
            }
        }

        public int Iditem
        {
            get
            {
                return iditem;
            }

            set
            {
                iditem = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
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

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
            }
        }

        public int Idmarca
        {
            get
            {
                return idmarca;
            }

            set
            {
                idmarca = value;
            }
        }

        public int Idmodelo
        {
            get
            {
                return idmodelo;
            }

            set
            {
                idmodelo = value;
            }
        }

        public int Idcategoria
        {
            get
            {
                return idcategoria;
            }

            set
            {
                idcategoria = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public DateTime Fechad
        {
            get
            {
                return fechad;
            }

            set
            {
                fechad = value;
            }
        }

        public DateTime Fechah
        {
            get
            {
                return fechah;
            }

            set
            {
                fechah = value;
            }
        }

        public string Campo
        {
            get
            {
                return campo;
            }

            set
            {
                campo = value;
            }
        }

        public string Modo
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

        public string Descripcionequipo
        {
            get
            {
                return descripcionequipo;
            }

            set
            {
                descripcionequipo = value;
            }
        }

        public string Nombreequipo
        {
            get
            {
                return nombreequipo;
            }

            set
            {
                nombreequipo = value;
            }
        }

        public int Idserieyequipo
        {
            get
            {
                return idserieyequipo;
            }

            set
            {
                idserieyequipo = value;
            }
        }

        private DateTime fecha;

        private string idestado;

        private string estadoequipo;

        private string piezafaltante;

        private string problema;

        private string observacion;

        private int idcliente;

        private int idcomercio;

        private string nrofactura;

        private int tecnico;

        //detalle de orden de servicio

        private int iditem;
        private string descripcion;

        //detalle de orden de servicio de estado

        private string detalle;

        //equipo

        private int idequipo;
        private string serie;
        private int idmarca;
        private int idmodelo;
        private int idcategoria;
        private string nombreequipo;
        private string descripcionequipo;

        //marca

        private string marca;

        //modelo

        private string modelo;

        private DateTime fechad;
        private DateTime fechah;
        private string campo;
        private string modo;

        //Constructores
        public DatosServicioTecnico()
        { }
        public DatosServicioTecnico(int varidequipo, int varidmarca, int varidmodelo, int varidcategoria, string varnombreequipo, string vardescripcionequipo)
        {
            this.idequipo = varidequipo;
            
            this.idmarca = varidmarca;
            this.idmodelo = varidmodelo;
            this.idcategoria = varidcategoria;
            this.nombreequipo = varnombreequipo;
            this.descripcionequipo = vardescripcionequipo;
         }
        public DatosServicioTecnico(string varserie, int varidequipo, int varidmarca, int varidmodelo, int varidserieyequipo = 0)
        {
            this.serie = varserie;
            this.idequipo = varidequipo;
            this.idmarca = varidmarca;
            this.idmodelo = varidmodelo;
            this.idserieyequipo = varidserieyequipo;
        }
        public DatosServicioTecnico( string varequipo)
        {
            
            this.nombreequipo = varequipo;

        }
        public DatosServicioTecnico(int varidmarca, int varidequipo)
        {
            this.idmarca = varidmarca;
            this.idequipo = varidequipo;
          
        }
        public DatosServicioTecnico(string varmarca, string varmodelo, int varidmarca = 0,int varidequipo = 0)
        {
            this.marca = varmarca;
            this.modelo = varmodelo;
            this.idmarca = varidmarca;
            this.idequipo = varidequipo;
        }

        //metodos de equipo 
        // modo = agregarequipo, modo = modificarequipo, modo = agregarserieequipo
        public string agregareditarequipo(DatosServicioTecnico datosequipo, string modo)
        {
            string respuesta = "";
            
            
            
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            


            try
            {
                

                SqlParameter[] dbParams = new SqlParameter[]
                    {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,modo),
                        ProcAlmacenado2.MakeParam ("@idequipo",SqlDbType.Int,0,datosequipo.idequipo),
                        ProcAlmacenado2.MakeParam ("@idmarca",SqlDbType.Int,0,datosequipo.idmarca),
                        ProcAlmacenado2.MakeParam ("@idmodelo",SqlDbType.Int,0,datosequipo.idmodelo),
                        ProcAlmacenado2.MakeParam ("@serie",SqlDbType.NVarChar,300,datosequipo.serie),
                        ProcAlmacenado2.MakeParam ("@equipo",SqlDbType.NVarChar,300,datosequipo.nombreequipo),
                        ProcAlmacenado2.MakeParam ("@idordenservicio",SqlDbType.Int,0,datosequipo.idordenservicio),
                        ProcAlmacenado2.MakeParam ("@idserieyequipo",SqlDbType.Int,0,datosequipo.idserieyequipo)

                    };
                ProcAlmacenado2.ExecuteNonQuery("SP_ORDENSERVICIOS", dbParams);
            }
            catch (Exception)
            {

                throw;
            }

            return respuesta;
        }

        
        public DataTable Buscarequipo(DatosServicioTecnico datosequipo, bool pormarca = false, bool pormodelo = false , bool porequipo = false)
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            DataTable dtResult = new DataTable("datosequipo");

            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                   {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,"consultarequipoconcatenado"),
                        ProcAlmacenado2.MakeParam ("@idequipo",SqlDbType.NVarChar,300,datosequipo.idequipo),
                        ProcAlmacenado2.MakeParam ("@idmarca",SqlDbType.Int,0,datosequipo.idmarca),
                        ProcAlmacenado2.MakeParam ("@idmodelo",SqlDbType.Int,0,datosequipo.idmodelo),
                        ProcAlmacenado2.MakeParam ("@porequipo",SqlDbType.Bit,0,porequipo),
                        ProcAlmacenado2.MakeParam ("@pormarca",SqlDbType.Bit,0,pormarca),
                        ProcAlmacenado2.MakeParam ("@pormodelo",SqlDbType.Bit,0,pormodelo),
                        ProcAlmacenado2.MakeParam ("@serie",SqlDbType.NVarChar,300,serie),
                        ProcAlmacenado2.MakeParam ("@idordenservicio",SqlDbType.Int,0,datosequipo.idordenservicio)

                   };
               dtResult =  ProcAlmacenado2.ExecuteDatatable("SP_ORDENSERVICIOS", dbParams);
            }
            catch (Exception)
            {

                throw;

            }

            return dtResult;

        }

        public DataTable buscarmarca( DatosServicioTecnico serviciotecnico)
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            DataTable dtResult = new DataTable("datosmarca");
            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                   {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,"consultarmarca"),
                        ProcAlmacenado2.MakeParam ("@idordenservicio",SqlDbType.Int,0,idordenservicio)

                   };
                dtResult = ProcAlmacenado2.ExecuteDatatable("SP_ORDENSERVICIOS", dbParams);
            }
            catch (Exception)
            {

                throw;

            }
            return dtResult;
        }

        public DataTable buscarmodelo( DatosServicioTecnico serviciotecnico)
        {
            DataTable dtResult = new DataTable();
            
            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                  {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,"consultarmodelo"),
                        ProcAlmacenado2.MakeParam ("@idmarca",SqlDbType.Int,0,serviciotecnico.idmarca),
                        ProcAlmacenado2.MakeParam ("@idequipo",SqlDbType.Int,0,serviciotecnico.idequipo),
                        ProcAlmacenado2.MakeParam ("@idordenservicio",SqlDbType.Int,0,idordenservicio)

                  };
                dtResult = ProcAlmacenado2.ExecuteDatatable("SP_ORDENSERVICIOS", dbParams);
            }
            catch (Exception)
            {

                throw;
            }
            return dtResult;
        }
        public void agregarmarcaymodelo(DatosServicioTecnico serviciotecnico, string varmodo)
        {
            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                   {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,varmodo),
                        ProcAlmacenado2.MakeParam ("@idordenservicio",SqlDbType.Int,0,idordenservicio),
                        ProcAlmacenado2.MakeParam ("@marca",SqlDbType.NVarChar,300,serviciotecnico.marca),
                        ProcAlmacenado2.MakeParam ("@modelo",SqlDbType.NVarChar,300,serviciotecnico.modelo),
                        ProcAlmacenado2.MakeParam ("@idmarca",SqlDbType.Int,0,serviciotecnico.idmarca),
                        ProcAlmacenado2.MakeParam ("@idequipo",SqlDbType.Int,0,serviciotecnico.idequipo)

                   };
                 
                ProcAlmacenado2.ExecuteNonQuery("SP_ORDENSERVICIOS", dbParams);
            }
            catch (Exception)
            {

                throw;

            }
        }

        public void agregaryeditarserviciotecnico(DatosServicioTecnico servicio, string varmodo)
        {
            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                   {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,varmodo),
                        ProcAlmacenado2.MakeParam ("@idordenservicio",SqlDbType.Int,0,idordenservicio),
                        ProcAlmacenado2.MakeParam ("@marca",SqlDbType.NVarChar,300,servicio.marca),
                        ProcAlmacenado2.MakeParam ("@modelo",SqlDbType.NVarChar,300,servicio.modelo),
                        ProcAlmacenado2.MakeParam ("@idmarca",SqlDbType.Int,0,servicio.idmarca),
                        ProcAlmacenado2.MakeParam ("@idequipo",SqlDbType.Int,0,servicio.idequipo)

                   };

                ProcAlmacenado2.ExecuteNonQuery("SP_ORDENSERVICIOS", dbParams);
            }
            catch (Exception)
            {

                throw;

            }
        }

    }
}
