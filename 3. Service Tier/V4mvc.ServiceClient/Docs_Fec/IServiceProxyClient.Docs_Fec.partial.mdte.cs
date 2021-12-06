using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Docs_Fec> GetListFechasDocumentos_Mdte();
		ObservableCollection<Docs_Fec> GetAllDocsFecSelect_mdte();
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
