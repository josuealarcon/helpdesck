using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAWorkerSubCategory : IDAWorkerSubCategory
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<WorkerSubCategory> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAWorkerSubCategory(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<WorkerSubCategory>();
			WorkerSubCategory item = new WorkerSubCategory();
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
