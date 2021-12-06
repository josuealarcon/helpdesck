namespace V4mvc.Entities
{

    public partial class Docs_OST2
    {
        #region [ Variables ]

        public string DOC { get; set; }
        public string VALIDADOFASE1 { get; set; }
        public string VALIDADOFASE2 { get; set; }
        public string NOMBREARCHFASE1 { get; set; }
        public string NOMBREARCHFASE2 { get; set; }
        public string CERTFECHA_ADMINOST_FORMATO
        {
            get
            {
                return (Utils.Fec_User(CERTFECHA_ADMINOST, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string CERTFECHA_FORMATO
        {
            get
            {
                return (Utils.Fec_User(CERTFECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHASUBE_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FECHASUBE, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string F1_NOMBRE_VALIDADOR { get; set; }
        public string F2_NOMBRE_VALIDADOR { get; set; }


        #endregion

        #region [ Propiedades ]

        #endregion
    }

}
	