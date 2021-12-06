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

		ObservableCollection<A025Area> GetAllA025Areas();

		A025Area GetOneA025Area(Int32 ID_AREA);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveA025Area(ref A025Area item);
		
		bool DeleteA025Area(ref A025Area item);
		
		bool SaveA025Areas(ref ObservableCollection<A025Area> items);
		
		#endregion

	}
}
