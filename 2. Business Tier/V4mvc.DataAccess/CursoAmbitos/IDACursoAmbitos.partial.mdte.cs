using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACursoAmbitos
	{
		#region [ Consultas ]
		ObservableCollection<CursoAmbitos> GetAllCursosAmbitos_Mdte();
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
