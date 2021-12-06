using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACert_Auditoria
	{

		#region [ Consultas ]

		ObservableCollection<Cert_Auditoria> GetAll(string IDEMPRESA);
		Cert_Auditoria GetOne(Int32 ID_CERT_AUDITORIA);

		#endregion

		#region [ Métodos ]

		bool Save(ref Cert_Auditoria Item);

		#endregion

	}
}