using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Formato
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Formato> GetAll();
        Docs_Formato GetOne(int ID_DOC_EXT);
        #endregion

        #region [ Metodos ]
        bool Save(ref Docs_Formato Item);
		#endregion
		
	}
}
