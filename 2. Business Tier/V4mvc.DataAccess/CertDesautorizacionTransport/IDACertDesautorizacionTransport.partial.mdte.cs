using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACertDesautorizacionTransport
	{
		#region [ Consultas ]

		CertDesautorizacionTransport GetOneCertDesautorizacion_CertificacionMdte(string PATENTE, string DIVCOD);

		#endregion

		#region [ Metodos ]

		bool SaveCertDesautorizacionTransport_CertificacionMdte(ref CertDesautorizacionTransport modelo);

		#endregion
	}
}
