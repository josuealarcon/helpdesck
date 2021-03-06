using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWC_SubMenu
	{
		
		#region [ Consultas ]
		ObservableCollection<WC_SubMenu> GetAll();
        WC_SubMenu GetOne(Decimal CODSUBMENU);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref WC_SubMenu Item);
		Boolean Save(ref ObservableCollection<WC_SubMenu> Items);
		#endregion
		
	}
}
