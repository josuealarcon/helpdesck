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
	public partial class DAAAQ_Puestos : IDAAAQ_Puestos
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<AAQ_Puestos> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }

		#endregion

		#region [ Constructores ]

		public DAAAQ_Puestos(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<AAQ_Puestos>();
			var item = new AAQ_Puestos();
			Loader.EntityType = item.GetType();
			Instance = container;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<AAQ_Puestos> GetAllPuestos_Mdte(ref AAQ_Puestos item)
		{
			try
			{
				var items = new ObservableCollection<AAQ_Puestos>();
                Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_PUESTOS_SELECT_PUESTOS_MDTE");
                Instance.DAAgregarParametro("@START", item.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", item.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", item.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", item.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDPUESTO", item.IDPUESTO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CATEGORIA", item.CATEGORIA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CALIFICADO", item.CALIFICADO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new AAQ_Puestos();
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

	
		public AAQ_Puestos GetOnePuestos_Mdte(Int32 IDPUESTO)
		{
			try
			{
				var item = new AAQ_Puestos();
				Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_PUESTOS_SELECT_ONEPUESTOS_MDTE");
				Instance.DAAgregarParametro("@IDPUESTO", IDPUESTO, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool DeletePuestos_Mdte(string IDPUESTO)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_PUESTOS_DELETE_MDTE");
				Instance.DAAgregarParametro("@IDPUESTO", Convert.ToInt64(IDPUESTO), SqlDbType.Int, 4, ParameterDirection.Input);
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



