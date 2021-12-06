using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_TipoPase
	{
		
		#region [ Consultas ]
		ObservableCollection<Tab_TipoPase> GetAll();
		Tab_TipoPase GetOne(Int16 ID_TIPOPASE);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Tab_TipoPase Item);
		#endregion
		
	}
}
