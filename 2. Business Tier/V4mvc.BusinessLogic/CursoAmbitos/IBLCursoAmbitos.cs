using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCursoAmbitos
	{
		#region [ Consultas ]

		ObservableCollection<CursoAmbitos> GetAll();

		CursoAmbitos GetOne(Int32 ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref CursoAmbitos item);

		bool Delete(ref CursoAmbitos item);

		bool Save(ref ObservableCollection<CursoAmbitos> items);

		#endregion
	}
}
