using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Disputa_Trans
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Disputa_Trans> GetAll();
		Docs_Disputa_Trans GetOne(Int32 ID_DISPUTA);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Docs_Disputa_Trans Item);
		#endregion
		
	}
}
