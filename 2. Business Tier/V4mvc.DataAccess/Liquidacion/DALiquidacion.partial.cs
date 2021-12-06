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
        public ObservableCollection<Liquidacion> GetLiquidacionUploadFuncionarios(string RUT, string EMPRESA)
        {
            try
            {
                ObservableCollection<Liquidacion> items = new ObservableCollection<Liquidacion>();
                Liquidacion item = new Liquidacion();

                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_SELECT_LIQUIDACIONUPLOAD");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Liquidacion();
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

        public Liquidacion GetLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA)
        {
            try
            {
                Liquidacion item = new Liquidacion();
                Instance.DAAsignarProcedure("V4MVC_GETLIQUIDACION_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new Liquidacion();
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

        public bool UpdateLiquidacionFuncionariosCtta(Liquidacion item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_UPDATE_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IMPONIBLE", item.IMPONIBLE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LIQUIDO", item.LIQUIDO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRANSFERIDO", item.TRANSFERIDO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BONOIP", item.BONOIP, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BONOIS", item.BONOIS, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SUELDOBASE", item.SUELDOBASE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GRATIFICACION", item.GRATIFICACION, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CARGO_ARCHIVO", item.CARGO_ARCHIVO, SqlDbType.Bit, 5, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new Liquidacion();
                    Loader.LoadEntity(reader, item);
                    item.Instance = InstanceEntity.Unchanged;
                }
                if (item.VALIDADO == "SI")
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool InsertLiquidacionDisputaFuncionariosCtta(string RUT, string FECHA, string EMPRESA, string OBSERVACION, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_INSERT_LIQUIDACION_DISPUTA_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION", OBSERVACION, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool InsertLiquidacionUploadFuncionarios(Liquidacion item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_INSERT_LIQUIDACIONUPLOAD");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", item.NOMBRE_ARCHIVO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_CONTENIDO", item.TIPO_CONTENIDO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeleteLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA, int ID_DISPUTA, string USUARIO)
        {
            try
            {
                Liquidacion item = new Liquidacion();
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_DELETE_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new Liquidacion();
                    Loader.LoadEntity(reader, item);
                    item.Instance = InstanceEntity.Unchanged;
                }
                if (item.VALIDADO == "SI")
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveLiquidacion_ControlLaboralCtta(Liquidacion liquidacion)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_UPSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@RUT", liquidacion.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", liquidacion.FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", liquidacion.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", liquidacion.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_ARCHIVO", liquidacion.ID_ARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", liquidacion.NOMBRE_ARCHIVO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_CONTENIDO", liquidacion.TIPO_CONTENIDO, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveLiquidacion_v2_ControlLaboralCtta(ref Liquidacion liquidacion)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@RUT", liquidacion.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", liquidacion.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", liquidacion.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", liquidacion.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IMPONIBLE", liquidacion.IMPONIBLE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LIQUIDO", liquidacion.LIQUIDO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRANSFERIDO", liquidacion.TRANSFERIDO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BONOIP", liquidacion.BONOIP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BONOIS", liquidacion.BONOIS, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SUELDOBASE", liquidacion.SUELDOBASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GRATIFICACION", liquidacion.GRATIFICACION, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INCLU_F301", liquidacion.INCLU_F301, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", liquidacion.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);

                Instance.DAAgregarParametro("@RUT_PERIODO_VACIO", liquidacion.RUT_PERIODO_VACIO, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@PERIODO_INVALIDO", liquidacion.PERIODO_INVALIDO, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@RANGO_FECHA_INVALIDO", liquidacion.RANGO_FECHA_INVALIDO, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@RUT_INVALIDO", liquidacion.RUT_INVALIDO, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@REPETIDO", liquidacion.REPETIDO, SqlDbType.Int, 8, ParameterDirection.Output);

                Instance.DAAgregarParametro("@RUT_ORIGINAL_ERR", liquidacion.RUT_ORIGINAL_ERR, SqlDbType.NVarChar, 10, ParameterDirection.Output);
                Instance.DAAgregarParametro("@RUT_PROCESADO_ERR", liquidacion.RUT_PROCESADO_ERR, SqlDbType.NVarChar, 10, ParameterDirection.Output);
                Instance.DAAgregarParametro("@PERIODO_ERR", liquidacion.PERIODO_ERR, SqlDbType.NVarChar, 6, ParameterDirection.Output);

                var rows_exec = (Instance.DAExecuteNonQuery() > 0);

                if (Instance.DASqlCommand.Parameters["@RUT_PERIODO_VACIO"].Value != null)
                {
                    liquidacion.RUT_PERIODO_VACIO = Convert.ToInt32(Instance.DASqlCommand.Parameters["@RUT_PERIODO_VACIO"].Value.ToString());
                }
                else
                {
                    liquidacion.RUT_PERIODO_VACIO = 0;
                }

                if (Instance.DASqlCommand.Parameters["@PERIODO_INVALIDO"].Value != null)
                {
                    liquidacion.PERIODO_INVALIDO = Convert.ToInt32(Instance.DASqlCommand.Parameters["@PERIODO_INVALIDO"].Value.ToString());
                }
                else
                {
                    liquidacion.PERIODO_INVALIDO = 0;
                }

                if (Instance.DASqlCommand.Parameters["@RANGO_FECHA_INVALIDO"].Value != null)
                {
                    liquidacion.RANGO_FECHA_INVALIDO = Convert.ToInt32(Instance.DASqlCommand.Parameters["@RANGO_FECHA_INVALIDO"].Value.ToString());
                }
                else
                {
                    liquidacion.RANGO_FECHA_INVALIDO = 0;
                }

                if (Instance.DASqlCommand.Parameters["@RUT_INVALIDO"].Value != null)
                {
                    liquidacion.RUT_INVALIDO = Convert.ToInt32(Instance.DASqlCommand.Parameters["@RUT_INVALIDO"].Value.ToString());
                }
                else
                {
                    liquidacion.RUT_INVALIDO = 0;
                }

                if (Instance.DASqlCommand.Parameters["@REPETIDO"].Value != null)
                {
                    liquidacion.REPETIDO = Convert.ToInt32(Instance.DASqlCommand.Parameters["@REPETIDO"].Value.ToString());
                }
                else
                {
                    liquidacion.REPETIDO = 0;
                }


                if (Instance.DASqlCommand.Parameters["@RUT_ORIGINAL_ERR"].Value != null)
                {
                    liquidacion.RUT_ORIGINAL_ERR = Instance.DASqlCommand.Parameters["@RUT_ORIGINAL_ERR"].Value.ToString();
                }
                if (Instance.DASqlCommand.Parameters["@RUT_PROCESADO_ERR"].Value != null)
                {
                    liquidacion.RUT_PROCESADO_ERR = Instance.DASqlCommand.Parameters["@RUT_PROCESADO_ERR"].Value.ToString();
                }

                if (Instance.DASqlCommand.Parameters["@PERIODO_ERR"].Value != null)
                {
                    liquidacion.PERIODO_ERR = Instance.DASqlCommand.Parameters["@PERIODO_ERR"].Value.ToString();
                }

                var INSERCION_NOT_OK = (liquidacion.RUT_PERIODO_VACIO == 1 || liquidacion.PERIODO_INVALIDO == 1 || liquidacion.RANGO_FECHA_INVALIDO == 1);
                INSERCION_NOT_OK = INSERCION_NOT_OK || (liquidacion.RUT_INVALIDO == 1 || liquidacion.REPETIDO == 1);

                liquidacion.INSERCION_OK = (INSERCION_NOT_OK ? 0 : 1);

                return rows_exec;
            }
            catch (Exception ex)
            { throw ex; }


        }

        public bool ValidarLiquidacionCtta(ref Liquidacion modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_SELECT_LIQUIDACIOVALIDACION");
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", modelo.FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGISTROVAL", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@REGISTROCSV", 0, SqlDbType.Int, 12, ParameterDirection.Output);


                Instance.DAExecuteNonQuery();
                
                    if (Instance.DASqlCommand.Parameters["@REGISTROVAL"].Value != null)
                    {
                        modelo.REGISTROVAL = Int32.Parse(Instance.DASqlCommand.Parameters["@REGISTROVAL"].Value.ToString());
                    }
                    if (Instance.DASqlCommand.Parameters["@REGISTROCSV"].Value != null)
                    {
                        modelo.REGISTROCSV = Int32.Parse(Instance.DASqlCommand.Parameters["@REGISTROCSV"].Value.ToString());
                    }
                    return true;

            }
            catch (Exception ex)
            { throw ex; }
            #endregion
        }
    }
}
