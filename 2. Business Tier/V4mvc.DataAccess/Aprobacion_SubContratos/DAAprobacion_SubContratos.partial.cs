using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAAprobacion_SubContratos
    {
        #region [ Consultas ]

        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosPendientes(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Aprobacion_SubContratos> items = new ObservableCollection<Aprobacion_SubContratos>();
                Aprobacion_SubContratos item = new Aprobacion_SubContratos();
                Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_SELECT_PENDIENTES");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Aprobacion_SubContratos();
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

        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProceso(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Aprobacion_SubContratos> items = new ObservableCollection<Aprobacion_SubContratos>();
                Aprobacion_SubContratos item = new Aprobacion_SubContratos();
                Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_SELECT_ENPROCESO");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Aprobacion_SubContratos();
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

        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProcesadas(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Aprobacion_SubContratos> items = new ObservableCollection<Aprobacion_SubContratos>();
                Aprobacion_SubContratos item = new Aprobacion_SubContratos();
                Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_SELECT_PROCESADAS");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Aprobacion_SubContratos();
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

        #endregion

        #region [ Metodos ]
        public bool Save_Aprobacion_SubContratos(Aprobacion_SubContratos item)
        {
            try
            {
                switch (item.Instance)
                {
                    case InstanceEntity.New:
                        Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_INSERT_CTTA");
                        Instance.DAAgregarParametro("@ACRONIMO", item.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);

                        break;
                    case InstanceEntity.Modify:
                        Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_UPDATE_CTTA");
                        Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
                        break;
                    case InstanceEntity.Delete:
                        Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_DELETE_CTTA");
                        Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USR_SOLICITA", item.USR_SOLICITA, SqlDbType.Char, 2, ParameterDirection.Input);
                        break;
                }
                if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                {
                    Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@MADRE", item.MADRE, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@DOTACION", item.DOTACION, SqlDbType.Int, 4, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@DOTACION_VEHI", item.DOTACION_VEHI, SqlDbType.Int, 4, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@FINICIO", item.FINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@FTERMINO", item.FTERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@MONTO", item.MONTO, SqlDbType.Int, 4, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@NIVEL", item.NIVEL, SqlDbType.Int, 4, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@CORREO_ADM_CTTA", item.CORREO_ADM_CTTA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ADMIN_CTTA", item.ADMIN_CTTA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ID_ARCHIVO", item.ID_ARCHIVO, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@TELEFONO", item.TELEFONO, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@LICITACION", item.LICITACION, SqlDbType.Char, 2, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@USR_SOLICITA", item.USR_SOLICITA, SqlDbType.NVarChar, 30, ParameterDirection.Input);
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
