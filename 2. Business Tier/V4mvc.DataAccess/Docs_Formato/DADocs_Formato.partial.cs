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
	public partial class DADocs_Formato
	{
        #region [ Consultas ]

        public ObservableCollection<Docs_Formato> GetDocsFormatDocumentacionCtta(int ID_DOC)
        {
            try
            {
                ObservableCollection<Docs_Formato> items = new ObservableCollection<Docs_Formato>();
                Docs_Formato item = new Docs_Formato();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FORMATO_SELECT_DOCUMENTACION_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Formato();
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

        public bool ExistsDocsFormato_ContratOSTCtta(string EXTENSION, int index)
        {
            int result = 0;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_FORMATO_SELECT_ONE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@INDEX", index, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXTENSION", EXTENSION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXISTE_QUERY", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAExecuteNonQuery();
                if (Instance.DASqlCommand.Parameters["@EXISTE_QUERY"].Value != null)
                {
                    result = Int32.Parse(Instance.DASqlCommand.Parameters["@EXISTE_QUERY"].Value.ToString());
                }
                return result == 1;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs_Formato GetDocumentoExtensionesCtta(int ID_DOC)
        {
            try
            {
                Docs_Formato item = new Docs_Formato();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FORMATO_SELECT_EXTENSIONES_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
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

        #endregion
    }
}
