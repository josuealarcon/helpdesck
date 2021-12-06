using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Manuales
	{
		#region [ Consultas ]

		ObservableCollection<Docs_Manuales> GetAll();
		Docs_Manuales GetOne(int ID_DOC);

		#endregion

		#region [ Metodos ]

		bool Save(ref Docs_Manuales item);
		bool Delete(ref Docs_Manuales item);

		#endregion
	}
}
