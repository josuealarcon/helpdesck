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
		ObservableCollection<WC_SubMenu> GetAllWC_SubMenu();
        WC_SubMenu GetOneWC_SubMenu(Decimal CODSUBMENU);
        #endregion

        #region [ Metodos ]
        Boolean SaveWC_SubMenu(ref WC_SubMenu Item);
		Boolean SaveWC_SubMenu(ref ObservableCollection<WC_SubMenu> Items);
		#endregion
		
	}
}
