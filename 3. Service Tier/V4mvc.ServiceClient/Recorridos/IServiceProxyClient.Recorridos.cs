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

		ObservableCollection<Recorridos> GetAllRecorridos();

		Recorridos GetOneRecorrido(Int32 IDRECORRIDO);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveRecorrido(ref Recorridos item);
		
		bool DeleteRecorrido(ref Recorridos item);
		
		bool SaveRecorridos(ref ObservableCollection<Recorridos> items);
		
		#endregion

	}
}
