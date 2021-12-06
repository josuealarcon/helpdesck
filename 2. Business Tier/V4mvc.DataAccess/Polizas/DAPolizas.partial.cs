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
	public partial class DAPolizas
    {
        #region [ Consultas ]
        public ObservableCollection<Polizas> GetPolizasDatatablePolizasCtta()
        {
            try
            {
                ObservableCollection<Polizas> items = new ObservableCollection<Polizas>();
                Polizas item = new Polizas();
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_SELECT_DATATABLE_POLIZAS_CTTA");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Polizas();
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
        public ObservableCollection<Polizas> GetPolizasEditarDatatablePolizasCtta(Polizas Item)
        {
            try
            {
                ObservableCollection<Polizas> items = new ObservableCollection<Polizas>();
                Polizas item = new Polizas();
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_SELECT_EDITAR_DATATABLE_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Polizas();
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
        public ObservableCollection<Polizas> GetPolizasPagoPolizasCtta(Polizas Item)
        {
            try
            {
                ObservableCollection<Polizas> items = new ObservableCollection<Polizas>();
                Polizas item = new Polizas();
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_PAGO_SELECT_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Polizas();
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
        public ObservableCollection<Polizas> GetOstsubcComboPolizasCtta(Polizas Item)
        {
            try
            {
                ObservableCollection<Polizas> items = new ObservableCollection<Polizas>();
                Polizas item = new Polizas();
                Instance.DAAsignarProcedure("V4MVC_OSTSUBC_SELECT_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Polizas();
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
        public ObservableCollection<Polizas> GetPolizasNominaDatatablePolizasCtta(Polizas Item)
        {
            try
            {
                ObservableCollection<Polizas> items = new ObservableCollection<Polizas>();
                Polizas item = new Polizas();
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_NOMINA_SELECT_DATATABLE_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA.Trim(), SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Polizas();
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

        public Polizas GetOnePolizaCargada(int IDDOC, string NROPOLIZA)
        {
            try
            {
                Polizas item = new Polizas();
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_SELECT_POLIZACARGADA_CTTA");
                Instance.DAAgregarParametro("@IDDOC", IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", NROPOLIZA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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

        #region [ Metodos ]
        public bool InsertPolizaEditarPolizasCtta(Polizas Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_INSERT_EDITAR_DATATABLE_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA.Trim(), SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", Item.ID, SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECINI", Item.FECINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECFIN", Item.FECFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIOMOD", Item.USUARIOMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeletePolizaEditarPolizasCtta(Polizas Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_DELETE_EDITAR_DATATABLE_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA.Trim(), SqlDbType.NVarChar, 50, ParameterDirection.Input);                
                Instance.DAAgregarParametro("@USUARIOMOD", Item.USUARIOMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);               
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas DeletePolizaPagoPolizasCtta(Polizas Item)
        {
            try
            {
                bool EXITOSO = false;
                string MENSAJE = "";
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_PAGO_DELETE_DATATABLE_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@ID", Item.ID_TABLA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA.Trim(), SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIOMOD", Item.USUARIOMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXITOSO", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAAgregarParametro("@MENSAJE", false, SqlDbType.NVarChar, 500, ParameterDirection.Output);
                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@EXITOSO"].Value != null)
                {
                    EXITOSO = Boolean.Parse(Instance.DASqlCommand.Parameters["@EXITOSO"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@MENSAJE"].Value != null)
                {
                    MENSAJE = Instance.DASqlCommand.Parameters["@MENSAJE"].Value.ToString();
                }
                return new Polizas() { EXITOSO = EXITOSO, MENSAJE = MENSAJE };
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertPolizaNominaPolizasCtta(Polizas Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_NOMINA_INSERT_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA.Trim(), SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }


        public bool DeletePolizaNominaPorNroPolizaPolizasCtta(Polizas Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_NOMINA_DELETE_PORNROPOLIZA_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA.Trim(), SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertPolizaPagoPolizasCtta(Polizas Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_POLIZAS_PAGO_INSERT_POLIZAS_CTTA");
                Instance.DAAgregarParametro("@IDDOC", Item.IDDOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROPOLIZA", Item.NROPOLIZA.Trim(), SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERINI", Item.PERINI, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERFIN", Item.PERFIN, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIOMOD", Item.USUARIOMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDPAGO", Item.IDPAGO, SqlDbType.UniqueIdentifier, 200, ParameterDirection.Input);
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
