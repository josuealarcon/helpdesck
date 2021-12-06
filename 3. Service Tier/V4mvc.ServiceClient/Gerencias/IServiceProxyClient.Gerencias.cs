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

		ObservableCollection<Gerencias> GetAllGerencias();

		Gerencias GetOneGerencia(Int32 IDGERENCIA);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveGerencia(ref Gerencias item);
		
		bool DeleteGerencia(ref Gerencias item);
		
		bool SaveGerencias(ref ObservableCollection<Gerencias> items);
		
		#endregion

	}
}
