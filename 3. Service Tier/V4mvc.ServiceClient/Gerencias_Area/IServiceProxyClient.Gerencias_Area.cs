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

		ObservableCollection<Gerencias_Area> GetAllGerencias_Areas();

		Gerencias_Area GetOneGerencias_Area(decimal IDAREA);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveGerencias_Area(ref Gerencias_Area item);
		
		bool DeleteGerencias_Area(ref Gerencias_Area item);
		
		bool SaveGerencias_Areas(ref ObservableCollection<Gerencias_Area> items);
		
		#endregion

	}
}
