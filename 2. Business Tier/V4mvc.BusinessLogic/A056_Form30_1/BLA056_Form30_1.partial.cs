
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLA056_Form30_1
    {
        #region [ Consultas ]
        public ObservableCollection<A056_Form30_1> GetAllF301_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllF301_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public A056_Form30_1 GetOneFormF301_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                return Repository.GetOneFormF301_ControlLaboralCtta(ID_DOC, EMPRESA, ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v2_ControlLaboralCtta(int ID_CERTIFICADO)
        {
            try
            {
                return Repository.GetOneFormF301_v2_ControlLaboralCtta(ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(Guid ID)
        {
            try
            {
                return Repository.GetOneFormF301_v3_ControlLaboralCtta(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                var instance = Repository.GetOneFormF301_v3_ControlLaboralCtta(ID_DOC, EMPRESA, ID_CERTIFICADO);
                instance.LISTA_DETALLES = RepositoryFormF301Det.GetFormF30Detalles_ControlLaboralCtta(EMPRESA, ID_CERTIFICADO.ToString());
                return instance;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A056_Form30_1 GetOneFormF301_v4_ControlLaboralCtta(string PERIODO, string EMPRESA)
        {
            try
            {
                return Repository.GetOneFormF301_v4_ControlLaboralCtta(PERIODO, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public A056_Form30_1 GetOneFormF301_v5_ControlLaboralCtta(string PERIODO, string EMPRESA)
        {
            try
            {
                return Repository.GetOneFormF301_v5_ControlLaboralCtta(PERIODO, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SaveFormF301_ControlLaboralCtta(ref Archivos archivo, A056_Form30_1 model, out int RET_CODE)
        {
            bool ok = false;
            List<int> OKLIST = new List<int>();
            int ID_CERTIFICADO_ = 0;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        OKLIST = this.Repository.InsertFormF301_ControlLaboralCtta(model, out RET_CODE, out  ID_CERTIFICADO_);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        OKLIST = this.Repository.UpdateFormF301_ControlLaboralCtta(model, out RET_CODE, out  ID_CERTIFICADO_);
                    }

                    if (OKLIST[0] == -1)
                    {
                        model.ID = null;
                        
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                            model.ID_CERTIFICADO = OKLIST[1];
                        }

                        ok = this.Repository.UpdateFormF301_v3_ControlLaboralCtta(model);

                        if(model.LISTA_DETALLES != null)
                        {
                            foreach(var det in model.LISTA_DETALLES)
                            {
                                det.EMPRESA = model.EMPRESA;
                                det.ID_CERTIFICADO = model.ID_CERTIFICADO.ToString();
                                this.RepositoryFormF301Det.SaveFormF301Detail_ControlLaboralCtta(det);
                            }
                        }

                    }
                    tran.Complete();
                }
                return ok;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF301_ControlLaboralCtta(ref A056_Form30_1 modelo)
        {
            try
            {
                return Repository.DelFormF301_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF301DispFile_ControlLaboralCtta(ref A056_Form30_1 modelo)
        {
            try
            {
                return Repository.DelFormF301DispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	