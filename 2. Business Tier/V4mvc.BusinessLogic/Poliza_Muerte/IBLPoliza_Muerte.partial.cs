
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLPoliza_Muerte
    {
        #region [ Consultas ]
        ObservableCollection<Poliza_Muerte> GetAllPolizaMuerteAcc_ControlLaboralCtta(string IDEMPRESA);

        Poliza_Muerte GetOnePolizaMuerteAcc_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Poliza_Muerte GetOnePolizaMuerteAcc_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Poliza_Muerte GetOnePolizaMuerteAcc_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool SavePolizaMuerteAcc_ControlLaboralCtta(ref Archivos archivo, Poliza_Muerte model, out int RET_CODE);

        bool DelPolizaMuerteAccDispFile_ControlLaboralCtta(ref Poliza_Muerte modelo);

        bool DelPolizaMuerteAcc_ControlLaboralCtta(ref Poliza_Muerte modelo);
        #endregion
    }
}
	