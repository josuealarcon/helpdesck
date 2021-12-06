
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
    public partial class DAOSTSubc
    {
        #region [ Consultas ]
        public ObservableCollection<OSTSubc> GetAllOSTSubC_ContratOSTCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<OSTSubc> items = new ObservableCollection<OSTSubc>();
                OSTSubc item = new OSTSubc();
                Instance.DAAsignarProcedure("V4MVC_OSTSUBC_SELECT_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new OSTSubc();
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
	