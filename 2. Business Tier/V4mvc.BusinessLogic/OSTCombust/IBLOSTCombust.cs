using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLOSTCombust
	{

		#region [ Consultas ]

		ObservableCollection<OSTCombust> GetAll();
		OSTCombust GetOne(string NROOST);

		#endregion

		#region [ Metodos ]

		bool Save(ref OSTCombust item);
		bool Save(ref ObservableCollection<OSTCombust> items);

		#endregion

	}
}
