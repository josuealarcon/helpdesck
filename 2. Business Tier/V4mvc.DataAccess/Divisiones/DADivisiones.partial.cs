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
	public partial class DADivisiones
	{
        #region [ Consultas ]

        public ObservableCollection<Divisiones> GetDivisionesLaborales(String RUT)
        {
            try
            {
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Divisiones item = new Divisiones();
                Instance.DAAsignarProcedure("V4MVC_DIVISIONES_SELECT_LABORALES_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Divisiones();
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
        public ObservableCollection<Divisiones> GetAllA024Divisiones_FiniquitolCtta(string RUT)
        {
            try
            {
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Divisiones item = new Divisiones();
                Instance.DAAsignarProcedure("V4MVC_DIVISIONES_SELECT_CHECKED_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Divisiones();
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
        public ObservableCollection<Divisiones> GetDivisionesConPase(int ID_DOC)
        {
            try
            {
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Divisiones item = new Divisiones();
                Instance.DAAsignarProcedure("V4MVC_DIVISIONES_SELECT_CONPASE_PORDOCUMENTO");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Divisiones();
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

        public ObservableCollection<Divisiones> GetAllDivisionesMDTE(String ADMRUT)
        {
            try
            {
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Divisiones item = new Divisiones();
                Instance.DAAsignarProcedure("V4MVC_ADMIN_DIVISIONES_SELECT_MDTE");
                Instance.DAAgregarParametro("@ADMRUT", ADMRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Divisiones();
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

        public ObservableCollection<Divisiones> GetDivisionesFichaEmpresa(String IDEMPRESA)
        {
            try
            {
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Divisiones item = new Divisiones();
                Instance.DAAsignarProcedure("V4MVC_DIVISIONES_FICHA_EMPRESA_SELECT");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Divisiones();
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

        public ObservableCollection<Divisiones> GetAllDivisiones_PasesCtta(String IDEMPRESA)
        {
            try
            {
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Divisiones item = new Divisiones();
                Instance.DAAsignarProcedure("V4MVC_DIVISIONES_SELECT_PASES_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Divisiones();
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

        public bool ValidarOSTFinal_PasesCtta(string OST, string IDEMPRESA, string DIVISION, out bool m_apr, out bool m_arranque)
        {
            try
            {
                bool ok = false;
                m_apr = false;
                m_arranque = false;

                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_ONE_PASES_CTTA");

                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@M_APR", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAAgregarParametro("@M_ARRANQUE", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAAgregarParametro("@OK", false, SqlDbType.Bit, 1, ParameterDirection.Output);

                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@M_APR"].Value != null)
                {
                    m_apr = Boolean.Parse(Instance.DASqlCommand.Parameters["@M_APR"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@M_ARRANQUE"].Value != null)
                {
                    m_arranque = Boolean.Parse(Instance.DASqlCommand.Parameters["@M_ARRANQUE"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@OK"].Value != null)
                {
                    ok = Boolean.Parse(Instance.DASqlCommand.Parameters["@OK"].Value.ToString());
                }
                return ok;

            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
