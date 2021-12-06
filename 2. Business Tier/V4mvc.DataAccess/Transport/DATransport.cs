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
	public partial class DATransport : IDATransport
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Transport> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DATransport(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Transport>();
			Transport item = new Transport();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Transport> GetAll()
		{
			try
			{
				ObservableCollection<Transport> items = new ObservableCollection<Transport>();
				Transport item = new Transport();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Transport();
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
        public Transport GetOne(string PATENTE)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
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
        public bool Save(ref Transport item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_TRANSPORT_INSERT");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_TRANSPORT_UPDATE");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@PATENTE", item.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPO", item.TIPO, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@COLOR", item.COLOR, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ANOFAB", item.ANOFAB, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@PERMISOCIRC", item.PERMISOCIRC, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECSEGURO", item.FECSEGURO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@REVTEC", item.REVTEC, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CAPACIDAD", item.CAPACIDAD, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@OPERINVIER", item.OPERINVIER, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NRO", item.NRO, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@AUTOR", item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@MARCA", item.MARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@MODELO", item.MODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CODMOP", item.CODMOP, SqlDbType.NVarChar, 3, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECCHECK", item.FECCHECK, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECMINERA", item.FECMINERA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@LABEL", item.LABEL, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@OBS", item.OBS, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIENEWISE", item.TIENEWISE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FUNCACARGO", item.FUNCACARGO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FUNCNOM", item.FUNCNOM, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@AREA", item.AREA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NUMINT", item.NUMINT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPO_PROPIETARIO", item.TIPO_PROPIETARIO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@RUT_PROPIETARIO", item.RUT_PROPIETARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@COMBUSTIBLE", item.COMBUSTIBLE, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TRACCION", item.TRACCION, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CILINDRADA", item.CILINDRADA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@POTENCIA", item.POTENCIA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TURNO", item.TURNO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@SERVICIO", item.SERVICIO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@MONITOREADO", item.MONITOREADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EQUIPOADAS", item.MONITOREADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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
