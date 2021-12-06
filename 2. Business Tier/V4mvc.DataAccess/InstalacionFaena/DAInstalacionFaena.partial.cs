
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
    public partial class DAInstalacionFaena
    {
        #region [ Consultas ]
        public InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST)
        {
            try
            {
                InstalacionFaena item = new InstalacionFaena();
                Instance.DAAsignarProcedure("V4MVC_INSTALACION_FAENA_SELECT_ONE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
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

        public InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL)
        {
            try
            {
                InstalacionFaena item = new InstalacionFaena();
                //V4MVC_INSTALACION_FAENA_SELECT_ONE2_CONTRATOST_CTTA
                Instance.DAAsignarProcedure("V4MVC_INSTALACION_FAENA_SELECT_ONE_V2_CONTRATOST_CTTA");
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
                    { throw new Exception("No se encontro el registro.");
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion
    }
}
	