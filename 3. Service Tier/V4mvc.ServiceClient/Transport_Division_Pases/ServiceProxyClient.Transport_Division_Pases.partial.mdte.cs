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
		
		public ObservableCollection<Transport_Division_Pases> GetAllTransportDivPases_CertificacionMdte(string DIVCOD, string PATENTE, string TIPO)
		{
			try
			{
				return this.BL_Transport_Division_Pases.GetAllTransportDivPases_CertificacionMdte(DIVCOD, PATENTE, TIPO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
