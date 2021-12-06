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
        Transport_Division GetTransport_DivisionAutorizada(string DIVCOD, string PATENTE);

        int VerificarVehiculoCtta(string PATENTE, string DIVCOD);
        #endregion

        #region [ Metodos ]

        bool ActivarPaseVehiculoCtta(string DIVCOD, string PATENTE, string IDEMPRESA);

        #endregion
    }
}
