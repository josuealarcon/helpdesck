using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAWorkerCategory : IDAWorkerCategory
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<WorkerCategory> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAWorkerCategory(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<WorkerCategory>();
			WorkerCategory item = new WorkerCategory();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
