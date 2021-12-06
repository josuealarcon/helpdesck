
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_OST2
    {

		#region [ Consultas ]

		public ObservableCollection<Docs_OST2> GetInformeContratosCArranqueDocsOst2Ctta(ref Docs_OST2 model)
		{
			try
			{
				return this.Repository.GetInformeContratosCArranqueDocsOst2Ctta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
	