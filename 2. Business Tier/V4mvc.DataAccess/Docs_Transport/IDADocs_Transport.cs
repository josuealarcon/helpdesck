using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Transport
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Transport> GetAll();
		Docs_Transport GetOne(Int32 ID_DOCS_VEH);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Docs_Transport Item);
		#endregion
		
	}
}
