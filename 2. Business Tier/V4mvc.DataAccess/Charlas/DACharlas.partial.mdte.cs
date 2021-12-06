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
    public partial class DACharlas
    {

        #region [ Consultas ]

        public ObservableCollection<Charlas> GetListCharlasDivision_Mdte(ref Charlas charlas)
        {
            try
            {
                var items = new ObservableCollection<Charlas>();
                Instance.DAAsignarProcedure("V4MVC_CHARLAS_SELECT_CHARLAS_MDTE");
                Instance.DAAgregarParametro("@START", charlas.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", charlas.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", charlas.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", charlas.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDCHARLA", charlas.COL0, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CHARLA", charlas.COL1, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIP", charlas.COL2, SqlDbType.NVarChar, 60, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORAS", charlas.COL4, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VENCIMIENTO", charlas.COL5, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBLIGATORIO", charlas.COL6, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PORCENTAJE", charlas.COL7, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISIONES", charlas.DIVISIONES, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", charlas.COL3, SqlDbType.NVarChar, 40, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        charlas = new Charlas();
                        Loader.LoadEntity(reader, charlas);
                        charlas.Instance = InstanceEntity.Unchanged;
                        items.Add(charlas);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Charlas GetOneCharla_Mdte(int IDCHARLA)
        {
            try
            {
                Charlas item = new Charlas();
                Instance.DAAsignarProcedure("V4MVC_CHARLAS_SELECTONE_CHARLA_MDTE");
                Instance.DAAgregarParametro("@IDCHARLA", IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        return null;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Charlas> GetCursosMdteSearcherMdte(ref Charlas model)
        {
            try
            {
                ObservableCollection<Charlas> items = new ObservableCollection<Charlas>();
                Charlas item = new Charlas();
                Instance.DAAsignarProcedure("V4MVC_CHARLAS_BUSCAR_CURSOS_MDTE");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                Instance.DAAgregarParametro("@CHARLA", model.CHARLA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIP", model.DESCRIP, SqlDbType.NVarChar, 120, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VENCIMIENTO", model.VENCIMIENTO, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Charlas();
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

        public bool SaveCharlas_Mdte(ref Charlas charlas)
        {

            try
            {
                if (charlas.Instance != InstanceEntity.Unchanged)
                {
                    switch (charlas.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_CHARLAS_INSERT_MDTE");
                            Instance.DAAgregarParametro("@IDCHARLA", charlas.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_CHARLAS_UPDATE_MDTE");
                            Instance.DAAgregarParametro("@IDCHARLA", charlas.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("V4MVC_CHARLAS_DELETE_MDTE");
                            Instance.DAAgregarParametro("@IDCHARLA", charlas.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
                            break;
                    }
                    if (charlas.Instance == InstanceEntity.New || charlas.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@CHARLA", charlas.CHARLA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DESCRIP", charlas.DESCRIP, SqlDbType.NVarChar, 60, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORAS", charlas.HORAS, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@VENCIMIENTO", charlas.VENCIMIENTO, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_DOC_FEC", charlas.ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@OBLIGATORIO", charlas.OBLIGATORIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_AREA", charlas.ID_AREA, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@PORCENTAJE", charlas.PORCENTAJE, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_CLASIFIACION", charlas.ID_CLASIFIACION, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_AMBITO", charlas.ID_AMBITO, SqlDbType.Int, 4, ParameterDirection.Input);
                    }

                    if (Instance.DAExecuteNonQuery() > 0)
                    {
                        if (Instance.DASqlCommand.Parameters["@IDCHARLA"].Value != null)
                        {
                            charlas.IDCHARLA = Int32.Parse(Instance.DASqlCommand.Parameters["@IDCHARLA"].Value.ToString());
                        }
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
