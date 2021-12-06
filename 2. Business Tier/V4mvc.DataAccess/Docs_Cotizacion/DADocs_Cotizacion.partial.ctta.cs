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
	public partial class DADocs_Cotizacion
	{
		#region [ Consultas ]
        public ObservableCollection<Docs_Cotizacion> GetAllDocs_CotizacionCtta(ref Docs_Cotizacion docs_Cotizacion)
        {
            try
            {
                var items = new ObservableCollection<Docs_Cotizacion>();
                Instance.DAAsignarProcedure("V4MVC_DOCS_COTIZACION_SELECT_LISTADOCTTA");
                Instance.DAAgregarParametro("@START", docs_Cotizacion.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", docs_Cotizacion.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", docs_Cotizacion.COLUMN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECCION", docs_Cotizacion.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", docs_Cotizacion.COL0, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GLOSA", docs_Cotizacion.COL1, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", docs_Cotizacion.COL2, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NTIPO", docs_Cotizacion.COL3, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", docs_Cotizacion.COL4, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAMOD", docs_Cotizacion.COL5, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", docs_Cotizacion.COL6, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", docs_Cotizacion.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TAB", docs_Cotizacion.TAB, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Docs_Cotizacion();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                docs_Cotizacion.COUNT = items.Count > 0 ? items[0].COUNT : 0;
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
