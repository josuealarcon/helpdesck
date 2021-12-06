using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DADocs_Enterprise
    {

        #region [ Consultas ]

        public ObservableCollection<Docs_Enterprise> GetInformeDocsPendientesEmpresaCtta(ref Docs_Enterprise model)
        {
            try
            {
                ObservableCollection<Docs_Enterprise> items = new ObservableCollection<Docs_Enterprise>();
                Docs_Enterprise item = new Docs_Enterprise();
                Instance.DAAsignarProcedure("V4MVC_INFORME_DOCS_PENDIENTES_EMPRESA_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Enterprise();
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

        #region [ Métodos ]

        #endregion

    }
}