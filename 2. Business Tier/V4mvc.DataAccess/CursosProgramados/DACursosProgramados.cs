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
	public partial class DACursosProgramados : IDACursosProgramados
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<CursosProgramados> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DACursosProgramados(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<CursosProgramados>();
			var item = new CursosProgramados();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<CursosProgramados> GetAll(ref CursosProgramados cursosProgramados)
		{
			try
			{
				var items = new ObservableCollection<CursosProgramados>();
				Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_CURSOSPROGRAMADOS_SELECT_MDTE");
				Instance.DAAgregarParametro("@START", cursosProgramados.START, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LENGTH", cursosProgramados.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@COLUMN", cursosProgramados.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIRECTION", cursosProgramados.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CHARLA", cursosProgramados.COL0, SqlDbType.NVarChar, 200, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FECHA", cursosProgramados.COL1, SqlDbType.NVarChar, 16, ParameterDirection.Input);
				Instance.DAAgregarParametro("@HORA", cursosProgramados.HORA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LUGAR", cursosProgramados.COL2, SqlDbType.NVarChar, 90, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SALA", cursosProgramados.COL3, SqlDbType.NVarChar, 40, ParameterDirection.Input);
				Instance.DAAgregarParametro("@TIPOCURSO", cursosProgramados.COL4, SqlDbType.NVarChar, 40, ParameterDirection.Input);
				Instance.DAAgregarParametro("@REALIZADO", cursosProgramados.COL5, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@TAB", 2, SqlDbType.Int, 4, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new CursosProgramados();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				cursosProgramados.COUNT = items.Count > 0 ? items[0].COUNT : 0;
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CursosProgramados GetOne(Int32 CODIGO)
		{
			try
			{
				var item = new CursosProgramados();
				Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_CURSOSPROGRAMADOS_SELECT_ONE_MDTE");
				Instance.DAAgregarParametro("@CODIGO", CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool Save(ref CursosProgramados item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_CURSOSPROGRAMADOS_INSERT_MDTE");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_CURSOSPROGRAMADOS_UPDATE_MDTE");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_CURSOSPROGRAMADOS_DELETE_MDTE");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@CURSO", item.CURSO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORA", item.HORA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LUGAR", item.LUGAR, SqlDbType.NVarChar, 90, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SALA", item.SALA, SqlDbType.NVarChar, 40, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ORADOR", item.ORADOR, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPOCURSO", item.TIPOCURSO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REALIZADO", item.REALIZADO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@CODIGO"].Value != null)
						{
							item.CODIGO = Int32.Parse(Instance.DASqlCommand.Parameters["@CODIGO"].Value.ToString());
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

		public bool Delete(ref CursosProgramados item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_CURSOSPROGRAMADOS_DELETE_MDTE");
					Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
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
