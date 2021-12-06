using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<Workers> GetWorkersSearcherMdte(ref Workers model)
        {
            try
            {
                return this.BL_Workers.GetWorkersSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> GetWorkersMdteSearcherMdte(ref Workers model)
        {
            try
            {
                return this.BL_Workers.GetWorkersMdteSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkers_PasesMdte(Docs modelo)
        {
            try
            {
                return this.BL_Workers.GetOneWorkers_PasesMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkerExtra_PasesMdte(Workers modelo)
        {
            try
            {
                return this.BL_Workers.GetOneWorkerExtra_PasesMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkers_CertificacionMdte(Workers modelo)
        {
            try
            {
                return this.BL_Workers.GetOneWorkers_CertificacionMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetVerificacionCertificado(string RUT)
        {
            try
            {
                return this.BL_Workers.GetVerificacionCertificado(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
       
        #endregion


        #region [ Operaciones ]

        public bool SaveOneWorkers_CertificacionMdte(ref Workers modelo)
        {
            try
            {
                return this.BL_Workers.SaveOneWorkers_CertificacionMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
