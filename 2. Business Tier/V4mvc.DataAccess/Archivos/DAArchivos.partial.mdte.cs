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
	public partial class DAArchivos
	{
        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        public bool SaveArchivo_Mdte(ref Archivos item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_ARCHIVOS_INSERT_MDTE");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("_SU_UnReg");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput);
                        Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 255, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPOCONTENIDO", item.TIPOCONTENIDO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ARCHIVO", item.ARCHIVO, SqlDbType.Image, 2147483647, ParameterDirection.Input);
                    }

                    if (Instance.DAExecuteNonQuery() > 0)
                    {
                        item.ID = Guid.Parse(Instance.DASqlCommand.Parameters["@ID"].Value.ToString());
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
