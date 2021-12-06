using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAEvaluacionesOficio
	{
		#region [ Consultas ]

		ObservableCollection<EvaluacionesOficio> GetAll(ref EvaluacionesOficio evaluacionesOficio);

		EvaluacionesOficio GetOne(Int32 IDCHARLA);

		#endregion

		#region [ Metodos ]

		bool Save(ref EvaluacionesOficio item);

		bool Delete(ref EvaluacionesOficio item);

		#endregion
	}
}
