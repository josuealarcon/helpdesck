using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<CertDesautorizacionTransport> GetAllCertDesautorizacionTransports();

		CertDesautorizacionTransport GetOneCertDesautorizacionTransport(string PATENTE);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveCertDesautorizacionTransport(ref CertDesautorizacionTransport item);
		
		bool DeleteCertDesautorizacionTransport(ref CertDesautorizacionTransport item);
		
		bool SaveCertDesautorizacionTransports(ref ObservableCollection<CertDesautorizacionTransport> items);
		
		#endregion

	}
}
