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
	public partial class DADocs_TipoPase
	{
        #region [ Consultas ]
        public ObservableCollection<Docs_TipoPase> GetDocsTipoPaseDivision(string DIVCOD)
        {
            try
            {
                ObservableCollection<Docs_TipoPase> items = new ObservableCollection<Docs_TipoPase>();
                Docs_TipoPase item = new Docs_TipoPase();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPOPASE_SELECT_DIVISION");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_TipoPase();
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

        public ObservableCollection<Docs_TipoPase> GetFecDocsTipoPaseDivision(string DIVCOD)
        {
            try
            {
                ObservableCollection<Docs_TipoPase> items = new ObservableCollection<Docs_TipoPase>();
                Docs_TipoPase item = new Docs_TipoPase();
                Instance.DAAsignarProcedure("V4MVC_FEC_DOCS_TIPOPASE_SELECT_DIVISION");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_TipoPase();
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

        #endregion
    }
}
