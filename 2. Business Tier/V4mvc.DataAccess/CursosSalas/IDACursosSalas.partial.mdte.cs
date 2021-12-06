using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACursosSalas
	{

		#region [ Consultas ]
		ObservableCollection<CursosSalas> GetSalasMdteSearcherMdte(ref CursosSalas model);

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
