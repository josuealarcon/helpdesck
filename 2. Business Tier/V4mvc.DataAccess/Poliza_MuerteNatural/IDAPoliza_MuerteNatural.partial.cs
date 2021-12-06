
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAPoliza_MuerteNatural
    {
        #region [ Consultas ]
        ObservableCollection<Poliza_MuerteNatural> GetAllPolizaMuerteNatural_ControlLaboralCtta(string IDEMPRESA);
        Poliza_MuerteNatural GetOnePolizaMuerteNat_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Poliza_MuerteNatural GetOnePolizaMuerteNat_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Poliza_MuerteNatural GetOnePolizaMuerteNat_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool InsertPolizaMuerteNat_ControlLaboralCtta(Poliza_MuerteNatural model, out int RET_CODE);

        bool UpdatePolizaMuerteNat_ControlLaboralCtta(Poliza_MuerteNatural model, out int RET_CODE);

        bool UpdatePolizaMuerteNat_v3_ControlLaboralCtta(Poliza_MuerteNatural model);

        bool DelPolizaMuerteNatDispFile_ControlLaboralCtta(ref Poliza_MuerteNatural modelo);

        bool DelPolizaMuerteNat_ControlLaboralCtta(ref Poliza_MuerteNatural modelo);
        #endregion
    }
}
	