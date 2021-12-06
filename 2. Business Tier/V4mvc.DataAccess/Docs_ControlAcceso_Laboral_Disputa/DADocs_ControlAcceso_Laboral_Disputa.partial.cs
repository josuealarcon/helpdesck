using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Globalization;

namespace V4mvc.DataAccess
{
	public partial class DADocs_ControlAcceso_Laboral_Disputa
	{
        #region [ Consultas ]
        public Docs_ControlAcceso_Laboral_Disputa GetDocs_ControlAcceso_Laboral_Disputa_Top(string RUT,string FECHA_INI,string FECHA_FIN,string EMPRESA,int ID_DOC, Guid ID)
        {
            try
            {
                Docs_ControlAcceso_Laboral_Disputa item = new Docs_ControlAcceso_Laboral_Disputa();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_DISPUTA_SELECT_TOP");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_INI", FECHA_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_FIN", FECHA_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);                         
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

        public Docs_ControlAcceso_Laboral_Disputa GetDocs_ControlAcceso_Laboral_Disputa_EstadoNo(int ID_DISPUTA)
        {
            try
            {
                Docs_ControlAcceso_Laboral_Disputa item = new Docs_ControlAcceso_Laboral_Disputa();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_DISPUTA_SELECT_ESTADONO");
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);                
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
        public bool Docs_ControlAcceso_Laboral_Disputa_Delete_EstadoNo(int ID_DISPUTA)
        {
            try
            {
                Docs_ControlAcceso_Laboral_Disputa item = new Docs_ControlAcceso_Laboral_Disputa();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_DISPUTA_DELETE_ESTADONO");
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
