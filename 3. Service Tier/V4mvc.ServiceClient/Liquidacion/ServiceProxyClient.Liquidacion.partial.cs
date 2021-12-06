using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public ObservableCollection<Liquidacion> GetAllLiquidacion_ControlLaboralCtta(Archivos archivo, string USUARIO, string IDEMPRESA)
		{
			try
			{
				return this.BL_Liquidacion.GetAllLiquidacion_ControlLaboralCtta(archivo, USUARIO,IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Liquidacion> GetLiquidacionUploadFuncionarios(string RUT, string EMPRESA)
		{
			try
			{
				return this.BL_Liquidacion.GetLiquidacionUploadFuncionarios(RUT, EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Liquidacion GetLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA)
		{
			try
			{
				return this.BL_Liquidacion.GetLiquidacionFuncionariosCtta(RUT, FECHA, EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ValidarLiquidacionCtta(ref Liquidacion liquidacion)
		{
			try
			{
				return this.BL_Liquidacion.ValidarLiquidacionCtta(ref liquidacion);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]
		public bool InsertLiquidacionUploadFuncionarios(Liquidacion item)
		{
			try
			{
				return this.BL_Liquidacion.InsertLiquidacionUploadFuncionarios(item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool DeleteLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA, int ID_DISPUTA, string USUARIO)
		{
			try
			{
				return this.BL_Liquidacion.DeleteLiquidacionFuncionariosCtta(RUT, FECHA, EMPRESA, ID_DISPUTA, USUARIO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool UpdateLiquidacionFuncionariosCtta(Liquidacion item)
		{
			try
			{
				return this.BL_Liquidacion.UpdateLiquidacionFuncionariosCtta(item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool InsertLiquidacionDisputaFuncionariosCtta(string RUT, string FECHA, string EMPRESA, string OBSERVACION, string USUARIO)
		{
			try
			{
				return this.BL_Liquidacion.InsertLiquidacionDisputaFuncionariosCtta(RUT, FECHA, EMPRESA, OBSERVACION, USUARIO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveLiquidacion_ControlLaboralCtta(List<Archivos> archivos, Liquidacion liquidacion)
		{
			try
			{
				return this.BL_Liquidacion.SaveLiquidacion_ControlLaboralCtta(archivos, liquidacion);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveBatchLiquidacion_ControlLaboralCtta(ref ObservableCollection<Liquidacion> liquidaciones, ref Liquidacion resumen)
		{
			try
			{
				return this.BL_Liquidacion.SaveBatchLiquidacion_ControlLaboralCtta(ref liquidaciones, ref resumen);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
