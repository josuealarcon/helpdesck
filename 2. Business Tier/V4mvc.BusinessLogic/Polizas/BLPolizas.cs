using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLPolizas : IBLPolizas
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public IDAArchivos RepositoryArchivos { get; set; }

		[Dependency]
		public IDAPolizas Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLPolizas(IDAPolizas x_container
		  , IDAArchivos x_container1)
		{ 
			Repository = x_container;
			RepositoryArchivos = x_container1;
		}
		#endregion
		
		#region [ Consultas ]

		#endregion
		
		#region [ Metodos ]

		#endregion
		
	}
}
