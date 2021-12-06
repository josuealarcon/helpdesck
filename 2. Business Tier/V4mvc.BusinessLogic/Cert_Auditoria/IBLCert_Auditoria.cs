using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCert_Auditoria
	{

		#region [ Consultas ]

		ObservableCollection<Cert_Auditoria> GetAll(string IDEMPRESA);
		Cert_Auditoria GetOne(Int32 ID_CERT_AUDITORIA);

		#endregion

		#region [ Métodos ]

		Boolean Save(ref Cert_Auditoria Item);
		Boolean Save(ref ObservableCollection<Cert_Auditoria> Items);

		#endregion

	}
}
