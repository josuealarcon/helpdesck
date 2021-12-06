using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALiquidacion
	{

		#region [ Consultas ]
		ObservableCollection<Liquidacion> GetLiquidacionUploadFuncionarios(string RUT, string EMPRESA);
		bool InsertLiquidacionUploadFuncionarios(Liquidacion item);
		bool DeleteLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA, int ID_DISPUTA, string USUARIO);
		Liquidacion GetLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA);
		bool UpdateLiquidacionFuncionariosCtta(Liquidacion item);
		bool InsertLiquidacionDisputaFuncionariosCtta(string RUT, string FECHA, string EMPRESA, string OBSERVACION, string USUARIO);
		#endregion

		#region [ Metodos ]
		bool SaveLiquidacion_ControlLaboralCtta(Liquidacion liquidacion);

		bool SaveLiquidacion_v2_ControlLaboralCtta(ref Liquidacion liquidacion);

		bool ValidarLiquidacionCtta(ref Liquidacion modelo);
		#endregion
	}
}
