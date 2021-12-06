using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCert_Auditoria
	{

		#region [ Consultas ]

		public ObservableCollection<Cert_Auditoria> GetAllLog_Cert_AuditoriaCtta(int ID_CERT_AUDITORIA)
		{
			try
			{
				return this.Repository.GetAllLog_Cert_AuditoriaCtta(ID_CERT_AUDITORIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		#endregion

	}
}