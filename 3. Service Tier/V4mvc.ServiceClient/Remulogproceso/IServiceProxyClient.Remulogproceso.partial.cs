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
		ObservableCollection<Remulogproceso> Get_Remulogproceso_InformeDocumentosCargadosDetalle_InformeControlLaboralCtta(Remulogproceso Item);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
