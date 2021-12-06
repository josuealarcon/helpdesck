using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DAOSTArbol
	{
        #region [ Consultas ]
        public ObservableCollection<OSTArbol> GetOstDocFecVarios(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_OST_DOC_FEC_VARIOS");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<OSTArbol> GetOstPorEmpresaTurnosCtta(string EMPRESA)
        {
            try
            {
                ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_OSTARBOL_SELECT_POREMPRESA_TURNOS_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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


        public ObservableCollection<OSTArbol> GetOstPorDivEmpresa_Informe(string DIVISION, string EMPRESA)
        {
            try
            {
                ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_GET_OST_BYDIVEMPRESA_INFORME");
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<OSTArbol> GetInformeContratosCArranqueCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CONTRATOSCARRANQUE_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
        public ObservableCollection<OSTArbol> GetInformeContratosEmpresa_InformesEmpresasCtta(OSTArbol Item)
        {
            try
            {
                ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_SELECT_OSTARBOL_CONTRATOSEMPRESA_INFORMESEMPRESAS_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    int fec = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    while (reader.Read())
                    {
                        item = new OSTArbol();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;                     

                        if (int.Parse(item.FTERMINO)< fec)
                            item.FECHA_HOY = 1;                        
                        else
                            item.FECHA_HOY = 0;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<OSTArbol> GetInformeContratosCArranqueOstArbolCtta(ref OSTArbol model)
        {
            try
            {
                ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CONTRATOSCARRANQUE_OSTARBOL_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", model.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", model.NIVEL, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
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

        public OSTArbol GetOneOSTArbol_ControlLaboralCtta(string EMPRESA)
        {
            try
            {
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_OSTARBOL_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        return null; 
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<OSTArbol> GetOSTsPorEmpresa(string IDEMPRESA) {
            try
            {
                ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                OSTArbol item = new OSTArbol();
                Instance.DAAsignarProcedure("V4MVC_OSTARBOL_SELECT_BYEMPRESA_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        #endregion

        #region [ Metodos ]
        public bool UpdateOSTArbol_ContratOSTCtta(int ID_DOC, string EXT, string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL)
        {
            try
            {
                int ret_value = 0;
                Instance.DAAsignarProcedure("V4MVC_OSTARBOL_UPDATE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXT", EXT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXISTE_QUERY", 0, SqlDbType.Int, 8, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@EXISTE_QUERY"].Value != null)
                    {
                        ret_value = Int32.Parse(Instance.DASqlCommand.Parameters["@EXISTE_QUERY"].Value.ToString());
                    }
                    return (ret_value == 1);
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
