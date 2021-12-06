using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Workers_Data
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Workers_Data> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_Workers_Data Item);
		Boolean Save(ref ObservableCollection<Docs_Workers_Data> Items);
		#endregion
		
	}
}
