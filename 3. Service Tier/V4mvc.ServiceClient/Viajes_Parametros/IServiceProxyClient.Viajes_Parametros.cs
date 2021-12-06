using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Viajes_Parametros> GetAllViajes_Parametros();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveViajes_Parametros(ref Viajes_Parametros Item);
		Boolean SaveViajes_Parametros(ref ObservableCollection<Viajes_Parametros> Items);
		#endregion
		
	}
}
