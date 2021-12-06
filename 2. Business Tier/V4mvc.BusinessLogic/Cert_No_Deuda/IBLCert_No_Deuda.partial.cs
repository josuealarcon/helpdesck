
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLCert_No_Deuda
    {
        #region [ Consultas ]
        ObservableCollection<Cert_No_Deuda> GetAllCertNoDeuda_ControlLaboralCtta(string IDEMPRESA);

        Cert_No_Deuda GetOneCertNoDeudas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, Guid ID);

        Cert_No_Deuda GetOneCertNoDeudas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, Guid ID);

        Cert_No_Deuda GetOneCertNoDeudas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string OST);
        #endregion

        #region [ Metodos ]
        bool SaveCertNoDeuda_ControlLaboralCtta(ref Archivos archivo, Cert_No_Deuda model, out int RET_CODE);

        bool DelCertNoDeudaDispFile_ControlLaboralCtta(ref Cert_No_Deuda modelo);

        bool DelCertNoDeuda_ControlLaboralCtta(ref Cert_No_Deuda modelo);
        #endregion
    }
}
	