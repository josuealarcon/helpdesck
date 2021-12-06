
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCert_Tasas
    {
        #region [ Consultas ]
        public ObservableCollection<Cert_Tasas> GetAllCertTasas_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllCertTasas_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Tasas GetOneCertTasas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneCertTasas_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Tasas GetOneCertTasas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneCertTasas_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Tasas GetOneCertTasas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneCertTasas_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveCertTasas_ControlLaboralCtta(ref Archivos archivo, Cert_Tasas model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertCertTasas_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdateCertTasas_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdateCertTasas_v3_ControlLaboralCtta(model);
                    }

                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertTasasDispFile_ControlLaboralCtta(ref Cert_Tasas modelo)
        {
            try
            {
                return Repository.DelCertTasasDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertTasas_ControlLaboralCtta(ref Cert_Tasas modelo)
        {
            try
            {
                return Repository.DelCertTasas_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	