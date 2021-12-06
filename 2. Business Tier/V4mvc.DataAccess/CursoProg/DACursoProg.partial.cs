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
    public partial class DACursoProg
    {
        #region [ Consultas ]

        public ObservableCollection<CursoProg> GetAllCursosProgCtta()
        {
            try
            {
                ObservableCollection<CursoProg> items = new ObservableCollection<CursoProg>();
                CursoProg item = new CursoProg();
                Instance.DAAsignarProcedure("V4MVC_A141_CURSOS_SELECT_CTTA");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CursoProg();
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
        public ObservableCollection<CursoProg> GetListCargarCursosCtta(CursoProg model)
        {
            try
            {
                ObservableCollection<CursoProg> items = new ObservableCollection<CursoProg>();
                CursoProg item = new CursoProg();
                Instance.DAAsignarProcedure("V4MVC_A141_CURSOS_SELECT_LISTAR_CARGAR_CURSOS_CTTA");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", model.COL0, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CHARLA", model.COL1, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PARTICIPANTES", model.COL2, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO", model.COL3, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CursoProg();
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

        #region [ Informes ]
        public ObservableCollection<CursoProg> GetCursoProg_Grid_CharlasyReservas_InformeFuncionariosCtta(CursoProg request)
        {
            try
            {
                ObservableCollection<CursoProg> items = new ObservableCollection<CursoProg>();
                CursoProg item = new CursoProg();
                Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_SELECT_CHARLASYRESERVAS_INFORMEFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", request.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", request.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CURSO", request.CURSO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", request.DIVISION, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", request.EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CursoProg();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        item.PARTICIPANTES_REPORTE=int.Parse(item.PARTICIPANTES);
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

        #endregion

    }
}
