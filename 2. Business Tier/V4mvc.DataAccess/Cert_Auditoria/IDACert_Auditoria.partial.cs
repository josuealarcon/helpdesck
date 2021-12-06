using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACert_Auditoria
	{

		#region [ Consultas ]

		ObservableCollection<Cert_Auditoria> GetAllLog_Cert_AuditoriaCtta(int ID_CERT_AUDITORIA);

		#endregion

		#region [ Métodos ]

		#endregion

	}
}