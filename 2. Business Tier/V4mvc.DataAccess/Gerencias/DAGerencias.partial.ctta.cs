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
	public partial class DAGerencias
	{
        #region [ Consultas ]
        public ObservableCollection<Gerencias> GetGerenciasPorGGeneral(Gerencias model)
        {
            try
            {
                var items = new ObservableCollection<Gerencias>();
                Instance.DAAsignarProcedure("V4MVC_GERENCIAS_POR_GGENERAL_SELECT");
                Instance.DAAgregarParametro("@IDGENERAL", model.IDGENERAL, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Gerencias();
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
