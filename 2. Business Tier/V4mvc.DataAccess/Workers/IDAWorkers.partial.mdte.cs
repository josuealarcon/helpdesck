using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAWorkers
    {

        #region [ Consultas ]

        ObservableCollection<Workers> GetWorkersSearcherMdte(ref Workers model);
        ObservableCollection<Workers> GetWorkersMdteSearcherMdte(ref Workers model);

        Workers GetOneWorkers_PasesMdte(Docs modelo);

        Workers GetOneWorkerExtra_PasesMdte(Workers modelo);

        Workers GetOneWorkers_CertificacionMdte(Workers modelo);

        Workers GetVerificacionCertificado(string RUT);

        #endregion

        bool SaveOneWorkers_CertificacionMdte(ref Workers modelo);
    }
}
