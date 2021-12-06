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

		ObservableCollection<TalleresVeh> GetAllTalleresVehs();

		TalleresVeh GetOneTalleresVeh(Int32 IDTALLER);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveTalleresVeh(ref TalleresVeh item);
		
		bool DeleteTalleresVeh(ref TalleresVeh item);
		
		bool SaveTalleresVehs(ref ObservableCollection<TalleresVeh> items);
		
		#endregion

	}
}
