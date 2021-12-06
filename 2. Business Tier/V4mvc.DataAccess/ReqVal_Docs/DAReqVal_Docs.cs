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
	public partial class DAReqVal_Docs : IDAReqVal_Docs
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<ReqVal_Docs> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
		#endregion
		
		#region [ Constructores ]
		public DAReqVal_Docs(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<ReqVal_Docs>();
			ReqVal_Docs item = new ReqVal_Docs();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<ReqVal_Docs> GetAll()
		{
			try
			{
				ObservableCollection<ReqVal_Docs> items = new ObservableCollection<ReqVal_Docs>();
				ReqVal_Docs item = new ReqVal_Docs();
				Instance.DAAsignarProcedure("_ID_DSS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new ReqVal_Docs();
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
		public ReqVal_Docs GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref ReqVal_Docs item)
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
						Instance.DAAgregarParametro("@REQUISITO", item.REQUISITO, SqlDbType.NVarChar, 500, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDREQUISITO", item.IDREQUISITO, SqlDbType.Int, 4, ParameterDirection.Input);
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
