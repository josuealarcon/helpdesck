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
    public partial class DATurno_Disputa
    {
        #region [ Consultas ]

        public Turno_Disputa GetOneTurnoDisputa(int ID_TURNO, int ID_DISPUTA)
        {
            try
            {
                Turno_Disputa item = new Turno_Disputa();
                Instance.DAAsignarProcedure("V4MVC_TURNO_SELECT_ONE_DISPUTA_TURNOS_CTTA");
                Instance.DAAgregarParametro("@ID_TURNO", ID_TURNO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 8, ParameterDirection.Input);
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
        public bool SaveTurnoDisputa(ref Turno_Disputa item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_TURNO_DISPUTA_INSERT_TURNOS_CTTA");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("_ID_DSU_UnReg");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New)
                    {
                        Instance.DAAgregarParametro("@IDTURNO", item.IDTURNO, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@OBSERVACION", item.OBSERVACION, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_DISPUTA", item.ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                    }

                    if (Instance.DAExecuteNonQuery() > 0)
                    {
                        item.ID_DISPUTA = Convert.ToInt32(Instance.DASqlCommand.Parameters["@ID_DISPUTA"].Value.ToString());
                        return true;
                    }
                    else
                    { return false; }
                }
                else
                { return true; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
