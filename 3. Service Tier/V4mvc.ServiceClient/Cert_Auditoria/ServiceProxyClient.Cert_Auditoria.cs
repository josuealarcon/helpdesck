using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLCert_Auditoria BL_Cert_Auditoria { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLCert_Auditoria BL_Cert_Auditoria)
		{
			this.BL_Cert_Auditoria = BL_Cert_Auditoria;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Cert_Auditoria> GetAllCert_AuditoriaCtta(string IDEMPRESA)
		{
			try
			{
				return this.BL_Cert_Auditoria.GetAll(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Cert_Auditoria GetOneCert_Auditoria(Int32 ID_CERT_AUDITORIA)
		{
			try
			{
				return this.BL_Cert_Auditoria.GetOne(ID_CERT_AUDITORIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean SaveCert_Auditoria(ref Cert_Auditoria Item)
		{
			try
			{
				return this.BL_Cert_Auditoria.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveCert_Auditoria(ref ObservableCollection<Cert_Auditoria> Items)
		{
			try
			{
				return this.BL_Cert_Auditoria.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
