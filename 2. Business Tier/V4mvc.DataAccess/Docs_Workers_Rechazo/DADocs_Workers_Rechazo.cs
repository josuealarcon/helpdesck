using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DADocs_Workers_Rechazo : IDADocs_Workers_Rechazo
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Docs_Workers_Rechazo> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
		#endregion
		
		#region [ Constructores ]
		public DADocs_Workers_Rechazo(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Docs_Workers_Rechazo>();
			Docs_Workers_Rechazo item = new Docs_Workers_Rechazo();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_Workers_Rechazo> GetAll()
		{
			try
			{
				ObservableCollection<Docs_Workers_Rechazo> items = new ObservableCollection<Docs_Workers_Rechazo>();
				Docs_Workers_Rechazo item = new Docs_Workers_Rechazo();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Docs_Workers_Rechazo();
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
		public Docs_Workers_Rechazo GetOne(String RUT, Guid ID, Int32 ID_TIPO_RECHAZO)
		{
			try
			{
				Docs_Workers_Rechazo item = new Docs_Workers_Rechazo();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ID_TIPO_RECHAZO", ID_TIPO_RECHAZO, SqlDbType.Int, 4, ParameterDirection.Input);
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

		#region [ Metodos ]
		public bool Save(ref Docs_Workers_Rechazo item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ID_TIPO_RECHAZO", item.ID_TIPO_RECHAZO, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ID_TIPO_RECHAZO", item.ID_TIPO_RECHAZO, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ID_TIPO_RECHAZO", item.ID_TIPO_RECHAZO, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORA", item.HORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
					}
					
					
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
