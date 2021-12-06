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
	public partial class DATab_TipoContrato
	{
        #region [ Consultas ]

        public ObservableCollection<Tab_TipoContrato> GetTiposContratoDocumentacionCtta(string RUT,string DIVCOD,string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Tab_TipoContrato> items = new ObservableCollection<Tab_TipoContrato>();
                Tab_TipoContrato item = new Tab_TipoContrato();
                Instance.DAAsignarProcedure("V4MVC_TAB_TIPOCONTRATO_SELECT_DOCUMENTACION_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Tab_TipoContrato();
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
