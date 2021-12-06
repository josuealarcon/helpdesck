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

		ObservableCollection<Area> GetAllAreas();

		Area GetOneArea(string AREA);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveArea(ref Area item);
		
		bool DeleteArea(ref Area item);
		
		bool SaveAreas(ref ObservableCollection<Area> items);
		
		#endregion

	}
}
