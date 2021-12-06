using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DADotacion_Servicios_Ost : IDADotacion_Servicios_Ost
	{

		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Dotacion_Servicios_Ost> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DADotacion_Servicios_Ost(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Dotacion_Servicios_Ost>();
			var item = new Dotacion_Servicios_Ost();
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
