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
	public partial class DADocs_Disputa 
	{
		     

        #region [ Consultas ]

        public ObservableCollection<Docs_Disputa> GetListDocsDisputa_Mdte(ref Docs_Disputa item)
        {
            try
            {
                var items = new ObservableCollection<Docs_Disputa>();
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_SELECT_LISTDOCSDISPUTA_MDTE");
                Instance.DAAgregarParametro("@START", item.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", item.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", item.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", item.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", item.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBREDOCUMENTO", item.NOMBREDOCUMENTO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", item.DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORA", item.HORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
               
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Disputa();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                item.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }


       public Docs_Disputa GetOneDocsDisputaFuncionario_Mdte(string IDDISPUTA)
        {
            try
            {
                var item = new Docs_Disputa();
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_SELECT_ONE_FUNCIONARIOSDISPUTA_MDTE");
                Instance.DAAgregarParametro("@ID_DISPUTA", IDDISPUTA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

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
        public Docs_Disputa GetOneDocsDisputaVehiculo_Mdte(string IDDISPUTA , string PATENTE)
        {
            try
            {
                var item = new Docs_Disputa();
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_SELECT_ONE_VEHICULOSDISPUTA_MDTE");
                Instance.DAAgregarParametro("@IDDISPUTA", IDDISPUTA, SqlDbType.Int, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 50, ParameterDirection.Input);

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
        
        public bool SaveDocDisputaFuncionario(Docs_Disputa item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_UPDATE_FUNCIONARIO_MDTE");
                Instance.DAAgregarParametro("@OBSERVACION_REVAL", item.OBSERVACION, SqlDbType.NVarChar, 2000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REVALUSUARIO", item.USUARIO, SqlDbType.Int, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", item.ID_DISPUTA, SqlDbType.Int, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN_DIV", item.COMUN_DIV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                
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
