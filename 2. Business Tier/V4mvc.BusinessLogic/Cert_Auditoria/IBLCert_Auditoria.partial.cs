using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCert_Auditoria
	{

		#region [ Consultas ]

		ObservableCollection<Cert_Auditoria> GetAllLog_Cert_AuditoriaCtta(int ID_CERT_AUDITORIA);

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
