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
	public partial class DALiquidacion
    {
        #region [ Consultas ]

        public ObservableCollection<Liquidacion> GetListLiquidacion_Mdte(ref Liquidacion liquidacionvalid)
        {
            try
            {
                var items = new ObservableCollection<Liquidacion>();
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_SELECT_MDTE");
                Instance.DAAgregarParametro("@START", liquidacionvalid.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", liquidacionvalid.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", liquidacionvalid.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", liquidacionvalid.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", liquidacionvalid.COL0, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", liquidacionvalid.COL1, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", liquidacionvalid.COL2, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", liquidacionvalid.COL3, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", liquidacionvalid.COL4, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", liquidacionvalid.COL5, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", liquidacionvalid.COL6, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Liquidacion();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                liquidacionvalid.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Liquidacion GetOneLiquidacionValidada_Mdte(string RUT, string FECHA, string EMPRESA) {
            try
            {
                Liquidacion item = new Liquidacion();
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_SELECT_ONE_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return item; }
                }
                return item;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Liquidacion GetOneLiquidacionDisputa_Mdte(int ID_DISPUTA)
		{
			try
			{
				Liquidacion item = new Liquidacion();
				Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_SELECT_LIQUIDACIONDISPUTA_MDTE");
				Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 6, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ return item; }
				}
				return item;
			} 
			catch (Exception ex)
			{ throw ex; }
		}
        public bool SaveDocsDisputaLiquidacion(Liquidacion item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_DISPUTA_UPDATE_LIQUIDACION_MDTE");
                Instance.DAAgregarParametro("@OBSERVACION_REVAL", item.OBSERVACION, SqlDbType.NVarChar, 2000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REVALUSUARIO", item.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", item.ID_DISPUTA, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }

        }

        public Liquidacion GetOneLiquidacionDisputaSendAlert_Mdte(int ID_DISPUTA)
        {
            try
            {
                Liquidacion item = new Liquidacion();
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_SELECT_SENDALERT_MDTE");
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 6, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return item; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool SaveLiquidacionValidada_Mdte(ref Liquidacion items) {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_UPDATE_LIQUIDACION_VALIDADA_MDTE");
                Instance.DAAgregarParametro("@RUT", items.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", items.FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", items.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", items.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", items.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IMPONIBLE", items.IMPONIBLE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LIQUIDO", items.LIQUIDO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRANSFERIDO", items.TRANSFERIDO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BONOIP", items.BONOIP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BONOIS", items.BONOIS, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SUELDOBASE", items.SUELDOBASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GRATIFICACION", items.GRATIFICACION, SqlDbType.Int, 8, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool SaveLiquidacionRechazada_Mdte(ref Liquidacion items) {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_UPDATE_LIQUIDACION_RECHAZADA_MDTE");
                Instance.DAAgregarParametro("@RUT", items.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", items.FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", items.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", items.USUARIO, SqlDbType.NVarChar, 15, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
