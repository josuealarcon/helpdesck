
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
    public partial class DAOSTDivLocal
    {
        #region [ Consultas ]
        public ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_ContratOSTCtta(string NROOST)
        {
            try
            {
                ObservableCollection<OSTDivLocal> items = new ObservableCollection<OSTDivLocal>();
                OSTDivLocal item = new OSTDivLocal();
                Instance.DAAsignarProcedure("V4MVC_OSTDIVLOCAL_SELECT_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new OSTDivLocal();
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
	