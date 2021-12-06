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
    public partial class DACursosSalas
    {

        #region [ Consultas ]

        public ObservableCollection<CursosSalas> GetSalasMdteSearcherMdte(ref CursosSalas model)
        {
            try
            {
                ObservableCollection<CursosSalas> items = new ObservableCollection<CursosSalas>();
                CursosSalas item = new CursosSalas();
                Instance.DAAsignarProcedure("V4MVC_A036_CURSOSALAS_BUSCAR_SALAS_MDTE");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                Instance.DAAgregarParametro("@LUGAR", model.LUGAR, SqlDbType.NVarChar, 90, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SALA", model.SALA, SqlDbType.NVarChar, 40, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CAPACIDAD", model.CAPACIDAD, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CursosSalas();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                model.COUNT = items.Count > 0 ? items[0].COUNT : 0;
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
