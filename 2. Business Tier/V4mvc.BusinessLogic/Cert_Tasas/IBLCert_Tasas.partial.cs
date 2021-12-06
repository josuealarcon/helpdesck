
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLCert_Tasas
    {
        #region [ Consultas ]
        ObservableCollection<Cert_Tasas> GetAllCertTasas_ControlLaboralCtta(string IDEMPRESA);

        Cert_Tasas GetOneCertTasas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Cert_Tasas GetOneCertTasas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Cert_Tasas GetOneCertTasas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool SaveCertTasas_ControlLaboralCtta(ref Archivos archivo, Cert_Tasas model, out int RET_CODE);

        bool DelCertTasasDispFile_ControlLaboralCtta(ref Cert_Tasas modelo);

        bool DelCertTasas_ControlLaboralCtta(ref Cert_Tasas modelo);
        #endregion
    }
}
	