using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		ObservableCollection<Informes_Certificacion> GetAllInformes_Certificacion(String DIVCOD);
		Informes_Certificacion GetOneInformes_Certificacion();

		#endregion

		#region [ Metodos ]
		#endregion

	}
}
