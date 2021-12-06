using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        ObservableCollection<Enterprise> GetEnterprisesMdteSearcherMdte(ref Enterprise model);
        ObservableCollection<Enterprise> GetEnterprisesCttaSearcherMdte(ref Enterprise model);
        ObservableCollection<Enterprise> GetAllEnterpriseCamo_Mdte(string MADRE, string EMPRESA, string NROOST);

        Enterprise GetOneEnterprise_CertificacionMdte(string IDEMPRESA);

        Enterprise GetOneEnterprise_CertificacionMdte(Enterprise modelo);

        #endregion

        #region [ Métodos ]

        bool SaveOneEnterprise_CertificacionMdte(ref Enterprise modelo);

        #endregion

    }
}
