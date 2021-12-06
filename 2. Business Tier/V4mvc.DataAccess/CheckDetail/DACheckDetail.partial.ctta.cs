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
	public partial class DACheckDetail
	{
        #region [ Consultas ]

        public ObservableCollection<CheckDetail> GetPreguntasListadoEncuestas_Ctta(int ID_CHECKINGHEAD)
        {
            try
            {
                ObservableCollection<CheckDetail> items = new ObservableCollection<CheckDetail>();
                CheckDetail item = new CheckDetail();
                Instance.DAAsignarProcedure("V4MVC_CHECK_DETAIL_PREGUNTAS_LISTADO_ENCUESTAS_COVID_CTTA");
                Instance.DAAgregarParametro("@ID_CHECKINGHEAD", ID_CHECKINGHEAD, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CheckDetail();
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
