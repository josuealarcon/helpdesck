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
	public partial class DATurnos
	{
		#region [ Consultas ]
		public ObservableCollection<Turnos> GetTurnosByEmpOST_Ctta(string ID_EMPRESA, string OST)
        {
            try
            {
                ObservableCollection<Turnos> items = new ObservableCollection<Turnos>();
                Turnos item = new Turnos();
                Instance.DAAsignarProcedure("V4MVC_TURNO_SELECT_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", ID_EMPRESA, SqlDbType.Int, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Turnos();
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

        public ObservableCollection<Turnos> GetAllTurnosCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Turnos> items = new ObservableCollection<Turnos>();
                Turnos item = new Turnos();
                Instance.DAAsignarProcedure("V4MVC_TURNOS_SELECT_TURNOS_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Turnos();
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


        public ObservableCollection<Turnos> GetAllCalendarioTurnosCtta(int IDTURNO, string IDEMPRESA, string TURNO, string ANIO, string MES)
        {
            try
            {
                ObservableCollection<Turnos> items = new ObservableCollection<Turnos>();
                Turnos item = new Turnos();
                Instance.DAAsignarProcedure("V4MVC_CAL_TURNO_SELECT_CALENDARIO_TURNOS_CTTA");
                Instance.DAAgregarParametro("@IDTURNO", IDTURNO, SqlDbType.Int, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TURNO", TURNO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANIO", ANIO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MES", MES, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Turnos();
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

        public Turnos UpdateTurnoTurnosCtta(int IDTURNO)
        {
            try
            { 
                Turnos item = new Turnos();
                Instance.DAAsignarProcedure("V4MVC_TURNOS_SELECT_EDIT_TURNOS_CTTA");
                Instance.DAAgregarParametro("@IDTURNO", IDTURNO, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                        reader.Read();                    
                        item = new Turnos();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;                    
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Turnos GetTurnoPorTurnoOstTurnosCtta(Turnos Item)
        {
            try
            {
                Turnos item = new Turnos();
                Instance.DAAsignarProcedure("V4MVC_TURNOS_SELECT_PORTURNOOST_TURNOS_CTTA");
                Instance.DAAgregarParametro("@TURNO", Item.TURNO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new Turnos();                    
                    Loader.LoadEntity(reader, item);
                    item.Instance = InstanceEntity.Unchanged;
                }
                return item;
            }
            catch (Exception ex)
            { return null; }
        }
        #endregion

        #region [ Metodos ]
        public bool UpdateTurnoPorTurnoOstTurnosCtta(Turnos item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TURNOS_UPDATE_PORTURNOOST_TURNOS_CTTA");
                Instance.DAAgregarParametro("@IDTURNO", item.IDTURNO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TURNO", item.TURNO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCAL", item.LOCAL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIATRABAJO", item.DIATRABAJO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIADESCANSO", item.DIADESCANSO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DDIURNO", item.DDIURNO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DNOCHE", item.DNOCHE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DDIURNO2", item.DDIURNO2, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DNOCHE2", item.DNOCHE2, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECINICIO", item.FECINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TURDESCR", item.TURDESCR, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTTURNO", item.DOTTURNO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLASETUR", item.CLASETUR, SqlDbType.NVarChar, 15, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADOTUR", item.ESTADOTUR, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVTUR", item.OBSERVTUR, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIENEHE", item.TIENEHE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HMAXDIANOR", item.HMAXDIANOR, SqlDbType.SmallMoney, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HMAXDIAHE", item.HMAXDIAHE, SqlDbType.SmallMoney, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HSEMANA", item.HSEMANA, SqlDbType.SmallMoney, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HEXTRAS", item.HEXTRAS, SqlDbType.SmallMoney, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HINGRESO", item.HINGRESO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HINDESDE", item.HINDESDE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HINHASTA", item.HINHASTA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HOUTDESDE", item.HOUTDESDE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HOUTHASTA", item.HOUTHASTA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HALIMI", item.HALIMI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HALIMS", item.HALIMS, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIENEFERIADO", item.TIENEFERIADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HSALIDA", item.HSALIDA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIOMOD", item.USUARIOMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VISIBLE", item.VISIBLE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", item.TIPO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HINGRESON", item.HINGRESON, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HINDESDEN", item.HINDESDEN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HINHASTAN", item.HINHASTAN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HSALIDAN", item.HSALIDAN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HOUTDESDEN", item.HOUTDESDEN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HOUTHASTAN", item.HOUTHASTAN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HALIMIN", item.HALIMIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HALIMSN", item.HALIMSN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HSAL_ULIMODIA", item.HSAL_ULIMODIA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FVIGENCIA", item.FVIGENCIA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPIEZANOCHEA", item.EMPIEZANOCHEA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPIEZANOCHEB", item.EMPIEZANOCHEB, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPIEZA", item.EMPIEZA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USRSUBE", item.USRSUBE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTUSUARIO", item.CERTUSUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTFECHA", item.CERTFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTHORA", item.CERTHORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBS_RECHAZO", item.OBS_RECHAZO, SqlDbType.Text, 2147483647, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HSAL_ULIMONOCHE", item.HSAL_ULIMONOCHE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
