using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTab_TipoPase
	{

		#region [ Consultas ]
		ObservableCollection<Tab_TipoPase> GetAllTabTipoPase_PasesCtta();
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
