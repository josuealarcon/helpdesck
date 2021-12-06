using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATalleresVeh
	{
		#region [ Consultas ]

		ObservableCollection<TalleresVeh> GetAll();

		TalleresVeh GetOne(Int32 IDTALLER);

		#endregion

		#region [ Metodos ]

		bool Save(ref TalleresVeh item);

		bool Delete(ref TalleresVeh item);

		#endregion
	}
}
