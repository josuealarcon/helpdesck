
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]

		ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_ContratOSTCtta(string NROOST);

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
	