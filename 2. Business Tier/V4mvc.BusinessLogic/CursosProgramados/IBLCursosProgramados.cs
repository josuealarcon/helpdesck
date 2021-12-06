using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCursosProgramados
	{
		#region [ Consultas ]

		ObservableCollection<CursosProgramados> GetAll(ref CursosProgramados cursosProgramados);

		CursosProgramados GetOne(Int32 CODIGO);

		#endregion

		#region [ Metodos ]

		bool Save(ref CursosProgramados item);

		bool Delete(ref CursosProgramados item);

		bool Save(ref ObservableCollection<CursosProgramados> items);

		#endregion
	}
}
