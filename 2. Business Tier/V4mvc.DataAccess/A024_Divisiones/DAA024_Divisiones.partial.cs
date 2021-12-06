
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAA024_Divisiones
    {
        #region [ Consultas ]
        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A024_Divisiones();
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
        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@PATENTE", request.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A024_Divisiones();
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
        public ObservableCollection<A024_Divisiones> GetA024Divisiones_GridFichaEmpresa_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_GRID_FICHAEMPRESA_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", request.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A024_Divisiones();
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
        public ObservableCollection<A024_Divisiones> GetA024Divisiones_HistoricoBloqueoVehiculos_InformeConsultaRapidaCtta(A024_Divisiones request)
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_GRID_HISTORICOBLOQUEOSVEHICULO_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@PATENTE", request.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", request.DIVISION, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A024_Divisiones();
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

        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_Ctta()
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_CTTA");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A024_Divisiones();
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
        #endregion
    }
}
	