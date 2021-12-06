using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        ObservableCollection<Workers> GetWorkersSearcherMdte(ref Workers model);
        ObservableCollection<Workers> GetWorkersMdteSearcherMdte(ref Workers model);

        Workers GetOneWorkers_PasesMdte(Docs modelo);

        Workers GetOneWorkerExtra_PasesMdte(Workers modelo);

        Workers GetOneWorkers_CertificacionMdte(Workers modelo);

        Workers GetVerificacionCertificado(string RUT);

        #endregion

        #region [ Operaciones ]

        bool SaveOneWorkers_CertificacionMdte(ref Workers modelo);

        #endregion
    }
}
