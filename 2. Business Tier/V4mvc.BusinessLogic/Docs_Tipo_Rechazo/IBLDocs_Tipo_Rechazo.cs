using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Tipo_Rechazo
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Tipo_Rechazo> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_Tipo_Rechazo Item);
		Boolean Save(ref ObservableCollection<Docs_Tipo_Rechazo> Items);
		#endregion
		
	}
}
