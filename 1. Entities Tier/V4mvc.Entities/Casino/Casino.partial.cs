using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class Casino
    {

        #region [ Variables Validación ]

        public string DATA_GRAFIC { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string CONTRATISTA { get; set; }
        public string ADMINOSTNOM { get; set; }
        public int CANTIDAD_REPORTE { get; set; }
        
        public ObservableCollection<Divisiones> OPERACIONES { get; set; }

        public string FECHA_FORMATO
        {
            get
            {
                return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras);
            }
        }

        #region [ Módulo: InformesCasinoAlimentacion ]

        public string FECHA_HOY { get; set; }
        public string DIVCOD { get; set; }
        public string FECHAINI { get; set; }
        public string FECHAFIN { get; set; }
        public string LOCALES { get; set; }
        public string OPTION { get; set; }
        public string ACRONIMO { get; set; }
        public string PERIODOS { get; set; }
        public string RBNTIPOCONSUMO { get; set; }
        public string OP { get; set; }
        public string FECHAINI_FORMATO { get; set; }
        public string FECHAFIN_FORMATO { get; set; }
        public string ADMINOST { get; set; }
        public string RUT_FORMATO
        {
            get
            {
                return Utils.strRut(RUT);
            }
        }
        public string EMPRESA_FORMATO
        {
            get
            {
                return Utils.strRut(EMPRESA);
            }
        }

        #endregion

        #endregion

        #region [ Propiedades Validación ]

        #endregion

    }
}
