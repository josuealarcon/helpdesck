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
	public partial class DAOST
	{
        #region [ Consultas ]
        public ObservableCollection<OST> GetOSTsSearcherCtta(ref OST model)
        {
            try
            {
                ObservableCollection<OST> items = new ObservableCollection<OST>();
                OST item = new OST();

                Instance.DAAsignarProcedure("V4MVC_OST_SELECT_SEARCHER_CTTA");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", model.COL0, SqlDbType.NVarChar, 40, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIPCION", model.COL1, SqlDbType.NVarChar, 400, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECINICIO", model.COL2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECTERM", model.COL3, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
                model.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }


        public ObservableCollection<OST> GetAllOST_PasesCtta(string IDEMPRESA, string DIVISION, out string OST, out int CUENTA_CONTRATOS, out string FEC_INICIO, out string FEC_TERM)
        {
            try
            {
                OST = string.Empty;
                CUENTA_CONTRATOS = 0;
                FEC_INICIO = string.Empty;
                FEC_TERM = string.Empty;

                ObservableCollection<OST> items = new ObservableCollection<OST>();
                OST item = new OST();
                Instance.DAAsignarProcedure("V4MVC_OST_SELECT_PASES_CTTA");
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST_UNICA", "", SqlDbType.NVarChar, 14, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CUENTA_CONTR", -1, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@FECINICIO", "", SqlDbType.NVarChar, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@FECTERM", "", SqlDbType.NVarChar, 8, ParameterDirection.Output);

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

                if (Instance.DASqlCommand.Parameters["@OST_UNICA"].Value != null)
                {
                    OST = Instance.DASqlCommand.Parameters["@OST_UNICA"].Value.ToString();
                }

                if (Instance.DASqlCommand.Parameters["@CUENTA_CONTR"].Value != null)
                {
                    CUENTA_CONTRATOS = int.Parse(Instance.DASqlCommand.Parameters["@CUENTA_CONTR"].Value.ToString());
                }

                if (Instance.DASqlCommand.Parameters["@FECINICIO"].Value != null)
                {
                    FEC_INICIO = Instance.DASqlCommand.Parameters["@FECINICIO"].Value.ToString();
                }

                if (Instance.DASqlCommand.Parameters["@FECTERM"].Value != null)
                {
                    FEC_TERM = Instance.DASqlCommand.Parameters["@FECTERM"].Value.ToString();
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public OST GetOneOST_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL)
        {
            try
            {
                OST item = new OST();
                Instance.DAAsignarProcedure("V4MVC_OST_SELECT_ONE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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

        public ObservableCollection<OST> GetAllOST_ControlLaboralCtta(string IDEMPRESA, string PERIODO)
        {
            try
            {
                ObservableCollection<OST> items = new ObservableCollection<OST>();
                OST item = new OST();
                Instance.DAAsignarProcedure("V4MVC_OST_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
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

        public ObservableCollection<OST> GetAllOST_v2_ControlLaboralCtta(string IDEMPRESA, string DIVISION)
        {
            try
            {
                ObservableCollection<OST> items = new ObservableCollection<OST>();
                OST item = new OST();
                //V4MVC_OST_SELECT2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_OST_SELECT_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
        #endregion

        #region [ Metodos ]
        public bool UpdateOST_ContratOSTCtta(Guid ID_ARCHIVO, int index, string NROOST)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_OST_UPDATE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@ID_ARCHIVO", ID_ARCHIVO, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INDEX", index, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
