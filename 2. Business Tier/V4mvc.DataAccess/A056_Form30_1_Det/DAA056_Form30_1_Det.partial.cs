
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
    public partial class DAA056_Form30_1_Det
    {
        #region [ Consultas ]
        public ObservableCollection<A056_Form30_1_Det> GetFormF30Detalles_ControlLaboralCtta(string EMPRESA, string ID_CERTIFICADO)
        {
            try
            {
                ObservableCollection<A056_Form30_1_Det> items = new ObservableCollection<A056_Form30_1_Det>();
                A056_Form30_1_Det item = new A056_Form30_1_Det();
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_DET_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", ID_CERTIFICADO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A056_Form30_1_Det();
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
        public bool SaveFormF301Detail_ControlLaboralCtta(A056_Form30_1_Det model)
        {
            try
            {

                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_DET_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_CERTIFICADO", model.ID_CERTIFICADO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NRO_TRAB_PAG", model.NRO_TRAB_PAG, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MONTO_PAGADO", model.MONTO_PAGADO, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NRO_TRAB_NOPAG", model.NRO_TRAB_NOPAG, SqlDbType.Int, 8, ParameterDirection.Input);

                Instance.DAExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
	