using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocsGrupos
	{
		#region [ Consultas ]
		ObservableCollection<DocsGrupos> GetAllByDivision(string DIVISION);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
