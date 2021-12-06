using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLA027_Mandantes : IBLA027_Mandantes
	{

		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAA027_Mandantes Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLA027_Mandantes(IDAA027_Mandantes x_container)
		{ Repository = x_container; }

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
