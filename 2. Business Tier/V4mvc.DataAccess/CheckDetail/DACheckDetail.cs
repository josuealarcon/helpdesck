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
	public partial class DACheckDetail : IDACheckDetail
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<CheckDetail> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DACheckDetail(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<CheckDetail>();
			var item = new CheckDetail();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<CheckDetail> GetAll()
		{
			try
			{
				var items = new ObservableCollection<CheckDetail>();
				Instance.DAAsignarProcedure("V4MVC_CHECK_DETAIL_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new CheckDetail();
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

		public CheckDetail GetOne(Int32 ID_CHECK)
		{
			try
			{
				var item = new CheckDetail();
				Instance.DAAsignarProcedure("V4MVC_CHECK_DETAIL_SELECT_ONE");
				Instance.DAAgregarParametro("@ID_CHECK", ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool Save(ref CheckDetail item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_CHECK_DETAIL_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_CHECK_DETAIL_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID_TIPO", item.ID_TIPO, SqlDbType.NVarChar, 3, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_CHECK", item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_CHECKDET", item.ID_CHECKDET, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 2000, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 2000, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REQFOTO", item.REQFOTO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REQCODBARRA", item.REQCODBARRA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REQDOCUMENTO", item.REQDOCUMENTO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ORDEN", item.ORDEN.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDSYNC", item.IDSYNC.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRCREA", item.USRCREA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECCREA", item.FECCREA, SqlDbType.DateTime, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRMOD", item.USRMOD, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECMOD", item.FECMOD.Value, SqlDbType.DateTime, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REQVIDEO", item.REQVIDEO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_CHECKGROUP", item.ID_CHECKGROUP.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPO", item.TIPO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALORMULT", item.VALORMULT, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALIDA", item.VALIDA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_CHECK", item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@ID_CHECK"].Value != null)
						{
							item.ID_CHECK = Int32.Parse(Instance.DASqlCommand.Parameters["@ID_CHECK"].Value.ToString());
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

		public bool Delete(ref CheckDetail item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_CHECK_DETAIL_DELETE");
					Instance.DAAgregarParametro("@ID_CHECK", item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
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
