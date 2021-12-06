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

        public ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte(string MANDANTE)
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_MANDANTE_MDTE");
                Instance.DAAgregarParametro("@MANDANTE", MANDANTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<A024_Divisiones> GetAllA024DivisionesMandante_Mdte()
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_PASES_MDTE");
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

        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_CertificacionMdte(string DIVISIONES)
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@DIVISIONES", DIVISIONES, SqlDbType.NVarChar, 200, ParameterDirection.Input);
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

        public ObservableCollection<A024_Divisiones> GetAllA024Divisiones_CertificacionMdte()
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_V2_CERTIFICACION_MDTE");
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
        public ObservableCollection<A024_Divisiones> GetListDivisionesChecked_Mdte(string DIVCOD)
        {
            try
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_DIVCOD_CHECKED_MDTE");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input); using (IDataReader reader = Instance.DAExecuteReader())
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


        public ObservableCollection<A024_Divisiones> GetAllA024DivisionesCharlasCheked_Mdte(int IdCharla)
        {
            try 
            {
                ObservableCollection<A024_Divisiones> items = new ObservableCollection<A024_Divisiones>();
                A024_Divisiones item = new A024_Divisiones();
                Instance.DAAsignarProcedure("V4MVC_A024_DIVISIONES_SELECT_CHECKED_MDTE");
                Instance.DAAgregarParametro("@IDCHARLA", IdCharla, SqlDbType.Int, 4, ParameterDirection.Input);
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

    }
}
