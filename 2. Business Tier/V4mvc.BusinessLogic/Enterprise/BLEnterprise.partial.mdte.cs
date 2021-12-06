using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLEnterprise
    {

        #region [ Consultas ]

        public ObservableCollection<Enterprise> GetEnterprisesMdteSearcherMdte(ref Enterprise model)
        {
            try
            {
                return this.Repository.GetEnterprisesMdteSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Enterprise> GetEnterprisesCttaSearcherMdte(ref Enterprise model)
        {
            try
            {
                return this.Repository.GetEnterprisesCttaSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Enterprise> GetAllEnterpriseCamo_Mdte(string MADRE, string EMPRESA, string NROOST)
        {
            try
            {
                return this.Repository.GetAllEnterpriseCamo_Mdte(MADRE, EMPRESA, NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Enterprise GetOneEnterprise_CertificacionMdte(string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetOneEnterprise_CertificacionMdte(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Enterprise GetOneEnterprise_CertificacionMdte(Enterprise modelo)
        {
            try
            {
                return this.Repository.GetOneEnterprise_CertificacionMdte(modelo);
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
                return this.Repository.SaveOneEnterprise_CertificacionMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
