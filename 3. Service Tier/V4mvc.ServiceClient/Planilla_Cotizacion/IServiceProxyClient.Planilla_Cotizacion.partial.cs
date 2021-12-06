
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
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]
		ObservableCollection<Planilla_Cotizacion> GetAllPlanillaCotizacion_ControlLaboralCtta(string IDEMPRESA);

		Planilla_Cotizacion GetOnePlanillaCotizacion_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST);

		Planilla_Cotizacion GetOnePlanillaCotizacion_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST);

		Planilla_Cotizacion GetOnePlanillaCotizacion_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST);
		#endregion

		#region [ Metodos ]

		bool SavePlanillaCotizacion_ControlLaboralCtta(ref Archivos archivo, Planilla_Cotizacion model, out int RET_CODE);
		bool DelPlanillaCotizacion_ControlLaboralCtta(ref Planilla_Cotizacion modelo);
		bool DelPlanillaCotizacionDispFile_ControlLaboralCtta(ref Planilla_Cotizacion modelo);
		#endregion

	}
}
	