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
	public partial class DALotePases
	{
        #region [ Consultas ]

        public ObservableCollection<LotePases> GetAllLotePases_PasesMdte(ref LotePases modelo)
        {
            try
            {
                ObservableCollection<LotePases> items = new ObservableCollection<LotePases>();
                LotePases item = new LotePases();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_SELECT_PASES_MDTE");

                Instance.DAAgregarParametro("@LOTENUM", modelo.STR_LOTENUM, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOTEESTADO", modelo.LOTEESTADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOTEFINICIO", modelo.LOTEFINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOTEFFINAL", modelo.LOTEFFINAL, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", modelo.NROOST, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", modelo.DIVISION, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOTEGLOSA", modelo.LOTEGLOSA, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                Instance.DAAgregarParametro("@GRUPO", modelo.GRUPO, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MES_ACTUAL", modelo.MES_ACTUAL, SqlDbType.Bit, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PROPIOS", modelo.PROPIOS, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDACION", modelo.VALIDACION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISIONES", modelo.DIVISIONES, SqlDbType.NVarChar, 2000, ParameterDirection.Input);
                
                Instance.DAAgregarParametro("@START", modelo.START, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", modelo.LENGTH, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", modelo.SORT_COLUMN, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", modelo.SORT_DIRECTION, SqlDbType.NVarChar, 5, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LotePases();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }

                modelo.COUNT = items.Count > 0 ? items[0].COUNT : 0;

                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePases_PasesMdte(ref LotePases modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_SELECT_ONE_PASES_MDTE");
                
                Instance.DAAgregarParametro("@LOTENUM", modelo.LOTENUM, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GRUPO", modelo.GRUPO, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDACION", modelo.VALIDACION, SqlDbType.NVarChar, 30, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, modelo);
                        modelo.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return modelo;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePase_CertificacionMdte(int IDPASE)
        {
            var modelo = new LotePases();
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_SELECT_ONE_CERTIFICACION_MDTE");

                Instance.DAAgregarParametro("@IDPASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, modelo);
                        modelo.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return modelo;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePase_Validacion_CertificacionMdte(int IDPASE)
        {
            var modelo = new LotePases();
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_SELECT_ONE_VALIDACION_CERTIFICACION_MDTE");

                Instance.DAAgregarParametro("@IDPASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, modelo);
                        modelo.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return modelo;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
