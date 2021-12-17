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

		ObservableCollection<Solicitud> GetAllSolicituds();

		Solicitud GetOneSolicitud(Int32 ID_SOLICITUD);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveSolicitud(ref Solicitud item);
		
		bool DeleteSolicitud(ref Solicitud item);
		
		bool SaveSolicituds(ref ObservableCollection<Solicitud> items);
		
		#endregion

	}
}
