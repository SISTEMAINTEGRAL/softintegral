using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosConfigEmpresa
    {
        private string sign;
        private string token;

        private string BalanzaPuerto;
        private string puntoventa;
        private string condicionFrenteIVA;
        private string razonSocial;
        private long cuit;
        private Byte[] logo;
        private int cod_empresa = 1;
        private string FormatoImpFactElectronica;
        private string formatoimpproforma;
        private string formatoimpremito;
        private string certificado;
        private string[] ReglasUsuario { get; set; }
        //Equipo

        private int idequipo;

        public int Idequipo
        {
            get { return idequipo; }
            set { idequipo = value; }
        }
        private string equipo;

        public string Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string turno;

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        private int codsucursal;

        public int Codsucursal
        {
            get { return codsucursal; }
            set { codsucursal = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string ruta;

        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }
        private string ip;

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        private int puertofiscal;

        public int Puertofiscal
        {
            get { return puertofiscal; }
            set { puertofiscal = value; }
        }
        private int modelofiscal;

        public int Modelofiscal
        {
            get { return modelofiscal; }
            set { modelofiscal = value; }
        }
        private int idempresa;

        public int Idempresa
        {
            get { return idempresa; }
            set { idempresa = value; }
        }
        private string marcafiscal;

        public string Marcafiscal
        {
            get { return marcafiscal; }
            set { marcafiscal = value; }
        }

        private string impticket;

        public string Impticket
        {
            get { return impticket; }
            set { impticket = value; }
        }

        private string impreporte;

        public string Impreporte
        {
            get { return impreporte; }
            set { impreporte = value; }
        }

        //getters and setters
        public int Cod_empresa
        {
            get { return cod_empresa; }
            set { cod_empresa = value; }
        }
        public string CondicionFrenteIVA
        {
            get { return condicionFrenteIVA; }
            set { condicionFrenteIVA = value; }
        }
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        public Byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }
        public Int64 Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public string Puntoventa
        {
            get
            {
                return puntoventa;
            }

            set
            {
                puntoventa = value;
            }
        }

        public string Sign
        {
            get
            {
                return sign;
            }

            set
            {
                sign = value;
            }
        }

        public string Token
        {
            get
            {
                return token;
            }

            set
            {
                token = value;
            }
        }

        public string BalanzaPuerto1
        {
            get
            {
                return BalanzaPuerto;
            }

            set
            {
                BalanzaPuerto = value;
            }
        }

        public string FormatoImpFactElectronica1
        {
            get
            {
                return FormatoImpFactElectronica;
            }

            set
            {
                FormatoImpFactElectronica = value;
            }
        }

        public string Formatoimpproforma
        {
            get
            {
                return formatoimpproforma;
            }

            set
            {
                formatoimpproforma = value;
            }
        }

        public string Formatoimpremito
        {
            get
            {
                return formatoimpremito;
            }

            set
            {
                formatoimpremito = value;
            }
        }

        public string Certificado
        {
            get
            {
                return certificado;
            }

            set
            {
                certificado = value;
            }
        }

        public DataTable mostrar()
        {

            //Modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("config_empresa");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CONFIG_EMPRESA");
                //Modo 1 MOSTRAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                comando.Parameters.Add(parModo);
                SqlParameter parCodEmpresa = ProcAlmacenado.asignarParametros("@cod_empresa", SqlDbType.Int);
                comando.Parameters.Add(parCodEmpresa);

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

        public bool verificartiketfiscal()
        {
            bool chequear = true;
            //Modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);

            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_TA");
                //Modo 1 MOSTRAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "VERIFICARTICKET");
                comando.Parameters.Add(parModo);


                //creo el objeto adapter del data provider le paso el sqlcommand
                //  SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read() == true)
                {

                    this.sign = Convert.ToString(dr["signn"]);
                    this.token = Convert.ToString(dr["token"]);
                    this.fecha = Convert.ToDateTime(dr["expiration_time"]);


                }
                else
                {
                    chequear = false;
                }




            }
            catch (Exception ex)
            {

                throw ex;
            }
            return chequear;
        }
        public string agregarticket(DatosConfigEmpresa configEmpresa)
        {
            string respuesta = "";
            //Modo 3 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("TA");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_TA");
                //Modo 3 agregar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "INSERTARTICKET");
                comando.Parameters.Add(parModo);

                SqlParameter parSign = ProcAlmacenado.asignarParametros("@sign", SqlDbType.NVarChar, configEmpresa.Sign);
                comando.Parameters.Add(parSign);

                SqlParameter parToken = ProcAlmacenado.asignarParametros("@token", SqlDbType.NVarChar, configEmpresa.Token);
                comando.Parameters.Add(parToken);

                SqlParameter parFecha = ProcAlmacenado.asignarParametros("@espirationtime", SqlDbType.DateTime, configEmpresa.fecha);
                comando.Parameters.Add(parFecha);


                if (comando.ExecuteNonQuery() >= 1)
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
                throw ex;

            }
            return respuesta;
        }

        public string agregarEmpresa(DatosConfigEmpresa configEmpresa)
        {
            string respuesta = "";
            //Modo 3 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("config_empresa");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CONFIG_EMPRESA");
                //Modo 3 agregar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                comando.Parameters.Add(parModo);

                SqlParameter parCodEmpresa = ProcAlmacenado.asignarParametros("@cod_empresa", SqlDbType.Int);
                comando.Parameters.Add(parCodEmpresa);

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, configEmpresa.RazonSocial);
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit = ProcAlmacenado.asignarParametros("@cuit", SqlDbType.BigInt, configEmpresa.Cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parCondicion = ProcAlmacenado.asignarParametros("@condicion_frente_iva", SqlDbType.VarChar, configEmpresa.CondicionFrenteIVA);
                comando.Parameters.Add(parCondicion);

                SqlParameter parLogo = ProcAlmacenado.asignarParametros("@logo", SqlDbType.Image, configEmpresa.Logo);
                comando.Parameters.Add(parLogo);


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
                throw ex;

            }
            return respuesta;
        }


        public string ModificarEmpresa(DatosConfigEmpresa configEmpresa)
        {
            string respuesta = "";
            //Modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("config_empresa");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CONFIG_EMPRESA");
                //Modo 2 modificar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                comando.Parameters.Add(parModo);

                SqlParameter parCodEmpresa = ProcAlmacenado.asignarParametros("@cod_empresa", SqlDbType.Int);
                comando.Parameters.Add(parCodEmpresa);

                SqlParameter parRazonSocial = ProcAlmacenado.asignarParametros("@razon_social", SqlDbType.VarChar, configEmpresa.RazonSocial);
                comando.Parameters.Add(parRazonSocial);

                SqlParameter parCuit = ProcAlmacenado.asignarParametros("@cuit", SqlDbType.Int, configEmpresa.Cuit);
                comando.Parameters.Add(parCuit);

                SqlParameter parCondicion = ProcAlmacenado.asignarParametros("@condicion_frente_iva", SqlDbType.VarChar, configEmpresa.CondicionFrenteIVA);
                comando.Parameters.Add(parCondicion);

                SqlParameter parLogo = ProcAlmacenado.asignarParametros("@logo", SqlDbType.Image, configEmpresa.Logo);
                comando.Parameters.Add(parLogo);
                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);


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
                dtResult = null;
                throw ex;
            }
            return respuesta;
        }

        public string confequipo(DatosConfigEmpresa configequipo)
        {
            string respuesta = "";
            //Modo 3 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("Confequipo");
            try
            {
                //probar mas adelante 
                SqlParameter[] dbParams = new SqlParameter[]
                 {
                     ProcAlmacenado2.MakeParam("@modo", SqlDbType.Int, 0, 4),
                     ProcAlmacenado2.MakeParam("@equipo", SqlDbType.NVarChar,0,configequipo.equipo),
                     ProcAlmacenado2.MakeParam("@usuarioconectado", SqlDbType.NVarChar,0, configequipo.usuario),
                     ProcAlmacenado2.MakeParam("@turno", SqlDbType.NVarChar, 0, configequipo.turno),
                     ProcAlmacenado2.MakeParam("@idusuario", SqlDbType.Int, 0, configequipo.idusuario),
                      ProcAlmacenado2.MakeParam("@cod_sucursal", SqlDbType.Int, 0, configequipo.codsucursal),
                       ProcAlmacenado2.MakeParam("@fecha", SqlDbType.DateTime, 0, configequipo.fecha),
                       ProcAlmacenado2.MakeParam("@ruta", SqlDbType.NVarChar, 0, configequipo.ruta),
                       ProcAlmacenado2.MakeParam("@ip", SqlDbType.NVarChar, 0, configequipo.ip),
                       ProcAlmacenado2.MakeParam("@puertofiscal", SqlDbType.Int, 0, configequipo.puertofiscal),
                       ProcAlmacenado2.MakeParam("@modelofiscal", SqlDbType.Int, 0, configequipo.modelofiscal),
                       ProcAlmacenado2.MakeParam("@idempresa", SqlDbType.Int, 0, configequipo.idempresa),
                       ProcAlmacenado2.MakeParam("@marcafiscal", SqlDbType.NVarChar, 0, configequipo.marcafiscal),
                       ProcAlmacenado2.MakeParam("@cod_empresa", SqlDbType.Int, 0, 1),
                 ProcAlmacenado2.MakeParam("@impticket", SqlDbType.NVarChar, 0, configequipo.impticket),
                 ProcAlmacenado2.MakeParam("@impreporte", SqlDbType.NVarChar, 0, configequipo.impreporte),
                 ProcAlmacenado2.MakeParam("@Puntoventa", SqlDbType.NVarChar, 0, configequipo.puntoventa),
                 ProcAlmacenado2.MakeParam("@FormatoImpFactElectronica", SqlDbType.NVarChar, 0, configequipo.FormatoImpFactElectronica),
                 ProcAlmacenado2.MakeParam("@FormatoImpProforma", SqlDbType.NVarChar, 0, configequipo.formatoimpproforma),
                 ProcAlmacenado2.MakeParam("@FormatoImpRemito", SqlDbType.NVarChar, 0, configequipo.formatoimpremito),
                 ProcAlmacenado2.MakeParam("@certificado", SqlDbType.NVarChar, 0, configequipo.certificado)


                 };
                ProcAlmacenado2.ExecuteNonQuery("SP_CONFIG_EMPRESA", dbParams);

                /*
                cn.Open();
                //en el sp si esta el equipo lo va actualizar pero si no esta el equipo lo agrega
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CONFIG_EMPRESA");
                //Modo 3 agregar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                comando.Parameters.Add(parModo);

                SqlParameter parequipo = ProcAlmacenado.asignarParametros("@equipo", SqlDbType.NVarChar,configequipo.equipo);
                comando.Parameters.Add(parequipo);

                SqlParameter parusuarioconectado = ProcAlmacenado.asignarParametros("@usuarioconectado", SqlDbType.NVarChar, configequipo.usuario);
                comando.Parameters.Add(parusuarioconectado );

                SqlParameter parturno = ProcAlmacenado.asignarParametros("@turno", SqlDbType.NVarChar, configequipo.turno);
                comando.Parameters.Add(parturno );

                SqlParameter paridusuario = ProcAlmacenado.asignarParametros("@idusuario", SqlDbType.Int, configequipo.idusuario);
                comando.Parameters.Add(paridusuario );

                SqlParameter parcodsucursal = ProcAlmacenado.asignarParametros("@cod_sucursal", SqlDbType.Int , configequipo.codsucursal);
                comando.Parameters.Add(parcodsucursal );

                SqlParameter parfecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime , configequipo.fecha);
                comando.Parameters.Add(parfecha );

                SqlParameter paruta = ProcAlmacenado.asignarParametros("@ruta", SqlDbType.NVarChar, configequipo.ruta);
                comando.Parameters.Add(paruta);

                SqlParameter parip = ProcAlmacenado.asignarParametros("@ip", SqlDbType.NVarChar, configequipo.ip);
                comando.Parameters.Add(parip );

                SqlParameter parpuertofiscal = ProcAlmacenado.asignarParametros("@puertofiscal", SqlDbType.Int, configequipo.puertofiscal);
                comando.Parameters.Add(parpuertofiscal );

                SqlParameter parmodelofiscal = ProcAlmacenado.asignarParametros("@modelofiscal", SqlDbType.Int, configequipo.modelofiscal);
                comando.Parameters.Add(parmodelofiscal );

                SqlParameter paridempresa = ProcAlmacenado.asignarParametros("@idempresa", SqlDbType.Int, configequipo.idempresa);
                comando.Parameters.Add(paridempresa );

                SqlParameter parmarcafiscal = ProcAlmacenado.asignarParametros("@marcafiscal", SqlDbType.NVarChar, configequipo.marcafiscal);
                comando.Parameters.Add(parmarcafiscal);

                SqlParameter parEmpresa = ProcAlmacenado.asignarParametros("@cod_empresa", SqlDbType.Int, 1);
                comando.Parameters.Add(parEmpresa);



                  if (comando.ExecuteNonQuery() == 1)
                {

                    respuesta = "ok";
                }
                else
                {

                    respuesta = "error";
                }
                cn.Close();
                 */
            }
            catch (Exception ex)
            {
                throw ex;

            }

            return respuesta;
        }

        public bool Mostrarequipo(string equipo)
        {
            bool login = true;

            try
            {
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CONFIG_EMPRESA");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@MODO", SqlDbType.Int, 5);
                comando.Parameters.Add(parModo);

                SqlParameter parUsuario = ProcAlmacenado.asignarParametros("@equipo", SqlDbType.NVarChar, equipo);
                comando.Parameters.Add(parUsuario);

                SqlParameter parEmpresa = ProcAlmacenado.asignarParametros("@cod_empresa", SqlDbType.Int, 1);
                comando.Parameters.Add(parEmpresa);


                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read() == true)
                {

                    this.idequipo = Convert.ToInt32(dr["id_equipo"]);
                    this.equipo = Convert.ToString(dr["equipo"]);
                    this.usuario = Convert.ToString(dr["usuarioconectado"]);
                    this.turno = Convert.ToString(dr["turno"]);
                    this.idusuario = Convert.ToInt32(dr["id_usuario"]);
                    this.codsucursal = Convert.ToInt32(dr["cod_sucursal"]);
                    this.fecha = Convert.ToDateTime(dr["fecha"]);
                    this.ruta = Convert.ToString(dr["ruta"]);
                    this.ip = Convert.ToString(dr["ip"]);
                    this.puertofiscal = Convert.ToInt32(dr["puerto_fiscal"]);
                    this.modelofiscal = Convert.ToInt32(dr["modelofiscal"]);
                    this.idempresa = Convert.ToInt32(dr["idempresa"]);
                    this.marcafiscal = Convert.ToString(dr["marcafiscal"]);
                    this.impreporte = Convert.ToString(dr["ImpReporte"]);
                    this.impticket = Convert.ToString(dr["Impticket"]);
                    this.puntoventa = Convert.ToString(dr["Puntoventa"]);
                    this.BalanzaPuerto = Convert.ToString(dr["BalanzaPuerto"]);
                    this.FormatoImpFactElectronica = Convert.ToString(dr["FormatoImpFactElectronica"]);
                    this.formatoimpproforma = Convert.ToString(dr["FormatoImpProforma"]);
                    this.formatoimpremito = Convert.ToString(dr["FormatoImpRemito"]);
                    this.certificado = Convert.ToString(dr["Certificado"]);


                    login = true;

                }
                else
                {
                    login = false;
                }
                cn.Close();
            }
            catch (Exception ex)
            {

                throw;

            }



            return login;


        }

        public string actualizarequipo(string usuario, string turno, int idusuario, DateTime fecha, int idequipo)
        {
            string msg = "";
            try
            {
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CONFIG_EMPRESA");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@MODO", SqlDbType.Int, 6);
                comando.Parameters.Add(parModo);

                SqlParameter parUsuario = ProcAlmacenado.asignarParametros("@usuarioconectado", SqlDbType.NVarChar, usuario);
                comando.Parameters.Add(parUsuario);

                SqlParameter parTurno = ProcAlmacenado.asignarParametros("@turno", SqlDbType.NVarChar, turno);
                comando.Parameters.Add(parTurno);


                SqlParameter parIdusuario = ProcAlmacenado.asignarParametros("@idusuario", SqlDbType.Int, idusuario);
                comando.Parameters.Add(parIdusuario);

                SqlParameter paridequipo = ProcAlmacenado.asignarParametros("@idequipo", SqlDbType.Int, idequipo);
                comando.Parameters.Add(paridequipo);

                SqlParameter parfecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime, fecha);
                comando.Parameters.Add(parfecha);

                SqlParameter parEmpresa = ProcAlmacenado.asignarParametros("@cod_empresa", SqlDbType.Int, 1);
                comando.Parameters.Add(parEmpresa);


                if (comando.ExecuteNonQuery() == 1)
                {

                    msg = "ok";

                }
                else
                {
                    msg = "error";
                }
                cn.Close();
            }
            catch (Exception ex)
            {

                throw;

            }

            return msg;
        }
        public object configsistema(string nombre)
        {
            string msg = "ok";
            string valor = "";
            string tipovalor = "";
            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
            {
             ProcAlmacenado2.MakeParam("@nombreconf", SqlDbType.VarChar, 0, nombre),
             ProcAlmacenado2.MakeParam("@cod_empresa", SqlDbType.Int, 0, 1),
             ProcAlmacenado2.MakeParam("@Modo", SqlDbType.Int,0,7),


            };
                SqlDataReader dr;
                dr = ProcAlmacenado2.ExecuteDataReader("SP_CONFIG_EMPRESA", dbParams);
                if (dr.Read())
                {
                    valor = Convert.ToString(dr["valor"]);
                    tipovalor = Convert.ToString(dr["tipovalor"]);
                }


            }

            catch (Exception ex)
            {
                throw;

            }

            return valor;

        }



    }
}
