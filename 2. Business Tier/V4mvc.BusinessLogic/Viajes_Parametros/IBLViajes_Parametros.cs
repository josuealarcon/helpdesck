using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLViajes_Parametros
	{
		
		#region [ Consultas ]
		ObservableCollection<Viajes_Parametros> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Viajes_Parametros Item);
		Boolean Save(ref ObservableCollection<Viajes_Parametros> Items);
		#endregion
		
	}
}
