using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Cert_Auditoria> GetAllCert_AuditoriaCtta(string IDEMPRESA);
		Cert_Auditoria GetOneCert_Auditoria(Int32 ID_CERT_AUDITORIA);

		#endregion

		#region [ Métodos ]

		Boolean SaveCert_Auditoria(ref Cert_Auditoria Item);
		Boolean SaveCert_Auditoria(ref ObservableCollection<Cert_Auditoria> Items);

		#endregion

	}
}