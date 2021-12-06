using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAEnterprise : IDAEnterprise
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
        public LoaderEntity<Enterprise> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAEnterprise(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Enterprise>();
			Enterprise item = new Enterprise();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Enterprise> GetAll()
		{
			try
			{
				ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Enterprise();
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
		public Enterprise GetOne(String IDEMPRESA)
		{
			try
			{
				Enterprise item = new Enterprise();
				Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT");
				Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
		public bool Save(ref Enterprise item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_INSERT");
							Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_UPDATE");
							Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@CLAVE", item.CLAVE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACRONIMO", item.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RUBRO", item.RUBRO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIRECCCION", item.DIRECCCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TELEFONO", item.TELEFONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FAX", item.FAX, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NRELEGAL", item.NRELEGAL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RELEGAL", item.RELEGAL, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, 150, ParameterDirection.Input);
						Instance.DAAgregarParametro("@UBIFAENA", item.UBIFAENA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FONOFAENA", item.FONOFAENA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ADMINNOM", item.ADMINNOM, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ADMINRUT", item.ADMINRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ADMINEMAIL", item.ADMINEMAIL, SqlDbType.NVarChar, 150, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ADMINFONO", item.ADMINFONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@BLOQUEOCASINO", item.BLOQUEOCASINO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHABLOQUEO", item.FECHABLOQUEO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECAUDIT", item.FECAUDIT, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPOEMP", item.TIPOEMP, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RINTERNO", item.RINTERNO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CPARITARIO", item.CPARITARIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AUTOR", item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FINANZAS", item.FINANZAS, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RRHH", item.RRHH, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SICEP", item.SICEP, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DICOM", item.DICOM, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PROPIO", item.PROPIO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LEGAL", item.LEGAL, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTRATOS", item.CONTRATOS, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TAUDIT", item.TAUDIT, SqlDbType.SmallInt, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SEGURITO", item.SEGURITO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMAILSEGURITO", item.EMAILSEGURITO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MUTUAL", item.MUTUAL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CODIGOMUTUAL", item.CODIGOMUTUAL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SERNAGEOMIN", item.SERNAGEOMIN, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CODIGOSERNA", item.CODIGOSERNA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MAILLICITA", item.MAILLICITA, SqlDbType.NVarChar, 150, ParameterDirection.Input);
						Instance.DAAgregarParametro("@BALANCE", item.BALANCE, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ANTERIOR", item.ANTERIOR, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ELYPSE", item.ELYPSE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PAIS", item.PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RUTHOTEL", item.RUTHOTEL, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTACTOHOTEL", item.CONTACTOHOTEL, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TLFHOTEL", item.TLFHOTEL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMAILHOTEL", item.EMAILHOTEL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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
