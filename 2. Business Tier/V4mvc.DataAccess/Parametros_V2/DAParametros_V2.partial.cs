
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAParametros_V2
    {
        #region [ Consultas ]
        public Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(int Id_Parametro)
        {
            try
            {
                Parametros_V2 item = new Parametros_V2();
                Instance.DAAsignarProcedure("V4MVC_PARAMETROS_V2_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@Id_Parametro", Id_Parametro, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public Parametros_V2 GetOneParametros_V2_ControlLaboralCtta(string DESCRIPCION)
        {
            try
            {
                Parametros_V2 item = new Parametros_V2();
                Instance.DAAsignarProcedure("V4MVC_PARAMETROS_V2_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@DESCRIPCION", DESCRIPCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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

        public Parametros_V2 GetParametros_SubidaDocsCtta(int ID_DOC, string DIVCOD, string RUT, string IDEMPRESA) {
            try
            {
                Parametros_V2 item = new Parametros_V2();
                Instance.DAAsignarProcedure("V4MVC_PARAMETROS_V2_SELECT_SUBIDADOCS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return item; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        #endregion

        #region [ func_getdatos V3 ]

        public Parametros_V2 GetParametrov2Descripcion(string DESCRIPCION)
        {
            try
            {
                Parametros_V2 item = new Parametros_V2();
                Instance.DAAsignarProcedure("V4MVC_PARAMETROS_V2_SELECT_BY_DESCRIPCION_CTTA");
                Instance.DAAgregarParametro("@DESCRIPCION", DESCRIPCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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
    }
}
	