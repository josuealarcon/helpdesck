using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_TipoPase_Division
	{
		
		#region [ Consultas ]
		ObservableCollection<Tab_TipoPase_Division> GetAll();
		Tab_TipoPase_Division GetOne(String TIPOPASE, String DIVISION);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Tab_TipoPase_Division Item);
		#endregion
		
	}
}
