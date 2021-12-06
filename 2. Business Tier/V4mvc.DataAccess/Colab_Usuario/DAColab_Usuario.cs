using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAColab_Usuario : IDAColab_Usuario
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Colab_Usuario> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAColab_Usuario(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Colab_Usuario>();
			Colab_Usuario item = new Colab_Usuario();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Colab_Usuario> GetAll()
		{
			try
			{
				ObservableCollection<Colab_Usuario> items = new ObservableCollection<Colab_Usuario>();
				Colab_Usuario item = new Colab_Usuario();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Colab_Usuario();
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
		public Colab_Usuario GetOne(String IdEmpresa, String Rut)
		{
            try
            {
                Colab_Usuario item = new Colab_Usuario();
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_SELECT_USUARIO");
                Instance.DAAgregarParametro("@IdEmpresa", IdEmpresa, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@Rut", Rut, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
		public Colab_Usuario GetOneColabUsuario_v2_Ctta(String IdEmpresa, String Rut)
		{
			try
			{
				Colab_Usuario item = new Colab_Usuario();
				Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_SELECT_V2_USUARIO");
				Instance.DAAgregarParametro("@IdEmpresa", IdEmpresa, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@Rut", Rut, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
		public bool Save(ref Colab_Usuario item)
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
						Instance.DAAgregarParametro("@IdEmpresa", item.IdEmpresa, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Rut", item.Rut, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Clave", item.Clave, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Correo_Electronico", item.Correo_Electronico, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TipoUsuario", item.TipoUsuario, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Activo", item.Activo, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EnvioAlertas", item.EnvioAlertas, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Fecha_Creacion", item.Fecha_Creacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Fecha_Modificacion", item.Fecha_Modificacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Ultimo_Acceso", item.Ultimo_Acceso, SqlDbType.DateTime, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FechaVence", item.FechaVence, SqlDbType.NVarChar, 8, ParameterDirection.Input);
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
