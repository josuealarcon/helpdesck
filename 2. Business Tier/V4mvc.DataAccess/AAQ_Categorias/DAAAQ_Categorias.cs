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
	public partial class DAAAQ_Categorias : IDAAAQ_Categorias
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<AAQ_Categorias> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DAAAQ_Categorias(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<AAQ_Categorias>();
			var item = new AAQ_Categorias();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<AAQ_Categorias> GetListCategorias_Mdte(ref AAQ_Categorias item)
		{
			try
			{
				var items = new ObservableCollection<AAQ_Categorias>();
				Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CATEGORIAS_SELECT_CATEGORIAS_MDTE");
                Instance.DAAgregarParametro("@START", item.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", item.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", item.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", item.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDCATEGORIA", item.IDCATEGORIA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGIMEN", item.REGIMEN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLASIFICACION", item.CLASIFICACION, SqlDbType.NVarChar, 40, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
               
                using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
					    item = new AAQ_Categorias();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
                item.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
			catch (Exception ex)
			{ throw ex; }
		}

		public AAQ_Categorias GetOneCategorias_Mdte(int IDCATEGORIA)
		{
			try
			{
				var item = new AAQ_Categorias();
                Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CATEGORIAS_SELECT_ONECATEGORIA_MDTE");
                Instance.DAAgregarParametro("@IDCATEGORIA", IDCATEGORIA, SqlDbType.Int, 4, ParameterDirection.Input);
               
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

		public bool SaveCategorias_Mdte(ref AAQ_Categorias item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CATEGORIAS_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CATEGORIAS_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@IDREGIMEN", item.IDREGIMEN, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRE",  item.NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CLASIFICACION", item.CLASIFICACION, SqlDbType.NVarChar, 40, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDCATEGORIA", item.IDCATEGORIA, SqlDbType.Int, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@IDCATEGORIA"].Value != null)
						{
							item.IDCATEGORIA = Int32.Parse(Instance.DASqlCommand.Parameters["@IDCATEGORIA"].Value.ToString());
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
		 
		public bool DeleteCategorias_Mdte(string IDCATEGORIA)
		{
			try
			{

					Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CATEGORIAS_DELETE_MDTE");
					Instance.DAAgregarParametro("@IDCATEGORIA", Convert.ToInt64(IDCATEGORIA), SqlDbType.Int, 4, ParameterDirection.Input);
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
                    return false; 
            }
			catch (Exception ex)
			{ throw ex; }
		}



        #endregion
    }
}
