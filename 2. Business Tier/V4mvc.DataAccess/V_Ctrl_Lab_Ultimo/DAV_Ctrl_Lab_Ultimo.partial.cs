
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
    public partial class DAV_Ctrl_Lab_Ultimo
    {
        #region [ Consultas ]
        public ObservableCollection<V_Ctrl_Lab_Ultimo> GetControlesUltimos_ControlLaboralCtta(string IDEMPRESA, int ID_DOC)
        {
            try
            {
                ObservableCollection<V_Ctrl_Lab_Ultimo> items = new ObservableCollection<V_Ctrl_Lab_Ultimo>();
                V_Ctrl_Lab_Ultimo item = new V_Ctrl_Lab_Ultimo();
                Instance.DAAsignarProcedure("V4MVC_CLABORAL_ULTIMO_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new V_Ctrl_Lab_Ultimo();
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
	