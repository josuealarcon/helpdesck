using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Transport_Rechazo
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Transport_Rechazo> GetAll();
		Docs_Transport_Rechazo GetOne(String PATENTE, Guid ID, Int32 ID_TIPO_RECHAZO);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_Transport_Rechazo Item);
		Boolean Save(ref ObservableCollection<Docs_Transport_Rechazo> Items);
		#endregion
		
	}
}
