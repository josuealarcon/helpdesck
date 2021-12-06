using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWC_Menu
	{
		
		#region [ Consultas ]
		ObservableCollection<WC_Menu> GetAll();
        WC_Menu GetOne(Decimal CODMENU);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref WC_Menu Item);
		Boolean Save(ref ObservableCollection<WC_Menu> Items);
		#endregion
		
	}
}
