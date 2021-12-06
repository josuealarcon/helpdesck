
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAPoliza_Muerte
    {
        #region [ Consultas ]
        ObservableCollection<Poliza_Muerte> GetAllPolizaMuerteAcc_ControlLaboralCtta(string IDEMPRESA);

        Poliza_Muerte GetOnePolizaMuerteAcc_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Poliza_Muerte GetOnePolizaMuerteAcc_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Poliza_Muerte GetOnePolizaMuerteAcc_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool InsertPolizaMuerteAcc_ControlLaboralCtta(Poliza_Muerte model, out int RET_CODE);

        bool UpdatePolizaMuerteAcc_ControlLaboralCtta(Poliza_Muerte model, out int RET_CODE);

        bool UpdatePolizaMuerteAcc_v3_ControlLaboralCtta(Poliza_Muerte model);

        bool DelPolizaMuerteAccDispFile_ControlLaboralCtta(ref Poliza_Muerte modelo);

        bool DelPolizaMuerteAcc_ControlLaboralCtta(ref Poliza_Muerte modelo);
        #endregion
    }
}
	