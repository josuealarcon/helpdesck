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
	public partial class DAE200_Datos
	{
        #region [ Consultas ]
        public ObservableCollection<E200_Datos> GetAllE200_DatosCtta(ref E200_Datos e200_Datos)
        {
            try
            {
                var items = new ObservableCollection<E200_Datos>();
                Instance.DAAsignarProcedure("V4MVC_E200_DATOS_SELECT_LISTADOCTTA");
                Instance.DAAgregarParametro("@START", e200_Datos.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", e200_Datos.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", e200_Datos.COLUMN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECCION", e200_Datos.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GLOSA", e200_Datos.COL0, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", e200_Datos.COL1, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DETALLE", e200_Datos.COL2, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", e200_Datos.COL3, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAMOD", e200_Datos.COL4, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", e200_Datos.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TAB", e200_Datos.TAB, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new E200_Datos();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                e200_Datos.COUNT = items.Count > 0 ? items[0].COUNT : 0;
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
