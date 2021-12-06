
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
        public ObservableCollection<Cert_No_Deuda> GetAllCertNoDeuda_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Cert_No_Deuda.GetAllCertNoDeuda_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_No_Deuda GetOneCertNoDeudas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, Guid ID)
        {
            try
            {
                return this.BL_Cert_No_Deuda.GetOneCertNoDeudas_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_No_Deuda GetOneCertNoDeudas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, Guid ID)
        {
            try
            {
                return this.BL_Cert_No_Deuda.GetOneCertNoDeudas_v2_ControlLaboralCtta(EMPRESA, PERIODO, ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_No_Deuda GetOneCertNoDeudas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string OST)
        {
            try
            {
                return this.BL_Cert_No_Deuda.GetOneCertNoDeudas_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveCertNoDeuda_ControlLaboralCtta(ref Archivos archivo, Cert_No_Deuda model, out int RET_CODE)
        {
            try
            {
                return this.BL_Cert_No_Deuda.SaveCertNoDeuda_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public bool DelCertNoDeudaDispFile_ControlLaboralCtta(ref Cert_No_Deuda modelo)
        {
            try
            {
                return this.BL_Cert_No_Deuda.DelCertNoDeudaDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertNoDeuda_ControlLaboralCtta(ref Cert_No_Deuda modelo)
        {
            try
            {
                return this.BL_Cert_No_Deuda.DelCertNoDeuda_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	