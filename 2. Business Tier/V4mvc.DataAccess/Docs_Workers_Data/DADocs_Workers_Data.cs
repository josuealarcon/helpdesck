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
	public partial class DADocs_Workers_Data : IDADocs_Workers_Data
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Docs_Workers_Data> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
		#endregion
		
		#region [ Constructores ]
		public DADocs_Workers_Data(IDataAccessEnterprise container)
		{
			Instance = container;
			Loader = new LoaderEntity<Docs_Workers_Data>();
			Docs_Workers_Data item = new Docs_Workers_Data();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_Workers_Data> GetAll()
		{
			try
			{
				ObservableCollection<Docs_Workers_Data> items = new ObservableCollection<Docs_Workers_Data>();
				Docs_Workers_Data item = new Docs_Workers_Data();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Docs_Workers_Data();
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
		public Docs_Workers_Data GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Docs_Workers_Data item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_DATA_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SALARIO", item.SALARIO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CARGO", item.CARGO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TURNO", item.TURNO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPOCONTRATO", item.TIPOCONTRATO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SUELDO_BASE", item.SUELDO_BASE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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
