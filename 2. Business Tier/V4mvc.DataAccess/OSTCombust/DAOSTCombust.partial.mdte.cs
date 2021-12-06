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
	public partial class DAOSTCombust
	{

		#region [ Consultas ]

		public ObservableCollection<OSTCombust> GetAllOSTCombust_Mdte(string NROOST, string IDEMPRESA)
		{
			try
			{
				var items = new ObservableCollection<OSTCombust>();
				Instance.DAAsignarProcedure("V4MVC_OSTCOMBUST_SELECT");
				Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new OSTCombust();
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

		public bool DeleteOstCombustOST_Mdte(ref OST Item)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_OSTCOMBUST_DELETE_OST");
				Instance.DAAgregarParametro("@NROOST", Item.NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", Item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}


		public bool SaveOstCombustOST_Mdte(ref OSTCombust item)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_OSTCOMBUST_SAVE_OST_MDTE");
				Instance.DAAgregarParametro("@NROOST", item.NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@COMBUST", item.COMBUST, SqlDbType.NVarChar, 3, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{ return true; }
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
