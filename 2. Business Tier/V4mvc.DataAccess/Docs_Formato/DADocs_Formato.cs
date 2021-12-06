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
	public partial class DADocs_Formato : IDADocs_Formato
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Docs_Formato> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DADocs_Formato(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Docs_Formato>();
			Docs_Formato item = new Docs_Formato();
			Loader.EntityType = item.GetType();
            Instance = container;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_Formato> GetAll()
		{
			try
			{
				ObservableCollection<Docs_Formato> items = new ObservableCollection<Docs_Formato>();
				Docs_Formato item = new Docs_Formato();
				Instance.DAAsignarProcedure("_ID_DSS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Docs_Formato();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Formato GetOne(int ID_DOC_EXT)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Docs_Formato item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC_EXT", item.ID_DOC_EXT, SqlDbType.Int, 4, ParameterDirection.Input);
					}
					
					
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
