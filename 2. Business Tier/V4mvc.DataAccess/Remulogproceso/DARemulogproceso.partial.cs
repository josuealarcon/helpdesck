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
	public partial class DARemulogproceso
	{
        #region [ Consultas ]
        public ObservableCollection<Remulogproceso> Get_Remulogproceso_InformeDocumentosCargadosDetalle_InformeControlLaboralCtta(Remulogproceso Item)
        {
            try
            {
                ObservableCollection<Remulogproceso> items = new ObservableCollection<Remulogproceso>();
                Remulogproceso item = new Remulogproceso();
                Instance.DAAsignarProcedure("V4MVC_REMULOGPROCESO_SELECT_INFORME_DOCUMENTOSCARGADOSAUDITORIALABORALMENSUAL_DETALLE_INFORME_CONTROLLABAROAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", Item.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())            
                {
                    while (reader.Read())
                    {
                        item = new Remulogproceso();
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
