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
	public partial class DADocs_ControlAcceso_Laboral
	{
        #region [ Consultas ]
        public Docs_ControlAcceso_Laboral GetOneControlAccesoLaboral_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID)
        {
            try
            {
                var item = new Docs_ControlAcceso_Laboral();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_SELECT_CONTROLACCESODISPUTA_MDTE");
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);

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
        public Docs_ControlAcceso_Laboral GetOneControlAccesoLaboralSendAlert_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID_ARCHIVO)
        {
            try
            {
                var item = new Docs_ControlAcceso_Laboral();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_SELECT_SENDALERT_MDTE");
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_ARCHIVO", ID_ARCHIVO, SqlDbType.UniqueIdentifier, 50, ParameterDirection.Input);

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
        public bool SaveDocsDisputaControlAcceso(Docs_ControlAcceso_Laboral item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONROLACCESO_LABORAL_UPDATE_MDTE");
                Instance.DAAgregarParametro("@ID_DISPUTA", item.ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION_REVAL", item.OBSERVACION, SqlDbType.NVarChar, 2000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REVALUSUARIO", item.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }

        }
        #endregion
    }
}
