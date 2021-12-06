
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLA056_Form30
    {
        #region [ Consultas ]
        public ObservableCollection<A056_Form30> GetAllFormF30_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllFormF30_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                return Repository.GetOneFormF30_ControlLaboralCtta(ID_DOC, EMPRESA, ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_v2_ControlLaboralCtta(int ID_CERTIFICADO)
        {
            try
            {
                return Repository.GetOneFormF30_v2_ControlLaboralCtta(ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(Guid ID)
        {
            try
            {
                return Repository.GetOneFormF30_v3_ControlLaboralCtta(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int CERTIFICADO_ID)
        {
            try
            {
                return Repository.GetOneFormF30_v3_ControlLaboralCtta(ID_DOC, EMPRESA, CERTIFICADO_ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveFormF30_ControlLaboralCtta(ref Archivos archivo, A056_Form30 model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            List<int> OKLIST = new List<int>();
            int ID_CERTIFICADO = 0;

            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                   // model.ID = archivo.ID;
                    if (model.Instance == InstanceEntity.New)
                    { 
                        OKLIST = this.Repository.InsertFormF30_ControlLaboralCtta(model, out RET_CODE , out  ID_CERTIFICADO);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        OKLIST = this.Repository.UpdateFormF30_ControlLaboralCtta(model, out RET_CODE, out  ID_CERTIFICADO);
                    }
                    if (OKLIST[0] == -1)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                            model.ID_CERTIFICADO = OKLIST[1]; ;
                        }
                        ok = this.Repository.UpdateFormF30_v3_ControlLaboralCtta(model);
                    }
                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF30DispFile_ControlLaboralCtta(ref A056_Form30 modelo)
        {
            try
            {
                return Repository.DelFormF30DispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF30_ControlLaboralCtta(ref A056_Form30 modelo)
        {
            try
            {
                return Repository.DelFormF30_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	