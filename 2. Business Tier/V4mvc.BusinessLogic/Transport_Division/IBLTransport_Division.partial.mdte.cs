using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTransport_Division
	{

        #region [ Consultas ]

        Transport_Division GetOneTransportDivision_CertificacionMdte(string DIVCOD, string PATENTE);

        #endregion

        #region [ Metodos ]


        #endregion

    }
}
