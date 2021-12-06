using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		ObservableCollection<BonosValor> GetAllBonosValor();
		#endregion

		#region [ Metodos ]
		Boolean SaveBonosValor(ref BonosValor Item);
		Boolean SaveBonosValor(ref ObservableCollection<BonosValor> Items);
		#endregion

	}
}
