using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLCertDesautorizacionTransport BL_CertDesautorizacionTransport { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLCertDesautorizacionTransport BL_CertDesautorizacionTransport)
		{
			this.BL_CertDesautorizacionTransport = BL_CertDesautorizacionTransport;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CertDesautorizacionTransport> GetAllCertDesautorizacionTransports()
		{
			try
			{
				return this.BL_CertDesautorizacionTransport.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CertDesautorizacionTransport GetOneCertDesautorizacionTransport(string PATENTE)
		{
			try
			{
				return this.BL_CertDesautorizacionTransport.GetOne(PATENTE);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveCertDesautorizacionTransport(ref CertDesautorizacionTransport item)
		{
			try
			{
				return this.BL_CertDesautorizacionTransport.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCertDesautorizacionTransport(ref CertDesautorizacionTransport item)
		{
			try
			{
				return this.BL_CertDesautorizacionTransport.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCertDesautorizacionTransports(ref ObservableCollection<CertDesautorizacionTransport> items)
		{
			try
			{
				return this.BL_CertDesautorizacionTransport.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
