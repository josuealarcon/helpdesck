
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
    public partial class DADocs_Disputa_CLaboral
    {
        #region [ Consultas ]
        public Docs_Disputa_CLaboral GetOneDocsDisputaCLab_ControlLaboralCtta(int DISPUTA_ID)
        {
            try
            {
                Docs_Disputa_CLaboral item = new Docs_Disputa_CLaboral();
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_CLABORAL_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@DISPUTA_ID", DISPUTA_ID, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public bool SaveDocDisputaCLab_ControlLaboralCtta(ref Docs_Disputa_CLaboral instance)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_CLABORAL_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID", instance.ID, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", instance.ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", instance.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", instance.EMPRESA, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", instance.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", instance.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION", instance.OBSERVACION, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", instance.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTUSUARIO", instance.CERTUSUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTFECHA", instance.CERTFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTHORA", instance.CERTHORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", instance.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTIFICADO_ID", instance.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);

                Instance.DAAgregarParametro("@DISPUTA_ID", -1, SqlDbType.Int, 8, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_ID"].Value != null)
                    {
                        instance.ID_DISPUTA = Int32.Parse(Instance.DASqlCommand.Parameters["@DISPUTA_ID"].Value.ToString());
                    }

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
	