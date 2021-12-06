using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class WorkersLocal_Bono_Resumen
    {

        #region [ Variables Validación ]

        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string ACRONIMO { get; set; }

        #region [ Módulo: InformesAuditoriaLaboralCtta ]

        public string EMPRESA_FORMATO
        {
            get
            {
                return Utils.strRut(EMPRESA);
            }
        }
        public string RUT_FORMATO
        {
            get
            {
                return Utils.strRut(RUT);
            }
        }
        public string FECHA_HOY { get; set; }
        public string DIVCOD { get; set; }
        public ObservableCollection<Divisiones> OPERACIONES { get; set; }

        #endregion

        #endregion

        #region [ Propiedades Validación ]

        #endregion

    }
}
