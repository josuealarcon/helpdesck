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
		ObservableCollection<WC_Menu> GetAllWC_Menu();
        WC_Menu GetOneWC_Menu(Decimal CODMENU);
        #endregion

        #region [ Metodos ]
        Boolean SaveWC_Menu(ref WC_Menu Item);
		Boolean SaveWC_Menu(ref ObservableCollection<WC_Menu> Items);
		#endregion
		
	}
}
