using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCharlas_Division
	{
		#region [ Consultas ]

		ObservableCollection<Charlas_Division> GetAll();

		Charlas_Division GetOne(Int32 ID_CHARLA_DIVISION);

		#endregion

		#region [ Metodos ]

		bool Save(ref Charlas_Division item);

		bool Delete(ref Charlas_Division item);

		bool Save(ref ObservableCollection<Charlas_Division> items);

		#endregion
	}
}
