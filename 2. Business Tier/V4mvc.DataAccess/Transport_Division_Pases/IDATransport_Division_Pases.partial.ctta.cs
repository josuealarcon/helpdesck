using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATransport_Division_Pases
	{

        #region [ Consultas ]

        ObservableCollection<Transport_Division_Pases> GetTransportDivisionPasesAutorizados(string DIVCOD, string PATENTE);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
