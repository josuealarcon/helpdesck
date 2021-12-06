using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Workers_Data
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Workers_Data> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Docs_Workers_Data Item);
		#endregion
		
	}
}
