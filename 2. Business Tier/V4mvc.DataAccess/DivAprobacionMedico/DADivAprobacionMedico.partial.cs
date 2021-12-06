
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
    public partial class DADivAprobacionMedico
    {
        #region [ Consultas ]
        public DivAprobacionMedico GetOneDivAprobacionMedico_PasesCtta(string DIVCOD)
        {
            try
            {
                DivAprobacionMedico item = new DivAprobacionMedico();
                Instance.DAAsignarProcedure("V4MVC_DIVISION_APROBACION_MEDICO_SELECT_ONE_PASES_CTTA");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
	