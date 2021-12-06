using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_Reservasico
	{

		#region [ Consultas ]
		ObservableCollection<Tab_Reservasico> GetAll();
		Tab_Reservasico GetOne(Decimal ID);
		#endregion

		#region [ Metodos ]
		bool Save(ref Tab_Reservasico Item);
		#endregion

	}
}
