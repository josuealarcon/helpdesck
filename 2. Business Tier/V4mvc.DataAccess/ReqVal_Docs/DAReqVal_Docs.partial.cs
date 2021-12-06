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
	public partial class DAReqVal_Docs
	{
        #region [ Consultas ]

        public ObservableCollection<ReqVal_Docs> GetDocumentoRequisitos(int ID_DOC)
        {
            try
            {
                ObservableCollection<ReqVal_Docs> items = new ObservableCollection<ReqVal_Docs>();
                ReqVal_Docs item = new ReqVal_Docs();
                Instance.DAAsignarProcedure("V4MVC_REQVAL_DOCS_SELECT_DOCUMENTO_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new ReqVal_Docs();
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
