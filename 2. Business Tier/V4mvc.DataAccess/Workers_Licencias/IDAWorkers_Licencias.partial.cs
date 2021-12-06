using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkers_Licencias
	{

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		bool DeleteWorkersLicenciasConductoresCtta(string RUT);
		bool SaveWorkersLicenciasConductoresCtta(string RUT, string licencias);

		#endregion
	}
}
