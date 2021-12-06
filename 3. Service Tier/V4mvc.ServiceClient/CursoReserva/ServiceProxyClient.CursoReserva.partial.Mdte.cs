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

		public ObservableCollection<CursoReserva> GetList_A142_RESERVAS_Mdte(int CODIGO)
		{
			try
			{
				return this.BL_CursoReserva.GetList_A142_RESERVAS_Mdte(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<CursoReserva> GetList_A142_RESULTADOS_Mdte(int CODIGO)
		{
			try
			{
				return this.BL_CursoReserva.GetList_A142_RESULTADOS_Mdte(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
	
		public string ValidarReserva_Mdte(int CURSO, string RUT, int CODIGO)
		{
			try
			{
				return this.BL_CursoReserva.ValidarReserva_Mdte(CURSO, RUT, CODIGO);

			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]
		public Boolean SaveCursoReserva_Mdte(ref CursoReserva Item)
		{
			try
			{
				return this.BL_CursoReserva.SaveCursoReserva_Mdte( Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
