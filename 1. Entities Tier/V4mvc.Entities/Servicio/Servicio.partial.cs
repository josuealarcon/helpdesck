namespace V4mvc.Entities
{
	public partial class Servicio
	{

        #region [ Variables Validación ]
        public string NUM_TICKET { get; set; }
        public string ASUNTO { get; set; }
        public string FECHA { get; set; }
        public string FECHA_GML
        {
            get
            {
                return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras);
            }
        }
        public string AREA { get; set; }
        public string PRIORIDAD { get; set; }
        public string ESTADO { get; set; }
        public string NOMBRES_SOLICITANTE { get; set; }
        public string DNI_USUARIO { get; set; }
        public string NOMBRES_COLABORADOR { get; set; }
        public string DNI_COLABORADOR { get; set; }
        #endregion

        #region [ Propiedades Validación ]

        #endregion

    }
}