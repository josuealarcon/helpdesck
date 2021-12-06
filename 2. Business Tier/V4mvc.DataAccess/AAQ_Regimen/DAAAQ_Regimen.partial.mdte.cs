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
	public partial class DAAAQ_Regimen
	{
        #region [ Consultas ]

        public ObservableCollection<AAQ_Regimen> GetListRegimenesPorCategoria_Mdte(int IDCATEGORIA)
        {
            try
            {
                var items = new ObservableCollection<AAQ_Regimen>();
                Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_REGIMEN_SELECT_PORCATEGORIA_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new AAQ_Regimen();
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

        /*  public ObservableCollection<OSTArbol> GetOSTsPorEmpresa(string IDEMPRESA)
          {
              try
              {
                  ObservableCollection<OSTArbol> items = new ObservableCollection<OSTArbol>();
                  OSTArbol item = new OSTArbol();
                  Instance.DAAsignarProcedure("V4MVC_OSTARBOL_SELECT_BYEMPRESA_CTTA");
                  Instance.DAAgregarParametro("@EMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                  using (IDataReader reader = Instance.DAExecuteReader())
                  {
                      while (reader.Read())
                      {
                          item = new OSTArbol();
                          Loader.LoadEntity(reader, item);
                          item.Instance = InstanceEntity.Unchanged;
                          items.Add(item);
                      }
                  }
                  return items;
              }
              catch (Exception ex)
              { throw ex; }
          }*/


        #endregion

        #region [ Metodos ]

        #endregion
    }
}
