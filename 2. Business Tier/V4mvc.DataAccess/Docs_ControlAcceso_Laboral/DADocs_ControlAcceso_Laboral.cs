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
	public partial class DADocs_ControlAcceso_Laboral : IDADocs_ControlAcceso_Laboral
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Docs_ControlAcceso_Laboral> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
		#endregion
		
		#region [ Constructores ]
		public DADocs_ControlAcceso_Laboral(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Docs_ControlAcceso_Laboral>();
			Docs_ControlAcceso_Laboral item = new Docs_ControlAcceso_Laboral();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_ControlAcceso_Laboral> GetAll()
		{
			try
			{
				ObservableCollection<Docs_ControlAcceso_Laboral> items = new ObservableCollection<Docs_ControlAcceso_Laboral>();
				Docs_ControlAcceso_Laboral item = new Docs_ControlAcceso_Laboral();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Docs_ControlAcceso_Laboral();
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
		public Docs_ControlAcceso_Laboral GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Docs_ControlAcceso_Laboral item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_NEW");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_DELETE");
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", item.NOMBRE_ARCHIVO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPO_CONTENIDO", item.TIPO_CONTENIDO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHASUBE", item.FECHASUBE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORASUBE", item.HORASUBE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERTUSUARIO", item.CERTUSUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERTFECHA", item.CERTFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERTHORA", item.CERTHORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDRECHAZO", item.IDRECHAZO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBSCERTIFICACION", item.OBSCERTIFICACION, SqlDbType.NVarChar, -1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_ARCHIVO", item.ID_ARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA_INI", item.FECHA_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA_FIN", item.FECHA_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PERIODO", item.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CANTDIAS", item.CANTDIAS, SqlDbType.Int, 4, ParameterDirection.Input);
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
