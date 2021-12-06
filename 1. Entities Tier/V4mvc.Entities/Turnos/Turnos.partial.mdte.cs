using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class Turnos
    {

        #region [ Variables Validación ]

        public string FECSUBE_FORMATO { get { return Utils.Fec_User(FECSUBE, Utils.Formato_Fecha.GuionMesLetras); } }
        public string FECHAMOD_FORMATO { get { return Utils.Fec_User(FECHAMOD, Utils.Formato_Fecha.GuionMesLetras); } }
        public string ESTADO { get; set; }
        public string ACRONIMO { get; set; }
        public string RUT { get; set; }
        public string RUT_FORMATO { get { return Utils.strRut(RUT); } }
        public string EMPRESA_FORMATO { get { return Utils.strRut(EMPRESA); } }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }

        public int COUNT { get; set; }
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }

        public ObservableCollection<OSTArbol> LIST_OSTARBOL { get; set; }
        public byte[] ARCHIVO { get; set; }
        public string FECINICIO_FORMATO { get { return Utils.Fec_User(FECINICIO, Utils.Formato_Fecha.GuionMesLetras); } }
        public string FVIGENCIA_FORMATO { get { return Utils.Fec_User(FVIGENCIA, Utils.Formato_Fecha.Guion); } }

        #endregion

        #region [ Propiedades Validación ]

        #endregion

    }
}
