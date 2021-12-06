using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAOSTArbol : IDAOSTArbol
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<OSTArbol> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAOSTArbol(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<OSTArbol>();
			OSTArbol item = new OSTArbol();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<OSTArbol> GetAll(OSTArbol oSTArbol)
		{
			try
			{
				ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
				OSTArbol item = new OSTArbol();
				Instance.DAAsignarProcedure("V4MVC_OST_ARBOL_SELECT");
				Instance.DAAgregarParametro("@EMPRESA", oSTArbol.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new OSTArbol();
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
		public OSTArbol GetOne(String OST, String MADRE, String EMPRESA)
		{
			try
			{
				OSTArbol item = new OSTArbol();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
		public bool Save(ref OSTArbol item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							Instance.DAAgregarParametro("@MADRE", item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							Instance.DAAgregarParametro("@MADRE", item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							Instance.DAAgregarParametro("@MADRE", item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ADMINSUBC", item.ADMINSUBC, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCSUBC", item.DESCSUBC, SqlDbType.NVarChar, 250, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NIVEL", item.NIVEL, SqlDbType.SmallInt, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINICIO", item.FINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FTERMINO", item.FTERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUTOR", item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTMAXFAENA", item.DOTMAXFAENA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HOLGDOTACRE", item.HOLGDOTACRE, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FFINCERT", item.FFINCERT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FENTDOCS", item.FENTDOCS, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FFINVALIDA", item.FFINVALIDA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FFINVALIDA_ADMIN", item.FFINVALIDA_ADMIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINICERT", item.FINICERT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALIDA_CARRANQUE", item.VALIDA_CARRANQUE, SqlDbType.Char, 2, ParameterDirection.Input);
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
