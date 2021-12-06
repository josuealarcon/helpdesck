
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
    public partial class DAModulos_Videos_v4
    {
        #region [ Consultas ]

        public ObservableCollection<Modulos_Videos_v4> GetAllModulosVideosV4_VideosMdte()
        {
            try
            {
                ObservableCollection<Modulos_Videos_v4> items = new ObservableCollection<Modulos_Videos_v4>();
                Modulos_Videos_v4 item = new Modulos_Videos_v4();
                Instance.DAAsignarProcedure("V4MVC_MODULOS_VIDEOS_V4_SELECT_VIDEOS_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Modulos_Videos_v4();
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

        public bool SaveModuloVideoV4_VideosMdte(ref Modulos_Videos_v4 modelo)
        {
            try
            {
                modelo.RET_RESULTADO = -1;
                Instance.DAAsignarProcedure("V4MVC_MODULOS_VIDEOS_V4_INSERT_VIDEOS_MDTE");
                Instance.DAAgregarParametro("@NOMBRE_MODULO", modelo.MODULO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GLOSA", modelo.MODULO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVO", modelo.MODULO, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                Instance.DAAgregarParametro("@RET_RESULTADO", modelo.RET_RESULTADO, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@NUEVO_ID", modelo.ID, SqlDbType.Int, 8, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@NUEVO_ID"].Value != null)
                    {
                        modelo.ID = Int32.Parse(Instance.DASqlCommand.Parameters["@NUEVO_ID"].Value.ToString());
                    }
                    if (Instance.DASqlCommand.Parameters["@RET_RESULTADO"].Value != null)
                    {
                        modelo.RET_RESULTADO = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_RESULTADO"].Value.ToString());
                    }
                    return !(modelo.RET_RESULTADO > 0);
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
	