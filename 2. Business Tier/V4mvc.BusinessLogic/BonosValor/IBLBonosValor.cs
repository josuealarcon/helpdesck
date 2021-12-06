using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLBonosValor
	{

		#region [ Consultas ]
		ObservableCollection<BonosValor> GetAll();
		#endregion

		#region [ Metodos ]
		Boolean Save(ref BonosValor Item);
		Boolean Save(ref ObservableCollection<BonosValor> Items);
		#endregion

	}
}