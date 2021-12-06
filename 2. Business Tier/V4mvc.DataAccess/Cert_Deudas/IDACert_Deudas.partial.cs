
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDACert_Deudas
    {
        #region [ Consultas ]
        ObservableCollection<Cert_Deudas> GetAllCertDeudas_ControlLaboralCtta(string IDEMPRESA);

        Cert_Deudas GetOneCertDeudas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Cert_Deudas GetOneCertDeudas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Cert_Deudas GetOneCertDeudas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool InsertCertDeuda_ControlLaboralCtta(Cert_Deudas model, out int RET_CODE);

        bool UpdateCertDeuda_ControlLaboralCtta(Cert_Deudas model, out int RET_CODE);

        bool UpdateCertDeuda_v3_ControlLaboralCtta(Cert_Deudas model);

        bool DelCertDeudaDispFile_ControlLaboralCtta(ref Cert_Deudas modelo);

        bool DelCertDeuda_ControlLaboralCtta(ref Cert_Deudas modelo);
        #endregion
    }
}
	