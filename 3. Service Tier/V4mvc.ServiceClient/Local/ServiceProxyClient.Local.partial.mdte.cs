using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;
namespace V4mvc
{
	public partial class ServiceProxyClient
	{
		
		#region [ Consultas ]
		public ObservableCollection<Local> GetAllLocal_PasesMdte(string DIVCOD)
		{
			try
			{
				return this.BL_Local.GetAllLocal_PasesMdte(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
