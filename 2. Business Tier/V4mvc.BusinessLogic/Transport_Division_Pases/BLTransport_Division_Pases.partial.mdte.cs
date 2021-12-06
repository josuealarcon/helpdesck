using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLTransport_Division_Pases
	{

        #region [ Consultas ]

        public ObservableCollection<Transport_Division_Pases> GetAllTransportDivPases_CertificacionMdte(string DIVCOD, string PATENTE, string TIPO)
        {
            try
            {
                return Repository.GetAllTransportDivPases_CertificacionMdte(DIVCOD, PATENTE, TIPO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
