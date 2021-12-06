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

		ObservableCollection<AAQ_Regimen> GetListAAQ_Regimens_Mdte();

		AAQ_Regimen GetOneAAQ_Regimen(Int32 IDREGIMEN);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveAAQ_Regimen(ref AAQ_Regimen item);
		
		bool DeleteAAQ_Regimen(ref AAQ_Regimen item);
		
		bool SaveAAQ_Regimens(ref ObservableCollection<AAQ_Regimen> items);
		
		#endregion

	}
}
