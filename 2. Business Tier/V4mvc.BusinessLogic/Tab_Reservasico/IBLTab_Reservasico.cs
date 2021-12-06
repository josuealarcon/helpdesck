using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTab_Reservasico
	{

		#region [ Consultas ]
		ObservableCollection<Tab_Reservasico> GetAll();
		Tab_Reservasico GetOne(Decimal ID);
		#endregion

		#region [ Metodos ]
		Boolean Save(ref Tab_Reservasico Item);
		Boolean Save(ref ObservableCollection<Tab_Reservasico> Items);
		#endregion

	}
}