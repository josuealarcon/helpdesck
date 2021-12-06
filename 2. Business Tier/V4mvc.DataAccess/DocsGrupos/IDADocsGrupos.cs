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

		ObservableCollection<DocsGrupos> GetAll();

		DocsGrupos GetOne(Int32 ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref DocsGrupos item);

		bool Delete(ref DocsGrupos item);

		#endregion
	}
}
