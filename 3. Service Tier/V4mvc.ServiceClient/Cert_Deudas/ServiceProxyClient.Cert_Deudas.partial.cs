
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
        public ObservableCollection<Cert_Deudas> GetAllCertDeudas_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Cert_Deudas.GetAllCertDeudas_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Deudas GetOneCertDeudas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Cert_Deudas.GetOneCertDeudas_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Deudas GetOneCertDeudas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Cert_Deudas.GetOneCertDeudas_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Deudas GetOneCertDeudas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Cert_Deudas.GetOneCertDeudas_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool SaveCertDeuda_ControlLaboralCtta(ref Archivos archivo, Cert_Deudas model, out int RET_CODE)
        {
            try
            {
                return this.BL_Cert_Deudas.SaveCertDeuda_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DelCertDeudaDispFile_ControlLaboralCtta(ref Cert_Deudas modelo)
        {
            try
            {
                return this.BL_Cert_Deudas.DelCertDeudaDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertDeuda_ControlLaboralCtta(ref Cert_Deudas modelo)
        {
            try
            {
                return this.BL_Cert_Deudas.DelCertDeuda_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	