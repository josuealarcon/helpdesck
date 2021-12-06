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

		#endregion

		#region [ Metodos ]
		public bool SaveWorkersLicenciasConductoresFuncionariosCtta(string RUT, ObservableCollection<Licencias> licencias_conductores, string ESCOLTA, string LICCONDUC)
		{
			try
			{
				return this.BL_Workers_Licencias.SaveWorkersLicenciasConductoresCtta(RUT, licencias_conductores, ESCOLTA, LICCONDUC);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
