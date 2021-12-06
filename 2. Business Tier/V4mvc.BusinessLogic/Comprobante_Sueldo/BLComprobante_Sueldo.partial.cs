
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLComprobante_Sueldo
    {
        #region [ Consultas ]
        public ObservableCollection<Comprobante_Sueldo> GetAllComprobanteSueldo_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllComprobanteSueldo_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Comprobante_Sueldo GetOneComprobanteSueldo_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneComprobanteSueldo_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Comprobante_Sueldo GetOneComprobanteSueldo_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneComprobanteSueldo_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Comprobante_Sueldo GetOneComprobanteSueldo_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneComprobanteSueldo_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveComprobanteSueldo_ControlLaboralCtta(ref Archivos archivo, Comprobante_Sueldo model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertComprobanteSueldo_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdateComprobanteSueldo_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdateComprobanteSueldo_v3_ControlLaboralCtta(model);
                    }
                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelComprobanteSueldoDispFile_ControlLaboralCtta(ref Comprobante_Sueldo modelo)
        {
            try
            {
                return Repository.DelComprobanteSueldoDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelComprobanteSueldo_ControlLaboralCtta(ref Comprobante_Sueldo modelo)
        {
            try
            {
                return Repository.DelComprobanteSueldo_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	