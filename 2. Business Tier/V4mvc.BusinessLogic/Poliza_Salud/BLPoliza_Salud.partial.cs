
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLPoliza_Salud
    {
        #region [ Consultas ]
        public ObservableCollection<Poliza_Salud> GetAllPolizaSalud_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllPolizaSalud_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Salud GetOnePolizaSalud_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaSalud_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Salud GetOnePolizaSalud_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaSalud_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Poliza_Salud GetOnePolizaSalud_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOnePolizaSalud_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SavePolizaSalud_ControlLaboralCtta(ref Archivos archivo, Poliza_Salud model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertPolizaSalud_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdatePolizaSalud_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdatePolizaSalud_v3_ControlLaboralCtta(model);
                    }

                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaSaludDispFile_ControlLaboralCtta(ref Poliza_Salud modelo)
        {
            try
            {
                return Repository.DelPolizaSaludDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPolizaSalud_ControlLaboralCtta(ref Poliza_Salud modelo)
        {
            try
            {
                return Repository.DelPolizaSalud_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	