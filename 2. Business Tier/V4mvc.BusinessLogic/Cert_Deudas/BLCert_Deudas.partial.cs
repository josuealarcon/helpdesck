
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCert_Deudas
    {
        #region [ Consultas ]
        public ObservableCollection<Cert_Deudas> GetAllCertDeudas_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllCertDeudas_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Deudas GetOneCertDeudas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneCertDeudas_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Cert_Deudas GetOneCertDeudas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneCertDeudas_v2_ControlLaboralCtta(EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_Deudas GetOneCertDeudas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                return Repository.GetOneCertDeudas_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveCertDeuda_ControlLaboralCtta(ref Archivos archivo, Cert_Deudas model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertCertDeuda_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if(model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdateCertDeuda_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdateCertDeuda_v3_ControlLaboralCtta(model);
                    }

                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DelCertDeudaDispFile_ControlLaboralCtta(ref Cert_Deudas modelo)
        {
            try
            {
                return Repository.DelCertDeudaDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertDeuda_ControlLaboralCtta(ref Cert_Deudas modelo)
        {
            try
            {
                return Repository.DelCertDeuda_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	