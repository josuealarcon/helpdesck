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

        Transport_Division GetDocumentacionPasesVehiculosCtta(string DIVCOD, string PATENTE, string IDEMPRESA);

        #endregion

        #region [ Metodos ]

        bool ActivarPaseVehiculoCtta(string DIVCOD, string PATENTE, string IDEMPRESA);

        #endregion

    }
}
