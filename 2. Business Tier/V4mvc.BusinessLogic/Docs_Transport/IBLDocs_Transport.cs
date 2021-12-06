using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Transport
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Transport> GetAll();
		Docs_Transport GetOne(Int32 ID_DOCS_VEH);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_Transport Item);
		Boolean Save(ref ObservableCollection<Docs_Transport> Items);
		#endregion
		
	}
}
