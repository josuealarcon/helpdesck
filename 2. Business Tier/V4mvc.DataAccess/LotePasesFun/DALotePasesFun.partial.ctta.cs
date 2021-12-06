using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Microsoft.Practices.EnterpriseLibrary.Data;

using V4mvc.Entities;
using System.Configuration;

namespace V4mvc.DataAccess
{
    public partial class DALotePasesFun
    {
        #region [ Consultas ]

        public LotePasesFun GetLotePasesFunConduccionPase(string RUT, string DIVCOD)
        {
            try
            {
                LotePasesFun item = new LotePasesFun();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_CONDUCCIONPASE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                LotePasesFun item;
                ObservableCollection<LotePasesFun> items = new ObservableCollection<LotePasesFun>();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_PASES_CTTA");
                Instance.DAAgregarParametro("@IDPASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_INI", FEC_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_FIN", FEC_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PASE", TIPO_PASE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LotePasesFun();
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

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_v2_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN)
        {
            try
            {
                LotePasesFun item;
                ObservableCollection<LotePasesFun> items = new ObservableCollection<LotePasesFun>();
                //V4MVC_LOTEPASESFUN_SELECT2_PASES_CTTA
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_V2_PASES_CTTA");
                Instance.DAAgregarParametro("@IDPASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_INI", FEC_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_FIN", FEC_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LotePasesFun();
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

        public bool ValidarContDotacionSubCat_PasesCtta(string OST, int TIPO, int CONT_DOTACION, int LOTENUM, string FEC_INI, string FEC_FIN)
        {
            bool result = true;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_ONE_PASES_CTTA");
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", TIPO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CONT_DOTACION", CONT_DOTACION, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOTENUM", LOTENUM, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_INI", FEC_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_FIN", FEC_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@RET"].Value != null)
                {
                    result = Boolean.Parse(Instance.DASqlCommand.Parameters["@RET"].Value.ToString());
                }
                return result;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarCantOST_PasesCtta(string OST, int CONT_RUT_HOTEL, int LOTENUM, string FEC_INI, string FEC_FIN, out int err_value)
        {
            bool result = true;
            err_value = -1;
            try
            {
                //V4MVC_LOTEPASESFUN_SELECT_ONE2_PASES_CTTA
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_ONE_V2_PASES_CTTA");
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CONT_RUT_HOTEL", CONT_RUT_HOTEL, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOTENUM", LOTENUM, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_INI", FEC_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_FIN", FEC_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAAgregarParametro("@ESALIDA", -1, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@RET"].Value != null)
                {
                    result = Boolean.Parse(Instance.DASqlCommand.Parameters["@RET"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@ESALIDA"].Value != null)
                {
                    err_value = Int32.Parse(Instance.DASqlCommand.Parameters["@ESALIDA"].Value.ToString());
                }
                return result;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePasesFun GetLotePasesFun_Valida_Poseeconsuccionenfaena_FuncionariosCtta(string RUT,string DIVCOD)
        {
            try
            {
                LotePasesFun item = new LotePasesFun();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_VALIDA_POSEECONDUCCIONENFAENA_FUNCIONARIOS_CCTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
        #region [ Informes ]
        public ObservableCollection<LotePasesFun> GetLotePasesFun_VehiculosInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                LotePasesFun item;
                ObservableCollection<LotePasesFun> items = new ObservableCollection<LotePasesFun>();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_VEHICULO_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@NLOTEPROC", request.NLOTEPROC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LotePasesFun();
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
        public ObservableCollection<LotePasesFun> GetLotePasesFun_FuncionariosInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                LotePasesFun item;
                ObservableCollection<LotePasesFun> items = new ObservableCollection<LotePasesFun>();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_FUNCIONARIO_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@NLOTEPROC", request.NLOTEPROC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LotePasesFun();
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
        public LotePasesFun GetLotePasesFun_DatosPaseInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                LotePasesFun item = new LotePasesFun();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_DATOSPASE_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@NLOTEPROC", request.NLOTEPROC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePasesFun GetLotePasesFun_ValidaExistenciaNlote_InformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                bool EXISTE = false;
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_VALIDA_EXISTENCIA_NLOTE_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@NLOTEPROC", request.NLOTEPROC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXISTE", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@EXISTE"].Value != null)
                {
                    EXISTE = Boolean.Parse(Instance.DASqlCommand.Parameters["@EXISTE"].Value.ToString());
                }
                return new LotePasesFun() { EXISTE = EXISTE };
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<LotePasesFun> GetLotePasesFun_PasesHistoricos_InformeFuncionariosCtta(LotePasesFun request)
        {
            try
            {
                LotePasesFun item;
                ObservableCollection<LotePasesFun> items = new ObservableCollection<LotePasesFun>();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_SELECT_PASESHISTORICOS_INFORMEFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUTLOTE", request.RUTLOTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LotePasesFun();
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
        #region [ Metodos ]

        public bool SaveLotePasesFunQuitarConduccionPase(string RUT, string IDEMPRESA, string DIVCOD, string LICONDLT)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_UPDATE_CONDUCCIONPASE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LICONDLT", LICONDLT, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveLotePasesFun_PasesCtta(LotePasesFun funcionario)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_UPSERT_PASES_CTTA");
                Instance.DAAgregarParametro("@PASE_ID", funcionario.ID_PASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT_FUNC", funcionario.RUTLOTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", funcionario.ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PASE", funcionario.TIPOLT, SqlDbType.NVarChar, 9, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", funcionario.NOMBRESLT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", funcionario.APELLIDOSLT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HOTEL", funcionario.HOTEL, SqlDbType.Bit, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ALIMENTACION", funcionario.CASINO, SqlDbType.Bit, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CONDUCE", funcionario.CONDUCE, SqlDbType.Bit, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", funcionario.OSTLT, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEXO", funcionario.SEXOLT, SqlDbType.NVarChar, 15, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_NAC", funcionario.FECNACIM, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CATEGORIA", funcionario.IDCATEGORIACTTA, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_SUBCATEGORIA", funcionario.IDSUBCATEGORIACCTTA, SqlDbType.Int, 8, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveLotePasesFun_v2_PasesCtta(LotePasesFun vehiculo)
        {
            try
            {
                //V4MVC_LOTEPASESFUN_UPSERT2_PASES_CTTA
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_UPSERT_V2_PASES_CTTA");
                Instance.DAAgregarParametro("@PASE_ID", vehiculo.ID_PASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", vehiculo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", vehiculo.ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_VEH", vehiculo.TIPOVEHI, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", vehiculo.MARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", vehiculo.MODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PASE", vehiculo.TIPOLT, SqlDbType.NVarChar, 9, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANIO", vehiculo.ANIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", vehiculo.OSTLT, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelLotePasesFun_PasesCtta(LotePasesFun funcionario)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_DELETE_PASES_CTTA");
                Instance.DAAgregarParametro("@PASE_ID", funcionario.ID_PASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", funcionario.RUTLOTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelLotePasesFun_v2_PasesCtta(LotePasesFun vehiculo)
        {
            try
            {
                //V4MVC_LOTEPASESFUN_DELETE2_PASES_CTTA
                Instance.DAAsignarProcedure("V4MVC_LOTEPASESFUN_DELETE_V2_PASES_CTTA");
                Instance.DAAgregarParametro("@PASE_ID", vehiculo.ID_PASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", vehiculo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
