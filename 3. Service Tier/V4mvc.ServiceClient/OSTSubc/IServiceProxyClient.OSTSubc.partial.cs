
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]
		ObservableCollection<OSTSubc> GetAllOSTSubC_ContratOSTCtta(string IDEMPRESA);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
	