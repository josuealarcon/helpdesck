
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
    public partial class DAVideos
    {
        #region [ Consultas ]
        public Videos GetOneVideos(string ID)
        {
            try
            {
                Videos item = new Videos();
                Instance.DAAsignarProcedure("V4MVC_VIDEOS_SELECT_ONE_VISORVIDEO");
                Instance.DAAgregarParametro("@ID_VIDEO", ID, SqlDbType.NVarChar, 18, ParameterDirection.Input);
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

        public Videos GetOneVideos_VideosMdte(string ID)
        {
            try
            {
                Videos item = new Videos();
                Instance.DAAsignarProcedure("V4MVC_VIDEOS_SELECT_ONE_VIDEOS_MDTE");
                Instance.DAAgregarParametro("@ID_VIDEO", ID, SqlDbType.NVarChar, 18, ParameterDirection.Input);
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

        public ObservableCollection<Videos> GetAllVideos_VideosMdte()
        {
            try
            {
                ObservableCollection<Videos> items = new ObservableCollection<Videos>();
                Videos item = new Videos();
                Instance.DAAsignarProcedure("V4MVC_VIDEOS_SELECT_VIDEOS_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Videos();
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

        public bool SaveVideos_VideosMdte(ref Videos video)
        {
            try
            {
                if (video.Instance != InstanceEntity.Unchanged)
                {
                    
                    if (video.Instance == InstanceEntity.New || video.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAsignarProcedure("V4MVC_VIDEOS_UPSERT_VIDEOS_MDTE");
                        Instance.DAAgregarParametro("@STR_ID", video.STR_ID, SqlDbType.NVarChar, 18, ParameterDirection.InputOutput);
                        Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", video.NOMBRE_ARCHIVO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPO_CONTENIDO", video.TIPO_CONTENIDO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO", video.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ARCHIVO", video.ARCHIVO, SqlDbType.Image, 2147483647, ParameterDirection.Input);

                        Instance.DAAgregarParametro("@MODULO_V4", video.MODULO_V4, SqlDbType.Int, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@VISTA_LINK", video.VISTA_LINK, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@VERSION", video.VERSION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DESCRIPCION", video.DESCRIPCION, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@PRIVADO", video.PRIVADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                    }

                    if (Instance.DAExecuteNonQuery() > 0)
                    {
                        video.STR_ID = Instance.DASqlCommand.Parameters["@STR_ID"].Value.ToString();
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
	