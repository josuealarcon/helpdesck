using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCertDesautorizacionTransport
	{
		#region [ Consultas ]
		CertDesautorizacionTransport GetOneCertDesautorizacion_CertificacionMdte(string PATENTE, string DIVCOD);

		#endregion

		#region [ Metodos ]

		bool SaveCertDesautorizacionTransport_CertificacionMdte(ref CertDesautorizacionTransport modelo);

		#endregion
	}
}
