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

        public Transport_Division GetDocumentacionPasesVehiculosCtta(string DIVCOD, string PATENTE, string IDEMPRESA)
        {
            try
            {
                return this.BL_Transport_Division.GetDocumentacionPasesVehiculosCtta(DIVCOD, PATENTE, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool ActivarPaseVehiculoCtta(string DIVCOD, string PATENTE, string IDEMPRESA)
        {
            try
            {
                return this.BL_Transport_Division.ActivarPaseVehiculoCtta(DIVCOD, PATENTE, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
