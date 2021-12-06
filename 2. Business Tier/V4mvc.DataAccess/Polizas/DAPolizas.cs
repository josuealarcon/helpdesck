using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;
namespace V4mvc.DataAccess
{
	public partial class DAPolizas : IDAPolizas
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Polizas> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAPolizas(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Polizas>();
			Polizas item = new Polizas();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
	
		#endregion

		#region [ Metodos ]
		
		#endregion
	}
}
