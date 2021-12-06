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
	public partial class DAAAQ_Categorias
	{
        #region [ Consultas ]
        public ObservableCollection<AAQ_Categorias> GetListCategoriasPorRegimen_Mdte(int IDREGIMEN)
        {
            try
            {
                var items = new ObservableCollection<AAQ_Categorias>();
                Instance.DAAsignarProcedure("V4MVC_AAQ_Q04891_CATEGORIAS_SELECT_PORREGIMEN_MDTE");
                Instance.DAAgregarParametro("@IDREGIMEN", IDREGIMEN, SqlDbType.Int, 4, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new AAQ_Categorias();
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

        #region [ Métodos ]

        public bool SaveUpdateCategoria_Mdte(ref AAQ_Categorias item)
        {
            try
            {
                Instance.DAAsignarProcedure("[V4MVC_AAQ_Q04891_CATEGORIAS_INSERT_UPDATE_MDTE]");
                Instance.DAAgregarParametro("@IDREGIMEN",Convert.ToInt64(item.IDREGIMEN), SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLASIFICACION", item.CLASIFICACION, SqlDbType.NVarChar, 40, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDCATEGORIA", Convert.ToInt64(item.IDCATEGORIA), SqlDbType.Int, 4, ParameterDirection.Input);
            
                
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarCategoria_Mdte(int IDREGIMEN, string NOMBRE, int IDCATEGORIA)
        {
            try
            {
                Instance.DAAsignarProcedure("[V4MVC_AAQ_Q04891_CATEGORIAS_VALIDARDATOS_MDTE]");
                Instance.DAAgregarParametro("@IDREGIMEN", IDREGIMEN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDCATEGORIA", IDCATEGORIA, SqlDbType.Int, 4, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() == 1 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
