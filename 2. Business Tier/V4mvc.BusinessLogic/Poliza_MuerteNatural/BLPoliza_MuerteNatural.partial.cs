
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLPoliza_MuerteNatural
    {
        #region [ Consultas ]
        public ObservableCollection<Poliza_MuerteNatural> GetAllPolizaMuerteNatural_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllPolizaMuerteNatural_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_MuerteNatural GetOnePolizaMuerteNat_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaMuerteNat_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_MuerteNatural GetOnePolizaMuerteNat_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaMuerteNat_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_MuerteNatural GetOnePolizaMuerteNat_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaMuerteNat_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SavePolizaMuerteNat_ControlLaboralCtta(ref Archivos archivo, Poliza_MuerteNatural model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertPolizaMuerteNat_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdatePolizaMuerteNat_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdatePolizaMuerteNat_v3_ControlLaboralCtta(model);
                    }

                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteNatDispFile_ControlLaboralCtta(ref Poliza_MuerteNatural modelo)
        {
            try
            {
                return Repository.DelPolizaMuerteNatDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaMuerteNat_ControlLaboralCtta(ref Poliza_MuerteNatural modelo)
        {
            try
            {
                return Repository.DelPolizaMuerteNat_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	