using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWC_Menu
	{
		
		#region [ Consultas ]
		ObservableCollection<WC_Menu> GetAll();

        WC_Menu GetOne(Decimal CODMENU);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref WC_Menu Item);
		#endregion
		
	}
}
