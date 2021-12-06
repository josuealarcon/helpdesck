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
	public partial class BLTipo_Sector : IBLTipo_Sector
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDATipo_Sector Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLTipo_Sector(IDATipo_Sector x_container)
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
