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

		ObservableCollection<Charlas_Division> GetAllCharlas_Divisiones();

		Charlas_Division GetOneCharlas_Division(Int32 ID_CHARLA_DIVISION);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveCharlas_Division(ref Charlas_Division item);
		
		bool DeleteCharlas_Division(ref Charlas_Division item);
		
		bool SaveCharlas_Divisiones(ref ObservableCollection<Charlas_Division> items);
		
		#endregion

	}
}
