
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
		public ObservableCollection<Cert_Tasas> GetAllCertTasas_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Cert_Tasas.GetAllCertTasas_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Tasas GetOneCertTasas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Cert_Tasas.GetOneCertTasas_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Cert_Tasas GetOneCertTasas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Cert_Tasas.GetOneCertTasas_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Tasas GetOneCertTasas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return this.BL_Cert_Tasas.GetOneCertTasas_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveCertTasas_ControlLaboralCtta(ref Archivos archivo, Cert_Tasas model, out int RET_CODE)
        {
            try
            {
                return this.BL_Cert_Tasas.SaveCertTasas_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertTasasDispFile_ControlLaboralCtta(ref Cert_Tasas modelo)
        {
            try
            {
                return this.BL_Cert_Tasas.DelCertTasasDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertTasas_ControlLaboralCtta(ref Cert_Tasas modelo)
        {
            try
            {
                return this.BL_Cert_Tasas.DelCertTasas_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	