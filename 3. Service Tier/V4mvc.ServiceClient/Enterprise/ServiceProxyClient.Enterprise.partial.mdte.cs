using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<Enterprise> GetEnterprisesMdteSearcherMdte(ref Enterprise model)
        {
            try
            {
                return this.BL_Enterprise.GetEnterprisesMdteSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Enterprise> GetEnterprisesCttaSearcherMdte(ref Enterprise model)
        {
            try
            {
                return this.BL_Enterprise.GetEnterprisesCttaSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Enterprise> GetAllEnterpriseCamo_Mdte(string MADRE, string EMPRESA, string NROOST)
        {
            try
            {
                return this.BL_Enterprise.GetAllEnterpriseCamo_Mdte(MADRE, EMPRESA, NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Enterprise GetOneEnterprise_CertificacionMdte(string IDEMPRESA)
        {
            try
            {
                return this.BL_Enterprise.GetOneEnterprise_CertificacionMdte(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Enterprise GetOneEnterprise_CertificacionMdte(Enterprise modelo)
        {
            try
            {
                return this.BL_Enterprise.GetOneEnterprise_CertificacionMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion

        #region [ Métodos ]

        public bool SaveOneEnterprise_CertificacionMdte(ref Enterprise modelo)
        {
            try
            {
                return this.BL_Enterprise.SaveOneEnterprise_CertificacionMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
