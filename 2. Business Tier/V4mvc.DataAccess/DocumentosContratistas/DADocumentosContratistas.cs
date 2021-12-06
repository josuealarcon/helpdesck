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
	public partial class DADocumentosContratistas : IDADocumentosContratistas
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<DocumentosContratistas> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DADocumentosContratistas(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<DocumentosContratistas>();
			var item = new DocumentosContratistas();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<DocumentosContratistas> GetAll(ref DocumentosContratistas documentosContratistas)
		{
			try
			{
				var items = new ObservableCollection<DocumentosContratistas>();
				Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CTTA_DOCS_SELECT_MDTE");
				Instance.DAAgregarParametro("@START", documentosContratistas.START, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LENGTH", documentosContratistas.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@COLUMN", documentosContratistas.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIRECTION", documentosContratistas.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NOMBRE", documentosContratistas.COL0, SqlDbType.NVarChar, 100, ParameterDirection.Input);
				Instance.DAAgregarParametro("@TIPOPROP", documentosContratistas.COL1, SqlDbType.NVarChar, 6, ParameterDirection.Input);
				Instance.DAAgregarParametro("@OBLIGA", documentosContratistas.COL2, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ACTIVO", documentosContratistas.COL3, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new DocumentosContratistas();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				documentosContratistas.COUNT = items.Count > 0 ? items[0].COUNT : 0;
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public DocumentosContratistas GetOne(Int32 IDCTTA_DOC)
		{
			try
			{
				var item = new DocumentosContratistas();
				Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CTTA_DOCS_SELECT_ONE");
				Instance.DAAgregarParametro("@IDCTTA_DOC", IDCTTA_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool Save(ref DocumentosContratistas item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CTTA_DOCS_INSERT_MDTE");
							Instance.DAAgregarParametro("@IDDOC", item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@TIPOPROP", item.TIPOPROP, SqlDbType.NVarChar, 6, ParameterDirection.Input);
							Instance.DAAgregarParametro("@OBLIGA", item.OBLIGA, SqlDbType.NVarChar, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDCTTA_DOC", item.IDCTTA_DOC, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CTTA_DOCS_UPDATE_MDTE");
							Instance.DAAgregarParametro("@OBLIGA", item.OBLIGA, SqlDbType.NVarChar, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDCTTA_DOC", item.IDCTTA_DOC, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CTTA_DOCS_DELETE_MDTE");
							Instance.DAAgregarParametro("@IDCTTA_DOC", item.IDCTTA_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@IDCTTA_DOC"].Value != null)
						{
							item.IDCTTA_DOC = Int32.Parse(Instance.DASqlCommand.Parameters["@IDCTTA_DOC"].Value.ToString());
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

		public bool Delete(ref DocumentosContratistas item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CTTA_DOCS_DELETE");
					Instance.DAAgregarParametro("@IDCTTA_DOC", item.IDCTTA_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
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
