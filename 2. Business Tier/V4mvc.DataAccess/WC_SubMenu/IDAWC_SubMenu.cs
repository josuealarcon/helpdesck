using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWC_SubMenu
	{
		
		#region [ Consultas ]
		ObservableCollection<WC_SubMenu> GetAll();

        WC_SubMenu GetOne(Decimal CODSUBMENU);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref WC_SubMenu Item);
		#endregion
		
	}
}
