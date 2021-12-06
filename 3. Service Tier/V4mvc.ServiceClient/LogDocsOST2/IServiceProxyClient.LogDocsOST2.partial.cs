
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

		#region [ Consultas ]

		ObservableCollection<LogDocsOST2> GetAllLogDocsOST2_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, int ID_DOC);
		ObservableCollection<LogDocsOST2> GetInformeContratosCArranqueHistorialCtta(ref LogDocsOST2 model);

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
	