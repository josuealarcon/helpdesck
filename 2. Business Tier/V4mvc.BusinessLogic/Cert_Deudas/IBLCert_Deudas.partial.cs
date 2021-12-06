
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLCert_Deudas
    {
        #region [ Consultas ]
        ObservableCollection<Cert_Deudas> GetAllCertDeudas_ControlLaboralCtta(string IDEMPRESA);

        Cert_Deudas GetOneCertDeudas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Cert_Deudas GetOneCertDeudas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Cert_Deudas GetOneCertDeudas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool SaveCertDeuda_ControlLaboralCtta(ref Archivos archivo, Cert_Deudas model, out int RET_CODE);

        bool DelCertDeudaDispFile_ControlLaboralCtta(ref Cert_Deudas modelo);

        bool DelCertDeuda_ControlLaboralCtta(ref Cert_Deudas modelo);
        #endregion
    }
}
	