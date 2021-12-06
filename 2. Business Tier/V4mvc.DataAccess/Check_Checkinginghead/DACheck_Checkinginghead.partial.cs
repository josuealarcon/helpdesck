using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DACheck_Checkinginghead
    {
        #region [ Consultas ]
        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklist_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                ObservableCollection<Check_Checkinginghead> items = new ObservableCollection<Check_Checkinginghead>();
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLIST_INFORME_CHECKLIST_CTTA");
                Instance.DAAgregarParametro("@PATENTE", Item.PATENTE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOVEHICULO", Item.TIPOVEHICULO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECK", Item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_INF1, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_INF1, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Check_Checkinginghead();
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

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeControlesChecklistDetalle_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                ObservableCollection<Check_Checkinginghead> items = new ObservableCollection<Check_Checkinginghead>();
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLISTDETALLE_INFORME_CHECKLIST_CTTA");
                Instance.DAAgregarParametro("@ID_CHECK", Item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECKING", Item.ID_CHECKING, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECKINGHEAD", Item.ID_CHECKINGHEAD, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Check_Checkinginghead();
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

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculo_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                ObservableCollection<Check_Checkinginghead> items = new ObservableCollection<Check_Checkinginghead>();
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLIST_TESTVEHICULO_INFORME_CHECKLIST_CTTA");
                Instance.DAAgregarParametro("@PATENTE", Item.PATENTE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOVEHICULO", Item.TIPOVEHICULO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECK", Item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_INF2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_INF2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO", Item.ESTADO, SqlDbType.NVarChar, 2, ParameterDirection.Input); ;
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Check_Checkinginghead();
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

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestVehiculoDetalle_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                ObservableCollection<Check_Checkinginghead> items = new ObservableCollection<Check_Checkinginghead>();
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLIST_TESTVEHICULODETALLE_INFORME_CHECKLIST_CTTA");
                Instance.DAAgregarParametro("@ID_TIPO", Item.ID_TIPO, SqlDbType.NVarChar, 3, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECK", Item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECKING", Item.ID_CHECKING, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECKINGHEAD", Item.ID_CHECKINGHEAD, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Check_Checkinginghead();
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

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistTestFatigaSomnolencia_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                ObservableCollection<Check_Checkinginghead> items = new ObservableCollection<Check_Checkinginghead>();
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLIST_TESTFATIGASOMNOLENCIA_INFORME_CHECKLIST_CTTA");
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECK", Item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_INF3, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_INF3, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO", Item.ESTADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Check_Checkinginghead();
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

        public ObservableCollection<Check_Checkinginghead> Get_Check_Checkinginghead_InformeChecklistPorPeriodo_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                ObservableCollection<Check_Checkinginghead> items = new ObservableCollection<Check_Checkinginghead>();
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLIST_PORPERIODOS_INFORME_CHECKLIST_CTTA");
                Instance.DAAgregarParametro("@ID_CHECK", Item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_INF4, SqlDbType.NVarChar, 7, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_INF4, SqlDbType.NVarChar, 7, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Check_Checkinginghead();
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

        public Check_Checkinginghead Get_Check_Checkinginghead_InformeChecklistTestVehiculoHead_ChecklistCtta(Check_Checkinginghead Item)
        {
            try
            {
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_SELECT_INFORME_CHECKLIST_TESTVEHICULO_INFORME_HEAD_CHECKLIST_CTTA");
                Instance.DAAgregarParametro("@ID_TIPO", Item.ID_TIPO, SqlDbType.NVarChar, 3, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECK", Item.ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECKING", Item.ID_CHECKING, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECKINGHEAD", Item.ID_CHECKINGHEAD, SqlDbType.Int, 4, ParameterDirection.Input);



                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new Check_Checkinginghead();
                    Loader.LoadEntity(reader, item);
                    item.Instance = InstanceEntity.Unchanged;

                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Check_Checkinginghead> GetListadoEncuestasCovidCtta(ref Check_Checkinginghead Item)
        {
            try
            {
                var items = new ObservableCollection<Check_Checkinginghead>();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_LISTADO_ENCUESTAS_COVID_SELECT_CTTA");
                Instance.DAAgregarParametro("@START", Item.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", Item.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", Item.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", Item.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                Instance.DAAgregarParametro("@RUT", Item.COL0, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.COL1, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.COL2, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.COL3, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", Item.COL4, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", Item.COL5, SqlDbType.NVarChar, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORA", Item.COL6, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RESULTADO", Item.COL7, SqlDbType.NVarChar, 4, ParameterDirection.Input);


                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item = new Check_Checkinginghead();
                        Loader.LoadEntity(reader, Item);
                        Item.Instance = InstanceEntity.Unchanged;
                        items.Add(Item);
                    }
                }
                Item.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Check_Checkinginghead GetOneListadoEncuestaCovid_Ctta(string RUT, int ID_CHECKINGHEAD, int ID_CHECK)
        {
            try
            {
                Check_Checkinginghead item = new Check_Checkinginghead();
                Instance.DAAsignarProcedure("V4MVC_CHECKINGINGHEAD_LISTADO_ENCUESTAS_COVID_SELECT_ONE_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECKINGHEAD", ID_CHECKINGHEAD, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CHECK", ID_CHECK, SqlDbType.Int, 4, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new Check_Checkinginghead();
                    Loader.LoadEntity(reader, item);
                    item.Instance = InstanceEntity.Unchanged;
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
        #region [ Metodos ]
        #endregion
    }
}