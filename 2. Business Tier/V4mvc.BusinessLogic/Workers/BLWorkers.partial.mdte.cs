using System;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkers
    {

        #region [ Consultas ]

        public ObservableCollection<Workers> GetWorkersSearcherMdte(ref Workers model)
        {
            try
            {
                return this.Repository.GetWorkersSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> GetWorkersMdteSearcherMdte(ref Workers model)
        {
            try
            {
                return this.Repository.GetWorkersMdteSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkers_PasesMdte(Docs modelo)
        {
            try
            {
                return this.Repository.GetOneWorkers_PasesMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkerExtra_PasesMdte(Workers modelo)
        {
            try
            {
                return this.Repository.GetOneWorkerExtra_PasesMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkers_CertificacionMdte(Workers modelo)
        {
            try
            {
                var worker = this.Repository.GetOneWorkers_CertificacionMdte(modelo);
                if(worker != null && worker.TIENE_DIVISION_EMPRESA == 1)
                {
                    worker.LISTA_DIVISIONES = this.A024_Divisiones_Repository.GetAllA024Divisiones_CertificacionMdte(modelo.DIVISIONES_ENTRE_COMAS);
                }
                return worker;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public  Workers GetVerificacionCertificado(string RUT)
        {
            try
            {
                return this.Repository.GetVerificacionCertificado(RUT);
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
                bool result = false;
                using (TransactionScope tran = new TransactionScope())
                {
                    result = Repository.SaveOneWorkers_CertificacionMdte(ref modelo);
                    if (result)
                    {
                        if (modelo.LISTA_DIVISIONES != null)
                        {
                            foreach (var division in modelo.LISTA_DIVISIONES)
                            {
                                modelo.DIVCOD = division.DIVCOD;
                                result = result && WorkersLocal_Repository.SaveOneWorkersLocal_CertificacionMdte(modelo);
                            }
                        }

                        tran.Complete();
                    }
                }
                return result;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
