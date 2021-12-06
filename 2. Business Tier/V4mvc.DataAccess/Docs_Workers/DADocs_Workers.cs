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
	public partial class DADocs_Workers : IDADocs_Workers
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Docs_Workers> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        //private readonly IDbFactory _dbFactory;
        #endregion

        #region [ Constructores ]
        public DADocs_Workers(IDataAccessEnterprise container)
		{
			Instance = container;
			Loader = new LoaderEntity<Docs_Workers>();
			Docs_Workers item = new Docs_Workers();
			Loader.EntityType = item.GetType();
            //_dbFactory = dbFactory;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_Workers> GetAll()
		{
			try
			{
				ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
                Docs_Workers item = new Docs_Workers();
                Instance.DAAsignarProcedure("_SI_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Workers();
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
		public Docs_Workers GetOne()
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Docs_Workers item)
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
                            Instance.DAAsignarProcedure("_SU_UnReg");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", item.NOMBRE_ARCHIVO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHA_MOD", item.FECHA_MOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORA_MOD", item.HORA_MOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPO_CONTENIDO", item.TIPO_CONTENIDO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ARCHIVO", item.ARCHIVO, SqlDbType.Image, 2147483647, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CANTIDAD", item.CANTIDAD, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_DOCS_WORKERS", item.ID_DOCS_WORKERS, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHASUBE", item.FECHASUBE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORASUBE", item.HORASUBE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CERTFECHA", item.CERTFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CERTHORA", item.CERTHORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CERTUSUARIO", item.CERTUSUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@VALIDADO2", item.VALIDADO2, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CERTFECHA2", item.CERTFECHA2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CERTHORA2", item.CERTHORA2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CERTUSUARIO2", item.CERTUSUARIO2, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@OBSERVACION", item.OBSERVACION, SqlDbType.NVarChar, 500, ParameterDirection.Input);
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
