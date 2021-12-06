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
	public partial class DATransport_Division_Pases
	{
        #region [ Consultas ]

        public ObservableCollection<Transport_Division_Pases> GetTransportDivisionPasesAutorizados(string DIVCOD, string PATENTE)
        {
            try
            {
                ObservableCollection<Transport_Division_Pases> items = new ObservableCollection<Transport_Division_Pases>();
                Transport_Division_Pases item = new Transport_Division_Pases();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_DIVISION_PASES_SELECT_AUTORIZADO");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Transport_Division_Pases();
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
