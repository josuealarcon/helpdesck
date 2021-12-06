
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCert_No_Deuda
    {
        #region [ Consultas ]
        public ObservableCollection<Cert_No_Deuda> GetAllCertNoDeuda_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllCertNoDeuda_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_No_Deuda GetOneCertNoDeudas_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, Guid ID)
        {
            try
            {
                return Repository.GetOneCertNoDeudas_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_No_Deuda GetOneCertNoDeudas_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, Guid ID)
        {
            try
            {
                return Repository.GetOneCertNoDeudas_v2_ControlLaboralCtta(EMPRESA, PERIODO, ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Cert_No_Deuda GetOneCertNoDeudas_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string OST)
        {
            try
            {
                return Repository.GetOneCertNoDeudas_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveCertNoDeuda_ControlLaboralCtta(ref Archivos archivo, Cert_No_Deuda model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertCertNoDeuda_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdateCertNoDeuda_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdateCertNoDeuda_v3_ControlLaboralCtta(model);
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
        public bool DelCertNoDeudaDispFile_ControlLaboralCtta(ref Cert_No_Deuda modelo)
        {
            try
            {
                return Repository.DelCertNoDeudaDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelCertNoDeuda_ControlLaboralCtta(ref Cert_No_Deuda modelo)
        {
            try
            {
                return Repository.DelCertNoDeuda_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
	