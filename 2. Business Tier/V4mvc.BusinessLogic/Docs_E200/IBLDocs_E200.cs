using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_E200
	{
		#region [ Consultas ]

		ObservableCollection<Docs_E200> GetAll();

		Docs_E200 GetOne(Guid ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref Docs_E200 item);

		bool Delete(ref Docs_E200 item);

		bool Save(ref ObservableCollection<Docs_E200> items);

		#endregion
	}
}
