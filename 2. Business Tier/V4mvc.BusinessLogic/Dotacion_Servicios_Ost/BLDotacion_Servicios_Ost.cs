using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.Entities;
using V4mvc.DataAccess;

namespace V4mvc.BusinessLogic
{
	public partial class BLDotacion_Servicios_Ost : IBLDotacion_Servicios_Ost
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDADotacion_Servicios_Ost Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLDotacion_Servicios_Ost(IDADotacion_Servicios_Ost x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
