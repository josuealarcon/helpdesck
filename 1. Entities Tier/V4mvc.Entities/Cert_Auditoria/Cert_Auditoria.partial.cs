namespace V4mvc.Entities
{ 
    public partial class Cert_Auditoria
    {

        #region [ Variables Validación ]

        public string ACRONIMO { get; set; }
        public string PERIODO_FORMATO
        {
            get
            {
                return (Utils.Fec_User(PERIODO, Utils.Formato_Fecha.Periodo));
            }
        }
        public string FECHA_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHASUBE_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FECHASUBE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHAMOD_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FECHAMOD, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string ACCION { get; set; }
        public string NOMBRE { get; set; }
        public string USER_ADD { get; set; }
        public string USER_MOD { get; set; }

        #endregion

        #region [ Propiedades Validación ]

        #endregion

    }
}
