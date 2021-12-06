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
	public partial class DATypeTrans
	{
        #region [ Consultas ]


        public ObservableCollection<TypeTrans> GetAllTypeTrans_CertificacionMdte()
        {
            try
            {
                ObservableCollection<TypeTrans> items = new ObservableCollection<TypeTrans>();
                TypeTrans item = new TypeTrans();
                Instance.DAAsignarProcedure("V4MVC_TYPETRANS_SELECT_CERTIFICACION_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new TypeTrans();
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
		
		
        public ObservableCollection<TypeTrans> GetListTypeTrans_Mdte()
        {
            try
            {
                ObservableCollection<TypeTrans> items = new ObservableCollection<TypeTrans>();
                TypeTrans item = new TypeTrans();
                Instance.DAAsignarProcedure("V4MVC_TYPETRANS_SELECT_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new TypeTrans();
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
