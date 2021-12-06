using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
    public partial class Workers
    {

        #region [ Variables Validación ]

        public string rut_nombres_apellidos;
        public string fecha_nacimiento;
        

        public String DIVISIONES { get; set; }

        public String EMPRESAS { get; set; }

        public String RUT_NOMBRES_APELLIDOS
        {
            get
            {
                return rut_nombres_apellidos = (string.IsNullOrEmpty(RUT) ? "" : RUT) + " " + (string.IsNullOrEmpty(m_nombres) ? "" : m_nombres) + " " + (string.IsNullOrEmpty(m_apellidos) ? "" : m_apellidos);
            }
            set { rut_nombres_apellidos = value; }
            //get { return rut_nombres_apellidos; }
            //    set { rut_nombres_apellidos = (string.IsNullOrEmpty(RUT)?"": RUT) + " " + (string.IsNullOrEmpty(m_nombres)?"":m_nombres) + " " + (string.IsNullOrEmpty(m_apellidos)?"":m_apellidos); }
        }

        public string FECHA_NACIMIENTO1
        {
            get
            {
                return (Utils.Fec_User(FECHNACIM, Utils.Formato_Fecha.Guion));
            }
        }

        public string FECHA_NACIMIENTO2_EDAD
        {
            get
            {
                return Utils.Fec_User(FECHNACIM, Utils.Formato_Fecha.GuionMesLetras) + " | " + Utils.ObtieneEdad(FECHNACIM);
            }
        }

        public string EDAD {
            get {
                return Utils.ObtieneEdad(FECHNACIM);
            }
        }

        public string TIPOSEGURO { get; set; }
        public string SEGURO { get; set; }
        public string OCUPACION { get; set; }

        public string APELLIDO_PATERNO
        {
            get
            {
                return (Utils.SplitApellidos(APELLIDOS, Utils.Apellido.Paterno));
            }
        }
        public string APELLIDO_MATERNO
        {
            get
            {
                return (Utils.SplitApellidos(APELLIDOS, Utils.Apellido.Materno));
            }
        }

        public string FECHAHOY { get; set; }

        public string FECHAHOY_GUION
        {
            get
            {
                return (Utils.Fec_User(FECHAHOY, Utils.Formato_Fecha.Guion));
            }
        }

        public string ACRONIMO { get; set; }
        public string COUNT_WORKERS { get; set; }

        public ObservableCollection<Local> ZONAS_CONDUCCION { get; set; }
        public ObservableCollection<Local> ZONAS_ACCESO { get; set; }
        
        public string DIRECCION { get; set; }
        public string COMUNA { get; set; }
        public string CIUDAD { get; set; }
        public string REGION { get; set; }
        public string PAIS { get; set; }
        public string FONOHELP { get; set; }
        public string FONO { get; set; }
        public string CELULAR { get; set; }
        public ObservableCollection<Direccion> LISTA_PAISES { get; set; }
        public string SELECTED { get; set; }
        public string EMAILOLD { get; set; }
        public bool CHECKED { get; set; }

        public string MSG_EXISTE { get; set; }
        public string MSG_TIENE { get; set; }
        public string MSG_RESERVA { get; set; }

        public string RUT_FORMATO
        {
            get
            {
                return Utils.strRut(RUT);
            }
        }

        public Archivos FOTO { get; set; }
        public string FOTOBase64 { get; set; }
        #endregion

        #region [ Propiedades Validación ]

        public String EMPRESA_FUNC { get; set; }
        public String NOMBRE_EMPRESA_FUNC { get; set; }
        public Boolean PUEDE_PEDIR_PASE { get; set; }
        public Nullable<Int32> CUENTA_VISITAS { get; set; }
        public Boolean CONDUCE { get; set; }
        public String CONDUCE_TXT { get; set; }
        public Boolean HOTEL { get; set; }
        public String HOTEL_TXT { get; set; }
        public Boolean CASINO { get; set; }
        public String CASINO_TXT { get; set; }
        public Boolean SINOLT { get; set; }
        public String SINOLT_TXT { get; set; }
        public String PERIODO { get; set; }
        public Nullable<Int32> LIMITEPASESV { get; set; }
        public String EXAMEN { get; set; }
        public Nullable<Int32> PASES_ACTIVOS { get; set; }
        public String COMUN { get; set; }
        public String EMPRESA_FINIQ { get; set; }
        public String NOMBRE_EMPRESA_FINIQ { get; set; }
        public String EMPRESA_NOMINA { get; set; }
        public String NOMBRE_EMPRESA_NOMINA { get; set; }
        public String EMPRESA_FINIQ_NOMINA { get; set; }
        public String NOMBRE_EMPRESA_FINIQ_NOMINA { get; set; }
        public String FECNACIM { get; set; }
        public Nullable<Int32> IDCATEGORIACTTA { get; set; }
        public Nullable<Int32> IDSUBCATEGORIACCTTA { get; set; }
        public String CATEGORIA_TXT { get; set; }
        public String SUBCATEGORIA_TXT { get; set; }
        public Boolean CERTT { get; set; }

        public int SUMA_FUNCIONARIOS_CTTA { get; set; }
        public int SUMA_CERTIFICADOS_CTTA { get; set; }
        public int SUMA_NOCERTIFICADOS_CTTA { get; set; }
        public int SUMA_HISTORICO_CTTA { get; set; }
        public int SUMA_FUNCIONARIOS_MDTE { get; set; }
        public int SUMA_CERTIFICADOS_MDTE { get; set; }
        public int SUMA_NOCERTIFICADOS_MDTE { get; set; }
        public int SUMA_HISTORICO_MDTE { get; set; }
        public String LICONDLT { get; set; }
        public string FECHA { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public ObservableCollection<Enterprise> Lista_Empresas { get; set; }
        public string PERIODO_LETRA
        {
            get
            {
                return (Utils.Fec_User(PERIODO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public String ENTREGADO { get; set; }
        public int CERT { get; set; }
        
        public string RUT_LETRA
        {
            get
            {
                return (Utils.strRut(RUT));
            }
        }

        public string RUT_F
        {
            get
            {
                return (Utils.strRut(RUT));
            }
        }
        public string FINIPASE_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FINIPASE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FFINPASE_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FFINPASE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string EMPRESA_FORMATO
        {
            get
            {
                return (Utils.strRut(EMPRESA));
            }
        }
        public string BLOQUEADO { get; set; }
        public string NOMCOMPLETO { get { return NOMBRES + ' ' + APELLIDOS; } }
        public string FECEXPIREX_GML
        {
            get
            {
                return (Utils.Fec_User(FECEXPIREX, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHARLA_GML
        {
            get
            {
                return (Utils.Fec_User(FECHARLA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string PERIODO_LETRAFECHARLA_GML
        {
            get
            {
                return (Utils.Fec_User(PERIODO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FECEXPIRALIC_GML
        {
            get
            {
                return (Utils.Fec_User(FECEXPIRALIC, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string ESCOLTA { get; set; }

        #endregion

        #region [ Email-Examen Psicosensotecnico ]

        public string EMPRESA_RESERVA { get; set; }
        public string FUNCIONARIO { get; set; }
        public string TIPO_EXAMEN { get; set; }
        public string QUIEN_RESERVO { get; set; }
        public string FECHA_RESERVA { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_TERMINO { get; set; }
        public string FECHA_RESERVA_FORMATO 
        {
            get
            {
                return (Utils.Fec_User(FECHA_RESERVA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        #endregion

        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public string IDEMPRESA { get; set; }
        public string USUARIO { get; set; }
    }
}
