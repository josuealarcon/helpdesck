using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]
		
		public CertDesautorizacionTransport GetOneCertDesautorizacion_CertificacionMdte(string PATENTE, string DIVCOD)
		{
			try
			{
				return this.BL_CertDesautorizacionTransport.GetOneCertDesautorizacion_CertificacionMdte(PATENTE, DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool SaveCertDesautorizacionTransport_CertificacionMdte(ref CertDesautorizacionTransport modelo)
		{
			try
			{
				return this.BL_CertDesautorizacionTransport.SaveCertDesautorizacionTransport_CertificacionMdte(ref modelo);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
