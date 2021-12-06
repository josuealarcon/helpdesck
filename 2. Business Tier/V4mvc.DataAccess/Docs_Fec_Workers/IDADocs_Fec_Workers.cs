using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Fec_Workers
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Fec_Workers> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Docs_Fec_Workers Item);
        bool SaveDocsFecWorkersFuncionario(ref Docs_Fec_Workers item);

        #endregion

    }
}
