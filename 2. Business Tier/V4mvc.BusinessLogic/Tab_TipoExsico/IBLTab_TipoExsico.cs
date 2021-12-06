using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTab_TipoExsico
	{

		#region [ Consultas ]

		ObservableCollection<Tab_TipoExsico> GetAll();
		Tab_TipoExsico GetOne(Decimal ID);

		#endregion

		#region [ Métodos ]

		Boolean Save(ref Tab_TipoExsico Item);
		Boolean Save(ref ObservableCollection<Tab_TipoExsico> Items);

		#endregion

	}
}
