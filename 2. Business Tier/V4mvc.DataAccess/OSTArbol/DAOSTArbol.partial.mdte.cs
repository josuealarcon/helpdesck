using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAOSTArbol
    {

		#region [ Consultas ]

		public OSTArbol GetOne(string OST, string MADRE, string EMPRESA, Int16 NIVEL)
		{
			try
			{
				OSTArbol item = new OSTArbol();
				Instance.DAAsignarProcedure("V4MVC_OSTARBOL_SELECT_MDTE");
				Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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

		public OSTArbol GetOstArbolReferencia_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL)
		{
			try
			{
				OSTArbol item = new OSTArbol();
				Instance.DAAsignarProcedure("V4MVC_OSTARBOL_REFERENCIA_MDTE");
				Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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

		public ObservableCollection<OSTArbol> GetAllOstArbolTurnos_Mdte(string EMPRESA)
		{
			try
			{
				ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
				OSTArbol item = new OSTArbol();
				Instance.DAAsignarProcedure("V4MVC_OSTARBOL_SELECT_TURNOS_MDTE");
				Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new OSTArbol();
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

		#endregion

		#region [ Metodos ]

		public bool SaveOstArbol_Mdte(ref OSTArbol Item)
		{
			try
			{
				OSTArbol item = new OSTArbol();
				Instance.DAAsignarProcedure("V4MVC_OSTARBOL_INSERT_SUBCONTRATISTA_MDTE");
				Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@MADRE", Item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NIVEL", Item.NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FINICIO", Item.FINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FTERMINO", Item.FTERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@AUTOR", Item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ADMINSUBC", Item.ADMINSUBC, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DESCSUBC", Item.DESCSUBC, SqlDbType.NVarChar, 250, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SUBC", Item.SUBC, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SUBC2", Item.SUBC2, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DOTMAXFAENA", Item.DOTMAXFAENA, SqlDbType.SmallInt, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@HOLGDOTACRE", Item.HOLGDOTACRE, SqlDbType.SmallInt, 4, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public OSTArbol SaveOstArbolOST_Mdte(ref OSTArbol Item)
		{
			try
			{
				OSTArbol item = new OSTArbol();
				Instance.DAAsignarProcedure("V4MVC_OSTARBOL_INSERT_OST_MDTE");
				Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@MADRE", Item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NIVEL", Item.NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FINICIO", Item.FINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FTERMINO", Item.FTERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@AUTOR", Item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ADMINSUBC", Item.ADMINSUBC, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DESCSUBC", Item.DESCSUBC, SqlDbType.NVarChar, 250, ParameterDirection.Input);
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

	}
}
