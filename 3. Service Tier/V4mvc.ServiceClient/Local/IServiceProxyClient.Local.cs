using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{		
		#region [ Consultas ]
		ObservableCollection<Local> GetAllLocal();
		Local GetOneLocal(String LOCAL, String EMPRESAL, String LOCALL);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveLocal(ref Local Item);
		Boolean SaveLocal(ref ObservableCollection<Local> Items);
		#endregion
		
	}
}
