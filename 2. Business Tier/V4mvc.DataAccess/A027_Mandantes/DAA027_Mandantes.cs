using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAA027_Mandantes : IDAA027_Mandantes
	{

		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<A027_Mandantes> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }

		#endregion

		#region [ Constructores ]

		public DAA027_Mandantes(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<A027_Mandantes>();
			A027_Mandantes item = new A027_Mandantes();
			Loader.EntityType = item.GetType();
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
