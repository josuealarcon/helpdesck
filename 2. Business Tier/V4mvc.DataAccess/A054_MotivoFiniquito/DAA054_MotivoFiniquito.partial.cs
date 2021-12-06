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
	public partial class DAA054_MotivoFiniquito
	{
        #region [ Consultas ]

        public ObservableCollection<A054_MotivoFiniquito> GetA054_MotivoFiniquitosCertificacion(string RUT, int ID_DOC, string DIVCOD, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<A054_MotivoFiniquito> items = new ObservableCollection<A054_MotivoFiniquito>();
                A054_MotivoFiniquito item = new A054_MotivoFiniquito();
                Instance.DAAsignarProcedure("V4MVC_A054_MOTIVOFINIQUITO_SELECT_CERTIFICACION");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A054_MotivoFiniquito();
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

        public ObservableCollection<A054_MotivoFiniquito> GetMotivosFiniquito_FuncionariosCtta(string RUT, string EMPRESA)
        {
            try
            {
                ObservableCollection<A054_MotivoFiniquito> items = new ObservableCollection<A054_MotivoFiniquito>();
                A054_MotivoFiniquito item = new A054_MotivoFiniquito();
                Instance.DAAsignarProcedure("V4MVC_A054_MOTIVOFINIQUITO_SELECT_FUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A054_MotivoFiniquito();
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
