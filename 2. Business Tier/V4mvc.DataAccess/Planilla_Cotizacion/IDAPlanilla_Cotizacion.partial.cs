
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAPlanilla_Cotizacion
    {
        #region [ Consultas ]
        ObservableCollection<Planilla_Cotizacion> GetAllPlanillaCotizacion_ControlLaboralCtta(string IDEMPRESA);

        Planilla_Cotizacion GetOnePlanillaCotizacion_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST);

        Planilla_Cotizacion GetOnePlanillaCotizacion_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST);

        Planilla_Cotizacion GetOnePlanillaCotizacion_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST);
        #endregion

        #region [ Metodos ]

        bool InsertPlanillaCotizacion_ControlLaboralCtta(Planilla_Cotizacion model, out int RET_CODE);

        bool UpdatePlanillaCotizacion_ControlLaboralCtta(Planilla_Cotizacion model, out int RET_CODE);

        bool UpdatePlanillaCotizacion_v3_ControlLaboralCtta(Planilla_Cotizacion model);

        bool DelPlanillaCotizacion_ControlLaboralCtta(ref Planilla_Cotizacion modelo);

        bool DelPlanillaCotizacionDispFile_ControlLaboralCtta(ref Planilla_Cotizacion modelo);
        #endregion
    }
}
	