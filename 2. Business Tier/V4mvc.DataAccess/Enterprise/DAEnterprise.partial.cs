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
	public partial class DAEnterprise
	{
		#region [ Consultas ]
		public ObservableCollection<Enterprise> GetEnterprisesCttaSearcherMdte(ref Enterprise model)
		{
			try
			{
				ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_CTTA_SEARCHER_MDTE");
				Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

				Instance.DAAgregarParametro("@IDEMPRESA", model.COL0, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ACRONIMO", model.COL1, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NOMBRE", model.COL2, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Enterprise();
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
		public ObservableCollection<Enterprise> EnterpriseDatatables(Int32 iDisplayStart, Int32 iDisplayLength, String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE, String sortCOLUMN, String sortDIRECTION)
		{
			try
			{
				ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT_DATATABLES");
				Instance.DAAgregarParametro("@IDISPLAYSTART", iDisplayStart, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDISPLAYLENGTH", iDisplayLength, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SEARCH_IDEMPRESA", searchIDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SEARCH_ACRONIMO", searchACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SEARCH_NOMBRE", searchNOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SORT_COLUMN", sortCOLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SORT_DIRECTION", sortDIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Enterprise();
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

		public ObservableCollection<Enterprise> GetAllEnterprise_PasesCtta(string ID_EMPRESA, string OST)
		{
			try
			{
				ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT_PASES_CTTA");
				Instance.DAAgregarParametro("@IDEMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Enterprise();
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

		public Enterprise ContarFiltro(String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE)
		{
			try
			{
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_COUNT_FILTRO");
				Instance.DAAgregarParametro("@SEARCH_IDEMPRESA", searchIDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SEARCH_ACRONIMO", searchACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SEARCH_NOMBRE", searchNOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ throw new Exception("No se encontro el registro."); }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Informes ]
		public ObservableCollection<Enterprise> GeEnterprise_InformeConsultaRapidaCtta(Enterprise request)
		{
			try
			{
				ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT_INFORMECONSULTARAPIDA_CTTA");
				Instance.DAAgregarParametro("@RUT", request.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Enterprise();
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
		public bool SaveEnterpriseTelefono(String CELULAR, String IDEMPRESA)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_UPDATE_TELEFONO");
                Instance.DAAgregarParametro("@CELULAR", CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

		public bool SaveNewEnterpriseCTTA(ref Enterprise item)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_INSERT_NEWENTERPRISECTTA");
				Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CLAVE", item.CLAVE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ACRONIMO", item.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIRECCCION", item.DIRECCCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@PAIS", item.PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@TELEFONO", item.TELEFONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NRELEGAL", item.NRELEGAL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, 150, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ADMINRUT", item.ADMINRUT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ADMINNOM", item.ADMINNOM, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ADMINEMAIL", item.ADMINEMAIL, SqlDbType.NVarChar, 150, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{ return true; }
				else
				{ return false; }

			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ DashBoardCtta ]

		public Enterprise GetDashBoardCtta(string IDEMPRESA)
		{
			try
			{
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_DASHBOARD_CTTA");
				Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

		#region [ DashBoardMdte ]

		public Enterprise GetDashBoardMdte(string ADMRUT)
		{
			try
			{
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_DASHBOARD_MDTE");
				Instance.DAAgregarParametro("@ADMRUT", ADMRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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


