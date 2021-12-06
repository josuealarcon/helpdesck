using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAOSTSubc : IDAOSTSubc
    {
        #region[ Consultas ]

        public ObservableCollection<OSTSubc> GetListContratOST_Mdte(ref OSTSubc ostSubc)
        {
            try
            {
                ObservableCollection<OSTSubc> items = new ObservableCollection<OSTSubc>();
                Instance.DAAsignarProcedure("V4MVC_OST_SELECT_LISTADO_MDTE");
                Instance.DAAgregarParametro("@START", ostSubc.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", ostSubc.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", ostSubc.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", ostSubc.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", ostSubc.NROOST, SqlDbType.NVarChar, 28, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", ostSubc.NIVEL, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", ostSubc.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", ostSubc.MADRE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMOMADRE", ostSubc.ACRONIMOMADRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", ostSubc.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FINICIO", ostSubc.FINICIO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FTERMINO", ostSubc.FTERMINO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIENE_FINICIO", ostSubc.TIENE_FINICIO, SqlDbType.NVarChar, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIENE_FTERMINO", ostSubc.TIENE_FTERMINO, SqlDbType.NVarChar, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLOR_FTERMINO", ostSubc.COLOR_FTERMINO, SqlDbType.NVarChar, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISIONES", ostSubc.DIVISIONES, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ZONA", ostSubc.ZONA, SqlDbType.NVarChar, 24, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDACION", ostSubc.USUARIO, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", ostSubc.DIVCOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        ostSubc = new OSTSubc();
                        Loader.LoadEntity(reader, ostSubc);
                        ostSubc.Instance = InstanceEntity.Unchanged;
                        items.Add(ostSubc);
                    }
                }
                ostSubc.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public OSTSubc GetOST_Empresa_Mdte(ref OSTSubc ostSubc)
        {
            try
            {
                var item = new OSTSubc();
                Instance.DAAsignarProcedure("V4MVC_OSTSUBC_SELECT_EMPRESA_MDTE");               
                Instance.DAAgregarParametro("@NROOST", ostSubc.NROOST, SqlDbType.NVarChar, 28, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", ostSubc.NIVEL, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", ostSubc.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", ostSubc.MADRE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public OSTSubc GetOstSubcOST_Mdte(string OST, string EMPRESA, Int16 NIVEL)
        {
            try
            {
                var item = new OSTSubc();
                Instance.DAAsignarProcedure("V4MVC_OSTSUBC_SELECT_OST_MDTE");
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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

        #region[ Metodos ]

        public bool SaveOST_Mdte(OSTSubc ostSubc)
        {
            try
            {
                switch (ostSubc.Instance)
                {
                    case InstanceEntity.New:
                        Instance.DAAsignarProcedure("");
                        Instance.DAAgregarParametro("@OST", ostSubc.NROOST, SqlDbType.NVarChar, 28, ParameterDirection.Input);

                        break;
                    case InstanceEntity.Modify:
                        Instance.DAAsignarProcedure("V4MVC_CONTRATOSOST_UPDATE_MDTE");
                        Instance.DAAgregarParametro("@OST", ostSubc.NROOST, SqlDbType.NVarChar, 28, ParameterDirection.Input);
                        break;
                    case InstanceEntity.Delete:
                        Instance.DAAsignarProcedure("V4MVC_OST_DELETE_MDTE");
                        Instance.DAAgregarParametro("@OST", ostSubc.NROOST, SqlDbType.NVarChar, 28, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", ostSubc.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NIVEL", ostSubc.NIVEL, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@MADRE", ostSubc.MADRE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        break;
                }
                if (ostSubc.Instance == InstanceEntity.New || ostSubc.Instance == InstanceEntity.Modify)
                {
                    Instance.DAAgregarParametro("@NIVEL", ostSubc.NIVEL, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@EMPRESA", ostSubc.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@MADRE", ostSubc.MADRE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ACRONIMOMADRE", ostSubc.ACRONIMOMADRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ACRONIMO", ostSubc.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@FINICIO", ostSubc.FINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@FTERMINO", ostSubc.FTERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);

                }
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveOSTEmpresa_Mdte(OSTSubc ostSubc)
        {
            try
            {
                switch (ostSubc.Instance)
                {
                    case InstanceEntity.New:
                        Instance.DAAsignarProcedure("V4MVC_OST_INSERT_EMPRESA_MDTE");
                        Instance.DAAgregarParametro("@IDEMPRESA", ostSubc.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NROOST", ostSubc.NROOST, SqlDbType.NVarChar, 28, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NIVEL", ostSubc.NIVEL, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@IDEMPRESACONTRATISTA", ostSubc.IDEMPRESACONTRATISTA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@MADRE", ostSubc.MADRE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        break;
                   
                }              
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
