
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDACert_Tasas
    {
        #region [ Consultas ]
        ObservableCollection<Cert_Tasas> GetAllCertTasas_ControlLaboralCtta(string IDEMPRESA);

        Cert_Tasas GetOneCertTasas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Cert_Tasas GetOneCertTasas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);


        Cert_Tasas GetOneCertTasas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool InsertCertTasas_ControlLaboralCtta(Cert_Tasas model, out int RET_CODE);

        bool UpdateCertTasas_ControlLaboralCtta(Cert_Tasas model, out int RET_CODE);

        bool UpdateCertTasas_v3_ControlLaboralCtta(Cert_Tasas model);

        bool DelCertTasasDispFile_ControlLaboralCtta(ref Cert_Tasas modelo);

        bool DelCertTasas_ControlLaboralCtta(ref Cert_Tasas modelo);
        #endregion
    }
}
	