
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLPoliza_Muerte
    {
        #region [ Consultas ]
        public ObservableCollection<Poliza_Muerte> GetAllPolizaMuerteAcc_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllPolizaMuerteAcc_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Muerte GetOnePolizaMuerteAcc_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaMuerteAcc_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Muerte GetOnePolizaMuerteAcc_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaMuerteAcc_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Muerte GetOnePolizaMuerteAcc_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaMuerteAcc_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SavePolizaMuerteAcc_ControlLaboralCtta(ref Archivos archivo, Poliza_Muerte model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertPolizaMuerteAcc_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdatePolizaMuerteAcc_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdatePolizaMuerteAcc_v3_ControlLaboralCtta(model);
                    }

                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteAccDispFile_ControlLaboralCtta(ref Poliza_Muerte modelo)
        {
            try
            {
                return Repository.DelPolizaMuerteAccDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteAcc_ControlLaboralCtta(ref Poliza_Muerte modelo)
        {
            try
            {
                return Repository.DelPolizaMuerteAcc_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	