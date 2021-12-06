using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public Transport_Division GetOneTransportDivision_CertificacionMdte(string DIVCOD, string PATENTE)
        {
            try
            {
                return this.BL_Transport_Division.GetOneTransportDivision_CertificacionMdte(DIVCOD, PATENTE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]


        #endregion

    }
}
