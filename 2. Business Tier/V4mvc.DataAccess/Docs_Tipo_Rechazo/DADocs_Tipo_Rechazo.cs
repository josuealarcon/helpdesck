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
	public partial class DADocs_Tipo_Rechazo : IDADocs_Tipo_Rechazo
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Docs_Tipo_Rechazo> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DADocs_Tipo_Rechazo(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Docs_Tipo_Rechazo>();
			Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_Tipo_Rechazo> GetAll()
		{
			try
			{
				ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
				Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
				Instance.DAAsignarProcedure("_ID_TSS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Docs_Tipo_Rechazo();
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
		public Docs_Tipo_Rechazo GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Docs_Tipo_Rechazo item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_ID_TSU_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_ID_TSD_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID_TIPO_RECHAZO", item.ID_TIPO_RECHAZO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPO_RECHAZO", item.TIPO_RECHAZO, SqlDbType.NVarChar, 150, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EXPLICACION", item.EXPLICACION, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LINK_EXPLICACION", item.LINK_EXPLICACION, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VER_CHECK", item.VER_CHECK, SqlDbType.NChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TITULO_CHECK", item.TITULO_CHECK, SqlDbType.NVarChar, 200, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EXPLICACION_CHECK", item.EXPLICACION_CHECK, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
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
