using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Disputa_Trans
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Disputa_Trans> GetAll();
		Docs_Disputa_Trans GetOne(Int32 ID_DISPUTA);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_Disputa_Trans Item);
		Boolean Save(ref ObservableCollection<Docs_Disputa_Trans> Items);
		#endregion
		
	}
}
