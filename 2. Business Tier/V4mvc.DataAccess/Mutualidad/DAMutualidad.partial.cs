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
	public partial class DAMutualidad
	{
        #region [ Consultas ]

        public ObservableCollection<Mutualidad> GetMutualidadDocumentacionCtta(int ID_DOC)
        {
            try
            {
                ObservableCollection<Mutualidad> items = new ObservableCollection<Mutualidad>();
                Mutualidad item = new Mutualidad();
                Instance.DAAsignarProcedure("V4MVC_MUTUALIDAD_SELECT_DOCUMENTACION_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Mutualidad();
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
