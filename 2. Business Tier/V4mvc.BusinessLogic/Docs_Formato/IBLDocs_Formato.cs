using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Formato
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Formato> GetAll();
        Docs_Formato GetOne(int ID_DOC_EXT);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Docs_Formato Item);
		Boolean Save(ref ObservableCollection<Docs_Formato> Items);
		#endregion
		
	}
}
