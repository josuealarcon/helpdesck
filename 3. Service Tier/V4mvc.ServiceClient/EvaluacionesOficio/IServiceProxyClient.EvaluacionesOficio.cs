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

		ObservableCollection<EvaluacionesOficio> GetAllEvaluacionesOficio(ref EvaluacionesOficio evaluacionesOficio);

		EvaluacionesOficio GetOneEvaluacionOficio(Int32 IDCHARLA);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveEvaluacionOficio(ref EvaluacionesOficio item);
		
		bool DeleteEvaluacionOficio(ref EvaluacionesOficio item);
		
		bool SaveEvaluacionesOficio(ref ObservableCollection<EvaluacionesOficio> items);
		
		#endregion

	}
}
