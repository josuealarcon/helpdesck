using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DACharlas
	{

		#region [ Consultas ]

		public ObservableCollection<Charlas> GetAllCharlasDivisionCtta(string DIVCOD)
		{
			try
			{
				ObservableCollection<Charlas> items = new ObservableCollection<Charlas>();
				Charlas item = new Charlas();
				Instance.DAAsignarProcedure("V4MVC_CHARLAS_SELECT_DIVISION_CTTA");
				Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Charlas();
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

		public ObservableCollection<Charlas> GetInformeCapacitacionesCtta(ref Charlas model)
		{
			try
			{
				ObservableCollection<Charlas> items = new ObservableCollection<Charlas>();
				Charlas item = new Charlas();
				Instance.DAAsignarProcedure("V4MVC_INFORME_CAPACITACIONES_CTTA");
				Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CURSOMES", model.CURSOS_MES, SqlDbType.NVarChar, 2, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDCHARLA", model.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Charlas();
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

		public ObservableCollection<Charlas> GetInformeCapacitacionesDetalleCtta(ref Charlas model)
		{
			try
			{
				ObservableCollection<Charlas> items = new ObservableCollection<Charlas>();
				Charlas item = new Charlas();
				Instance.DAAsignarProcedure("V4MVC_INFORMES_CAPACITACIONES_DETALLE_CTTA");
				Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FINALIZADO", model.FINALIZADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDCHARLA", model.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CODIGO", model.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Charlas();
						Loader.LoadEntity(reader, item);
						if (item.NOTA == null)
							item.NOTA = "";
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]
		public ObservableCollection<Charlas> GetCursosSearcherCtta(ref Charlas model)
		{
			try
			{
				ObservableCollection<Charlas> items = new ObservableCollection<Charlas>();
				Charlas item = new Charlas();
				Instance.DAAsignarProcedure("V4MVC_CHARLAS_BUSCAR_CURSOS_CTTA");
				Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

				Instance.DAAgregarParametro("@CHARLA", model.COL0, SqlDbType.NVarChar, 100, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DESCRIP", model.COL1, SqlDbType.NVarChar, 120, ParameterDirection.Input);
				Instance.DAAgregarParametro("@VENCIMIENTO", model.COL3, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Charlas();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				model.COUNT = items.Count > 0 ? items[0].COUNT : 0;
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
