using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Liquidacion> GetAllLiquidacion_ControlLaboralCtta(Archivos archivo, string USUARIO, string IDEMPRESA);

		ObservableCollection<Liquidacion> GetLiquidacionUploadFuncionarios(string RUT, string EMPRESA);

		Liquidacion GetLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA);
		bool ValidarLiquidacionCtta(ref Liquidacion liquidacion);
	
		#endregion

		#region [ Metodos ]
		bool InsertLiquidacionUploadFuncionarios(Liquidacion item);

		bool DeleteLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA, int ID_DISPUTA, string USUARIO);
		
		bool UpdateLiquidacionFuncionariosCtta(Liquidacion item);
		bool InsertLiquidacionDisputaFuncionariosCtta(string RUT, string FECHA, string EMPRESA, string OBSERVACION, string USUARIO);
		bool SaveLiquidacion_ControlLaboralCtta(List<Archivos> archivos, Liquidacion liquidacion);

		bool SaveBatchLiquidacion_ControlLaboralCtta(ref ObservableCollection<Liquidacion> liquidaciones, ref Liquidacion resumen);

		#endregion

	}
}
