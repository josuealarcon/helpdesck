using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;
namespace V4mvc
{
	public partial class ServiceProxyClient
	{
		
		#region [ Consultas ]
		public ObservableCollection<Local> GetAllLocal_PasesCtta(string DIVCOD)
		{
			try
			{
				return this.BL_Local.GetAllLocal_PasesCtta(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Local> GetAllLocalesPorDiv_Informe(string DIVCOD, string LOCALL)
		{
			try
			{
				return this.BL_Local.GetAllLocalesPorDiv_Informe(DIVCOD, LOCALL);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Local> GetLocalDivisionCtta(string DIVCOD)
		{
			try
			{
				return this.BL_Local.GetLocalDivisionCtta(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
