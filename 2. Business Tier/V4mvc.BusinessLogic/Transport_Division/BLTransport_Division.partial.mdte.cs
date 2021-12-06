using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLTransport_Division
    {

        #region [ Consultas ]

        public Transport_Division GetOneTransportDivision_CertificacionMdte(string DIVCOD, string PATENTE)
        {
            try
            {
                return Repository.GetOneTransportDivision_CertificacionMdte(DIVCOD, PATENTE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]


        #endregion
    }
}
