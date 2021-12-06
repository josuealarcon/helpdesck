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
        public ObservableCollection<TypeTrans> GetTypeTransCombo()
        {
            try
            {
                ObservableCollection<TypeTrans> items = new ObservableCollection<TypeTrans>();
                TypeTrans item = new TypeTrans();
                Instance.DAAsignarProcedure("V4MVC_TYPETRANS_SELECT_COMBO");
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

        public ObservableCollection<TypeTrans> GetTypeTrans_Informes()
        {
            try
            {
                ObservableCollection<TypeTrans> items = new ObservableCollection<TypeTrans>();
                TypeTrans item = new TypeTrans();
                Instance.DAAsignarProcedure("V4MVC_TYPETRANS_SELECT_INFORMES_CTTA");
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

        public TypeTrans GetOneTypeTrans_Informes(int IDTIPO)
        {
            try
            {
                TypeTrans item = new TypeTrans();
                Instance.DAAsignarProcedure("V4MVC_TYPETRANS_SELECT_ONE_INFORMES_CTTA");
                Instance.DAAgregarParametro("@IDTIPO", IDTIPO, SqlDbType.Int, 8, ParameterDirection.Input);
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

        #region [ Metodos ]

        #endregion
    }
}
