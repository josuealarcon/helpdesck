using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkerscasino
	{
		#region [ Consultas ]

		ObservableCollection<Workerscasino> GetAll();

		Workerscasino GetOne(string RUT);

		#endregion

		#region [ Metodos ]

		bool Save(ref Workerscasino item);

		bool Delete(ref Workerscasino item);

		bool Save(ref ObservableCollection<Workerscasino> items);

		#endregion
	}
}
