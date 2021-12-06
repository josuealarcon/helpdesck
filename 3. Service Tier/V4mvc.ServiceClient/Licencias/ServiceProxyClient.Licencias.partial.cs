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

        public ObservableCollection<Licencias> GetLicenciasConductores(string RUT)
        {
            try
            {
                return this.BL_Licencias.GetLicenciasConductores(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveWorkersLicenciasConductoresCtta(string RUT, ObservableCollection<Licencias> licencias_conductores)
        {
            try
            {
                return this.BL_Licencias.SaveWorkersLicenciasConductoresCtta(RUT,licencias_conductores);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
