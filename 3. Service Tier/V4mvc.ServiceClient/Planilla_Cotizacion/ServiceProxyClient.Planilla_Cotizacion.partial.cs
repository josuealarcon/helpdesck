
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
		public ObservableCollection<Planilla_Cotizacion> GetAllPlanillaCotizacion_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Planilla_Cotizacion.GetAllPlanillaCotizacion_ControlLaboralCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Planilla_Cotizacion GetOnePlanillaCotizacion_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return this.BL_Planilla_Cotizacion.GetOnePlanillaCotizacion_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Planilla_Cotizacion GetOnePlanillaCotizacion_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return this.BL_Planilla_Cotizacion.GetOnePlanillaCotizacion_v2_ControlLaboralCtta(EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Planilla_Cotizacion GetOnePlanillaCotizacion_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                return this.BL_Planilla_Cotizacion.GetOnePlanillaCotizacion_v3_ControlLaboralCtta(ID_DOC, EMPRESA, PERIODO, DIVISION, OST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool SavePlanillaCotizacion_ControlLaboralCtta(ref Archivos archivo, Planilla_Cotizacion model, out int RET_CODE)
        {
            try
            {
                return this.BL_Planilla_Cotizacion.SavePlanillaCotizacion_ControlLaboralCtta(ref archivo, model, out RET_CODE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPlanillaCotizacion_ControlLaboralCtta(ref Planilla_Cotizacion modelo)
        {
            try
            {
                return this.BL_Planilla_Cotizacion.DelPlanillaCotizacion_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPlanillaCotizacionDispFile_ControlLaboralCtta(ref Planilla_Cotizacion modelo)
        {
            try
            {
                return this.BL_Planilla_Cotizacion.DelPlanillaCotizacionDispFile_ControlLaboralCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	