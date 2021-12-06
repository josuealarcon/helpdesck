using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLLicencias
    {

        #region [ Consultas ]

        public ObservableCollection<Licencias> GetLicenciasConductores(string RUT)
        {
            try
            {
                return this.Repository.GetLicenciasConductores(RUT);
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

                return this.Repository.SaveWorkersLicenciasConductoresCtta(RUT, string.Join(",", licencias_conductores.Where(var => var.CHECKED).Select(var => var.LICENCIAS)));
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
