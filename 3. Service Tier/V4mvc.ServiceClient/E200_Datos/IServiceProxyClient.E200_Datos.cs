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

		ObservableCollection<E200_Datos> GetAllE200_Datos();

		E200_Datos GetOneE200_Dato(Guid? ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveE200_Dato(ref E200_Datos item);
		
		bool DeleteE200_Dato(ref E200_Datos item);
		
		bool SaveE200_Datos(ref ObservableCollection<E200_Datos> items);
		
		#endregion

	}
}
