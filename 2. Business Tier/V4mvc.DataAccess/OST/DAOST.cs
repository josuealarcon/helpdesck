using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAOST : IDAOST
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<OST> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAOST(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<OST>();
			OST item = new OST();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<OST> GetAll()
		{
			try
			{
				ObservableCollection<OST> items = new ObservableCollection<OST>();
				OST item = new OST();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new OST();
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
		public OST GetOne(String NROOST, String IDEMPRESA)
		{
			try
			{
				OST item = new OST();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
		public bool Save(ref OST item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@NROOST", item.NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@NROOST", item.NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@NROOST", item.NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@FECINICIO", item.FECINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECTERM", item.FECTERM, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ADMINOST", item.ADMINOST, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ALOJA", item.ALOJA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TRANSP", item.TRANSP, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ALIMENT", item.ALIMENT, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@COMBUST", item.COMBUST, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCRIPOST", item.DESCRIPOST, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECCIERRE", item.FECCIERRE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTACION", item.DOTACION, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FLOTANTE", item.FLOTANTE, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTALOJA", item.DOTALOJA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTALIM", item.DOTALIM, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MADRE", item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NIVEL", item.NIVEL, SqlDbType.SmallInt, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTRANSP", item.DOTRANSP, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUTOR", item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALOR", item.VALOR, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MONEDA", item.MONEDA, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ADMINCONTR", item.ADMINCONTR, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCEXT", item.DESCEXT, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CCOSTO", item.CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GERENCIA", item.GERENCIA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FANTERIOR", item.FANTERIOR, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DEPARTAMENTO", item.ID_DEPARTAMENTO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_TIPO_SECTOR", item.ID_TIPO_SECTOR, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_SECTOR", item.ID_SECTOR, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA_AVISOESE", item.FECHA_AVISOESE, SqlDbType.DateTime, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTTRANS", item.DOTTRANS, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ESPORADICO", item.ESPORADICO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTMAXFAENA", item.DOTMAXFAENA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HOLGDOTACRE", item.HOLGDOTACRE, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORACREACION", item.HORACREACION, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRCREACION", item.USRCREACION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALIDADOR", item.VALIDADOR, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINICERT", item.FINICERT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FFINCERT", item.FFINCERT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FENTDOCS", item.FENTDOCS, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FFINVALIDA", item.FFINVALIDA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FFINVALIDA_ADMIN", item.FFINVALIDA_ADMIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PREVEN_RIESGOS", item.PREVEN_RIESGOS, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@STATUS", item.STATUS, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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
