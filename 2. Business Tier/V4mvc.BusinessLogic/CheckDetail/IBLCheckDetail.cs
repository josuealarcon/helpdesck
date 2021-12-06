using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCheckDetail
	{
		#region [ Consultas ]

		ObservableCollection<CheckDetail> GetAll();

		CheckDetail GetOne(Int32 ID_CHECK);

		#endregion

		#region [ Metodos ]

		bool Save(ref CheckDetail item);

		bool Delete(ref CheckDetail item);

		bool Save(ref ObservableCollection<CheckDetail> items);

		#endregion
	}
}
