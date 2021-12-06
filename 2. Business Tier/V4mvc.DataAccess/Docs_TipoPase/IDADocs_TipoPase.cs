using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_TipoPase
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_TipoPase> GetAll();
        Docs_TipoPase GetOne();
        #endregion

        #region [ Metodos ]
        bool Save(ref Docs_TipoPase Item);
		#endregion
		
	}
}
