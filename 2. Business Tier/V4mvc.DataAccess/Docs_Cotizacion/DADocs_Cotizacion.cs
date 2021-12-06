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
	public partial class DADocs_Cotizacion : IDADocs_Cotizacion
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Docs_Cotizacion> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DADocs_Cotizacion(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Docs_Cotizacion>();
			var item = new Docs_Cotizacion();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<Docs_Cotizacion> GetAll()
		{
			try
			{
				var items = new ObservableCollection<Docs_Cotizacion>();
				Instance.DAAsignarProcedure("V4MVC_DOCS_COTIZACION_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Docs_Cotizacion();
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

		public Docs_Cotizacion GetOne(Guid? ID)
		{
			try
			{
				var item = new Docs_Cotizacion();
				Instance.DAAsignarProcedure("V4MVC_DOCS_COTIZACION_SELECT_ONE");
				Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
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

		public bool Save(ref Docs_Cotizacion item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_DOCS_COTIZACION_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_DOCS_COTIZACION_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPO", item.TIPO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID", item.ID.Value, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA_MOD", item.FECHA_MOD, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORA_MOD", item.HORA_MOD, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ESTADO", item.ESTADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBSERVACION", item.OBSERVACION, SqlDbType.NVarChar, 400, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO_CERT", item.USUARIO_CERT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA_CERT", item.FECHA_CERT, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORA_CERT", item.HORA_CERT, SqlDbType.NVarChar, 16, ParameterDirection.Input);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@IDEMPRESA"].Value != null)
						{
							item.IDEMPRESA = (Instance.DASqlCommand.Parameters["@IDEMPRESA"].Value.ToString());
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

		public bool Delete(ref Docs_Cotizacion item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_DOCS_COTIZACION_DELETE");
					Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
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
