
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLRemuneraciones_Propio
    {
        #region [ Consultas ]
        public ObservableCollection<Remuneraciones_Propio> GetAllRemuneracionesPropio_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllRemuneracionesPropio_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Remuneraciones_Propio GetOneRemPropio_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return Repository.GetOneRemPropio_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Remuneraciones_Propio GetOneRemPropio_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return Repository.GetOneRemPropio_v2_ControlLaboralCtta(EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Remuneraciones_Propio GetOneRemPropio_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return Repository.GetOneRemPropio_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SaveRemPropio_ControlLaboralCtta(ref Archivos archivo, Remuneraciones_Propio model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try 
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertRemPropio_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdateRemPropio_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }
                        ok = this.Repository.UpdateRemPropio_v3_ControlLaboralCtta(model);
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

        public bool DelRemPropio_ControlLaboralCtta(ref Remuneraciones_Propio modelo)
        {
            try
            {
                return Repository.DelRemPropio_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelRemuneracionPropioDispFile_ControlLaboralCtta(ref Remuneraciones_Propio modelo)
        {
            try
            {
                return Repository.DelRemuneracionPropioDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	