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
		public ObservableCollection<Remulogproceso> Get_Remulogproceso_InformeDocumentosCargadosDetalle_InformeControlLaboralCtta(Remulogproceso Item)
		{
			try
			{
				return this.BL_Remulogproceso.Get_Remulogproceso_InformeDocumentosCargadosDetalle_InformeControlLaboralCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}	
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
