using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATransport_Division
	{

        #region [ Consultas ]

        Transport_Division GetOneTransportDivision_CertificacionMdte(string DIVCOD, string PATENTE);

        #endregion

        #region [ Metodos ]


        #endregion
    }
}
