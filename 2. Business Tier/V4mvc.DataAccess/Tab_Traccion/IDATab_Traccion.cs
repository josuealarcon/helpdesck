using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_Traccion
	{
		
		#region [ Consultas ]
		ObservableCollection<Tab_Traccion> GetAll();
		Tab_Traccion GetOne(Int32 IDTRACCION);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Tab_Traccion Item);
		#endregion
		
	}
}
