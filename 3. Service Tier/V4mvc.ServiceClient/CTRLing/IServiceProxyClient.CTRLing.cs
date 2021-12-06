using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		#region [ Consultas ]
		ObservableCollection<CTRLing> GetAllCTRLing(String DIVISIONES);
		CTRLing GetOneCTRLing();

		#endregion

		#region [ Metodos ]
		#endregion

	}
}
