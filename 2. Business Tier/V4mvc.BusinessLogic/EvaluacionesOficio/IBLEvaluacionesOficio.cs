using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLEvaluacionesOficio
	{
		#region [ Consultas ]

		ObservableCollection<EvaluacionesOficio> GetAll(ref EvaluacionesOficio evaluacionesOficio);

		EvaluacionesOficio GetOne(Int32 IDCHARLA);

		#endregion

		#region [ Metodos ]

		bool Save(ref EvaluacionesOficio item);

		bool Delete(ref EvaluacionesOficio item);

		bool Save(ref ObservableCollection<EvaluacionesOficio> items);

		#endregion
	}
}
