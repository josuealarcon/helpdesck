using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Disputa_Rechazo
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Disputa_Rechazo> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Docs_Disputa_Rechazo Item);
		#endregion
		
	}
}
