using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTransport_Division_Pases
	{

		#region [ Consultas ]

		ObservableCollection<Transport_Division_Pases> GetAllTransportDivPases_CertificacionMdte(string DIVCOD, string PATENTE, string TIPO);

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
