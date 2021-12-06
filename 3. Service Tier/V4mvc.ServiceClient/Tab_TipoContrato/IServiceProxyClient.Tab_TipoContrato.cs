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
		ObservableCollection<Tab_TipoContrato> GetAllTab_TipoContrato();
        Tab_TipoContrato GetOneTab_TipoContrato(int ID_TIPOCONTRATO);
        #endregion

        #region [ Metodos ]
        Boolean SaveTab_TipoContrato(ref Tab_TipoContrato Item);
		Boolean SaveTab_TipoContrato(ref ObservableCollection<Tab_TipoContrato> Items);
		#endregion
		
	}
}
