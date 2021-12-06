using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Workers_Rechazo
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Workers_Rechazo> GetAll();
		Docs_Workers_Rechazo GetOne(String RUT, Guid ID, Int32 ID_TIPO_RECHAZO);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_Workers_Rechazo Item);
		Boolean Save(ref ObservableCollection<Docs_Workers_Rechazo> Items);
		#endregion
		
	}
}
