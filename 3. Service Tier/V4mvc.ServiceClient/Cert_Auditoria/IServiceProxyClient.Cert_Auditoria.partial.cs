using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Cert_Auditoria> GetAllLog_Cert_AuditoriaCtta(int ID_CERT_AUDITORIA);

		#endregion

		#region [ Métodos ]

		#endregion

	}
}