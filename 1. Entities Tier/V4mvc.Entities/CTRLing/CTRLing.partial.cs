using System;

namespace V4mvc.Entities
{
    public partial class CTRLing
    {
        #region [ Variables Validación ]
        public String DATA_GRAFIC { get; set; }
        public String OPCION { get; set; }
        public String FECHAINI_INF1 { get; set; }
        public String FECHAFIN_INF1 { get; set; }
        public String FECHAINI_INF2 { get; set; }
        public String FECHAFIN_INF2 { get; set; }
        public String FECHAINI_INF3 { get; set; }
        public String FECHAFIN_INF3 { get; set; }
        public String DSCTIPOV { get; set; }
        public String SEXO { get; set; }
        public int ID_AREA { get; set; }
        public int ING { get; set; }
        public int SAL { get; set; }
        public int ERRIN { get; set; }
        public int ERROUT { get; set; }
        public int VEHIN { get; set; }
        public int VEHOUT { get; set; }
        public string PERIODOCOSULTA { get; set; }

        public int TOTAL_ING { get; set; }
        public int TOTAL_ERRIN { get; set; }
        public int TOTAL_SAL { get; set; }
        public int TOTAL_ERROUT { get; set; }
        public int TOTAL_VEHIN { get; set; }
        public int TOTAL_VEHOUT { get; set; }

        public string ACRONIMO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public int CANTIDAD { get; set; }


        public int LENGTH { get; set; }
        public int START { get; set; }
        public int TOTALREGISTROS { get; set; }
        public int ROWNUMBER { get; set; }


        //InformeDiarioControlAccesoDiaTotal
        public string ROL { get; set; }
        public string GERENCIA { get; set; }
        public string INGRESO { get; set; }
        public string SALIDA { get; set; }
        public string ADMINOST { get; set; }
        public string ADMINOSTNOM { get; set; }
        public string AREA { get; set; }
        public string DIVCOD { get; set; }
        public string CAMPO { get; set; }
        public String FECHAINI_FILTER { get; set; }
        public String FECHAFIN_FILTER { get; set; }
        public String ALERTAIN { get; set; }
        public String ALERTAOUT { get; set; }
        public String FECHA_INFORME { get; set; }
        public String FECHA_INFORME_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FECHA_INFORME, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public String FECHA_LETRA
        {
            get
            {
                return (Utils.Fec_User(Utils.Fec_User(FECHA, Utils.Formato_Fecha.BaseDatos), Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string EMPRESA_FORMATO
        {
            get
            {
                return (Utils.strRut(EMPRESA));
            }
        }
        public string RUTINGRESO_FORMATO
        {
            get
            {
                return (Utils.strRut(RUTINGRESO));
            }
        }
        public string USUARIO_FORMATO
        {
            get
            {
                return (Utils.strRut(USUARIO));
            }
        }
        public String FECHA_FILTER { get; set; }
        public String FECHA_FILTER_LETRA
        {
            get
            {
                return (Utils.Fec_User(FECHA_FILTER, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public int PERIODO { get; set; }
        public string PATENTE_FORMATO
        {
            get
            {
                return (Utils.FormatoPatente(PATENTE));
            }
        }
        public int INGRESO_INT { get; set; }
        public int SALIDA_INT { get; set; }
        #endregion

        #region [ Propiedades Validación ]
        #endregion
    }
}
