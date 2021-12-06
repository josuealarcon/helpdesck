using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DATurno_Disputa : IDATurno_Disputa
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Turno_Disputa> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DATurno_Disputa(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Turno_Disputa>();
			Turno_Disputa item = new Turno_Disputa();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		

		public ObservableCollection<Turno_Disputa> GetAll()
		{
			throw new NotImplementedException();
		}

		public Turno_Disputa GetOne(int ID_DISPUTA)
		{ 
			throw new NotImplementedException(); 
		}

		#endregion



		#region [ Metodos ]

		#endregion
	}
}
