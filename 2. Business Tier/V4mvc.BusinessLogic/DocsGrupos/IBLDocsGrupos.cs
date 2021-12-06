using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocsGrupos
	{
		#region [ Consultas ]

		ObservableCollection<DocsGrupos> GetAll();

		DocsGrupos GetOne(Int32 ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref DocsGrupos item);

		bool Delete(ref DocsGrupos item);

		bool Save(ref ObservableCollection<DocsGrupos> items);

		#endregion
	}
}
