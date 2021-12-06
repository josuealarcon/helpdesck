using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACharlas_Division
	{
		#region [ Consultas ]

		ObservableCollection<Charlas_Division> GetAll();

		Charlas_Division GetOne(Int32 ID_CHARLA_DIVISION);

		#endregion

		#region [ Metodos ]

		bool Save(ref Charlas_Division item);

		bool Delete(ref Charlas_Division item);

		#endregion
	}
}
