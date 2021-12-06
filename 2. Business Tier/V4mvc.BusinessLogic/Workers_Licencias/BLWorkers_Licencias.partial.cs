using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLWorkers_Licencias
	{

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        public bool SaveWorkersLicenciasConductoresCtta(string RUT, ObservableCollection<Licencias> licencias_conductores, string ESCOLTA, string LICCONDUC)
        {
            try
            {
                bool result = false;
                string CLASE = "";
                result = this.Repository.DeleteWorkersLicenciasConductoresCtta(RUT);
                foreach (var item in licencias_conductores)
                {
                    if (item.CHECKED)
                    {
                        result = this.Repository.SaveWorkersLicenciasConductoresCtta(RUT, item.LICENCIAS);
                        if (CLASE == "")
                            CLASE = item.LICENCIAS;
                        else
                            CLASE = CLASE + " | " + item.LICENCIAS;
                    }

                }
                this.RepositoryWorkers.UpdateWorkersConductores_Ctta(RUT, CLASE, ESCOLTA, LICCONDUC);

                return result;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
