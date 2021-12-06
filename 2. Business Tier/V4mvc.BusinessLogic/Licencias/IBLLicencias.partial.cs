using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLicencias
	{

        #region [ Consultas ]

        ObservableCollection<Licencias> GetLicenciasConductores(string RUT);

        #endregion

        #region [ Metodos ]

        bool SaveWorkersLicenciasConductoresCtta(string RUT, ObservableCollection<Licencias> licencias_conductores);

        #endregion

    }
}
