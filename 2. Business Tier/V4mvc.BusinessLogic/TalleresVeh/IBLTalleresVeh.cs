using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTalleresVeh
	{
		#region [ Consultas ]

		ObservableCollection<TalleresVeh> GetAll();

		TalleresVeh GetOne(Int32 IDTALLER);

		#endregion

		#region [ Metodos ]

		bool Save(ref TalleresVeh item);

		bool Delete(ref TalleresVeh item);

		bool Save(ref ObservableCollection<TalleresVeh> items);

		#endregion
	}
}
