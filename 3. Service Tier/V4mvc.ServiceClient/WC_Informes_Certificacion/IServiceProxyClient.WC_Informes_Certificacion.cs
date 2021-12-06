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
		ObservableCollection<WC_Informes_Certificacion> GetAllWC_Informes_Certificacion();
		WC_Informes_Certificacion GetOneWC_Informes_Certificacion(Decimal CODMENU);
		#endregion

		#region [ Metodos ]
		#endregion

	}
}
