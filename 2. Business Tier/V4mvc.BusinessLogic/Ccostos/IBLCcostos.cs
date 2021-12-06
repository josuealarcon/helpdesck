using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCcostos
	{

		#region [ Consultas ]

		ObservableCollection<Ccostos> GetAll();
		Ccostos GetOne(string EMPRESA, string CCOSTO);

		#endregion

		#region [ Métodos ]

		Boolean Save(ref Ccostos Item);
		Boolean Save(ref ObservableCollection<Ccostos> Items);

		#endregion

	}
}
