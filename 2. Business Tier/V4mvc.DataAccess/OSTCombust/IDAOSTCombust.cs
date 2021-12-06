using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAOSTCombust
	{
		#region [ Consultas ]

		ObservableCollection<OSTCombust> GetAll();
		OSTCombust GetOne(string NROOST);

		#endregion

		#region [ Metodos ]

		bool Save(ref OSTCombust item);

		#endregion

	}
}
