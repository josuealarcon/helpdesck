using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Fec_Workers
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Fec_Workers> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_Fec_Workers Item);
		Boolean Save(ref ObservableCollection<Docs_Fec_Workers> Items);
		#endregion
		
	}
}
