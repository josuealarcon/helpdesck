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
    public partial class DAGerencia
    {
        #region [ Consultas ]
        public Gerencia GetOneAutocomplete(String LIKE_GERENCIA)
        {
            try
            {
                Gerencia item = new Gerencia();
                Instance.DAAsignarProcedure("V4MVC_GERENCIA_SELECT_AUTOCOMPLETE");
                Instance.DAAgregarParametro("@LIKE_GERENCIA", LIKE_GERENCIA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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