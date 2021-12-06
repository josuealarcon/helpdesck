using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Tab_TipoExsico> GetAllTab_TipoExsico();
		Tab_TipoExsico GetOneTab_TipoExsico(Decimal ID);

        #endregion

        #region [ Métodos ]

        Boolean SaveTab_TipoExsico(ref Tab_TipoExsico Item);
		Boolean SaveTab_TipoExsico(ref ObservableCollection<Tab_TipoExsico> Items);

        #endregion

    }
}
