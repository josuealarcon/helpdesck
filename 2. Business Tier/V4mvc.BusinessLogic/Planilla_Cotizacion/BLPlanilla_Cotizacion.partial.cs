
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLPlanilla_Cotizacion
    {
        #region [ Consultas ]
        public ObservableCollection<Planilla_Cotizacion> GetAllPlanillaCotizacion_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return Repository.GetAllPlanillaCotizacion_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Planilla_Cotizacion GetOnePlanillaCotizacion_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return Repository.GetOnePlanillaCotizacion_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Planilla_Cotizacion GetOnePlanillaCotizacion_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return Repository.GetOnePlanillaCotizacion_v2_ControlLaboralCtta(EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Planilla_Cotizacion GetOnePlanillaCotizacion_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return Repository.GetOnePlanillaCotizacion_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SavePlanillaCotizacion_ControlLaboralCtta(ref Archivos archivo, Planilla_Cotizacion model, out int RET_CODE)
        {
            bool ok = false;
            RET_CODE = -1;
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {

                    if (model.Instance == InstanceEntity.New)
                    {
                        ok = this.Repository.InsertPlanillaCotizacion_ControlLaboralCtta(model, out RET_CODE);
                    }
                    else if (model.Instance == InstanceEntity.Modify)
                    {
                        ok = this.Repository.UpdatePlanillaCotizacion_ControlLaboralCtta(model, out RET_CODE);
                    }
                    if (ok)
                    {
                        model.ID = null;
                        if (archivo != null)
                        {
                            this.RepositoryArchivos.Save(ref archivo);
                            model.ID = archivo.ID;
                        }

                        ok = this.Repository.UpdatePlanillaCotizacion_v3_ControlLaboralCtta(model);
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

        public bool DelPlanillaCotizacion_ControlLaboralCtta(ref Planilla_Cotizacion modelo)
        {
            try
            {
                return Repository.DelPlanillaCotizacion_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPlanillaCotizacionDispFile_ControlLaboralCtta(ref Planilla_Cotizacion modelo)
        {
            try
            {
                return Repository.DelPlanillaCotizacionDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	