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

        public ObservableCollection<Docs_ControlAcceso_Laboral> GetDocs_ControlAcceso_LaboralHistorico(int ID_DOC,string RUT)
        {
            try
            {
                ObservableCollection<Docs_ControlAcceso_Laboral> items = new ObservableCollection<Docs_ControlAcceso_Laboral>();
                Docs_ControlAcceso_Laboral item = new Docs_ControlAcceso_Laboral();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_SELECT_HISTORICO");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_ControlAcceso_Laboral();
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

        public Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_LaboralDisputa(string RUT,string FECHA_INI,string FECHA_FIN,int ID_DOC,int ID_DISPUTA)
        {
            try
            {
                Docs_ControlAcceso_Laboral item = new Docs_ControlAcceso_Laboral();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_SELECT_DISPUTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_INI", FECHA_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_FIN", FECHA_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_ControlAcceso_Laboral();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs_ControlAcceso_Laboral GetDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT, string FECHA_INI, string FECHA_FIN, int ID_DOC)
        {
            try
            {
                Docs_ControlAcceso_Laboral item = new Docs_ControlAcceso_Laboral();
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_SELECT_DISPUTA_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_INI", FECHA_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_FIN", FECHA_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_ControlAcceso_Laboral();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertDocs_ControlAcceso_Laboral_Disputa_FuncionariosCtta(string RUT,string FECHA_INI, string FECHA_FIN, int ID_DOC, string OBSERVACION, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_DISPUTA_INSERT_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_INI", FECHA_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_FIN", FECHA_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION", OBSERVACION, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }


        public bool Delete_Docs_ControlAcceso_Laboral_FuncionariosCtta(int ID, int ID_DISPUTA, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_CONTROLACCESO_LABORAL_DELETE_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

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
