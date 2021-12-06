using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_TipoExsico
	{

		#region [ Consultas ]

		ObservableCollection<Tab_TipoExsico> GetAll();
		Tab_TipoExsico GetOne(Decimal ID);

		#endregion

		#region [ Métodos ]

		bool Save(ref Tab_TipoExsico Item);

		#endregion

	}
}
