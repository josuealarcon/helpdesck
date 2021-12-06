using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Workerscasino> GetAllWorkerscasinos();

		Workerscasino GetOneWorkerscasino(string RUT);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveWorkerscasino(ref Workerscasino item);
		
		bool DeleteWorkerscasino(ref Workerscasino item);
		
		bool SaveWorkerscasinos(ref ObservableCollection<Workerscasino> items);
		
		#endregion

	}
}
