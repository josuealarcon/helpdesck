using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocumentosContratistas
	{
		#region [ Consultas ]

		ObservableCollection<DocumentosContratistas> GetAll(ref DocumentosContratistas documentosContratistas);

		DocumentosContratistas GetOne(Int32 IDCTTA_DOC);

		#endregion

		#region [ Metodos ]

		bool Save(ref DocumentosContratistas item);

		bool Delete(ref DocumentosContratistas item);

		#endregion
	}
}
