namespace V4mvc.Entities
{
    public partial class Docs_Enterprise
    {

        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        #endregion

        #region [ Informe ]

        public string EMPRESA { get; set; }
        public string ACRONIMO { get; set; }
        public string NOMBRE { get; set; }
        public string FECHAINI { get; set; }
        public string FECHAFIN { get; set; }
        public string FECHASUBE_FORMATO
        {
            get
            {
                return Utils.Fec_User(FECHASUBE, Utils.Formato_Fecha.GuionMesLetras);
            }
        }
        public string IDEMPRESA_FORMATO
        {
            get
            {
                return Utils.strRut(IDEMPRESA);
            }
        }

        #endregion

    }
}
