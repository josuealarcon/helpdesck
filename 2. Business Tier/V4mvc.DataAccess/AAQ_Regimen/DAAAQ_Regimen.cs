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
	public partial class DAAAQ_Regimen : IDAAAQ_Regimen
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<AAQ_Regimen> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DAAAQ_Regimen(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<AAQ_Regimen>();
			var item = new AAQ_Regimen();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<AAQ_Regimen> GetListAAQ_Regimens_Mdte()
		{
			try
			{
				var items = new ObservableCollection<AAQ_Regimen>();
				Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_REGIMEN_SELECT_MDTE");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new AAQ_Regimen();
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
       


        public AAQ_Regimen GetOne(Int32 IDREGIMEN)
		{
			try
			{
				var item = new AAQ_Regimen();
				Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_REGIMEN_SELECT_MDTE");
				Instance.DAAgregarParametro("@IDREGIMEN", IDREGIMEN, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ return null; }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref AAQ_Regimen item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_REGIMEN_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_REGIMEN_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 200, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REQCODCONCIVIL", item.REQCODCONCIVIL, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDREGIMEN", item.IDREGIMEN, SqlDbType.Int, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@IDREGIMEN"].Value != null)
						{
							item.IDREGIMEN = Int32.Parse(Instance.DASqlCommand.Parameters["@IDREGIMEN"].Value.ToString());
						}
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref AAQ_Regimen item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_REGIMEN_DELETE");
					Instance.DAAgregarParametro("@IDREGIMEN", item.IDREGIMEN, SqlDbType.Int, 4, ParameterDirection.Input);
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					return false;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
