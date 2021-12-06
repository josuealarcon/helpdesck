using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Transport_Rechazo
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Transport_Rechazo> GetAll();
		Docs_Transport_Rechazo GetOne(String PATENTE, Guid ID, Int32 ID_TIPO_RECHAZO);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Docs_Transport_Rechazo Item);
		#endregion
		
	}
}
