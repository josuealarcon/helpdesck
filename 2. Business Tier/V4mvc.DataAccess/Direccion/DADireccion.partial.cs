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
    public partial class DADireccion
    {
        #region [ Consultas ]

        public ObservableCollection<Direccion> GetAllPaises()
        {
            try
            {
                ObservableCollection<Direccion> items = new ObservableCollection<Direccion>();
                Direccion item = new Direccion();
                Instance.DAAsignarProcedure("V4MVC_PAIS_SELECT");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Direccion();
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
        public ObservableCollection<Direccion> GetAllRegionesByPais(String PAIS)
        {
            try
            {
                ObservableCollection<Direccion> items = new ObservableCollection<Direccion>();
                Direccion item = new Direccion();
                Instance.DAAsignarProcedure("V4MVC_REGION_SELECT_BYPAIS");
                Instance.DAAgregarParametro("@PAIS", PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Direccion();
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
        public ObservableCollection<Direccion> GetAllCiudadByRegion(String REGION)
        {
            try
            {
                ObservableCollection<Direccion> items = new ObservableCollection<Direccion>();
                Direccion item = new Direccion();
                Instance.DAAsignarProcedure("V4MVC_CIUDAD_SELECT_BYREGION");
                Instance.DAAgregarParametro("@REGION", REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Direccion();
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
        public ObservableCollection<Direccion> GetAllComunaByCiudad(String CIUDAD)
        {
            try
            {
                ObservableCollection<Direccion> items = new ObservableCollection<Direccion>();
                Direccion item = new Direccion();
                Instance.DAAsignarProcedure("V4MVC_COMUNA_SELECT_BYCIUDAD");
                Instance.DAAgregarParametro("@CIUDAD", CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Direccion();
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

        public ObservableCollection<Direccion> GetAllCiudad()
        {
            try
            {
                ObservableCollection<Direccion> items = new ObservableCollection<Direccion>();
                Direccion item = new Direccion();
                Instance.DAAsignarProcedure("V4MVC_CIUDAD_SELECT");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Direccion();
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
        public bool SaveDireccionCtta(ref Direccion item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DIRECCION_UPDATE_CTTA");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECCION", item.DIRECCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUNA", item.COMUNA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PAIS", item.PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FONOHELP", item.FONOHELP, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FONO", item.FONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CELULAR", item.CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF00(ref Direccion item) {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DIRECCION_UPDATE_COVID_F00");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECCION", item.DIRECCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUNA", item.COMUNA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PAIS", item.PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FONO", item.FONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CELULAR", item.CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMCONTACTO", item.NOMCONTACTO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CELCONTACTO", item.CELCONTACTO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF100(ref Direccion item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DIRECCION_UPDATE_COVID_F100");
                Instance.DAAgregarParametro("@TIPO", item.TIPO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECCION", item.DIRECCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUNA", item.COMUNA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PAIS", item.PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FONO", item.FONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CELULAR", item.CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCovidF300(ref Direccion item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DIRECCION_UPDATE_COVID_F300");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECCION", item.DIRECCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUNA", item.COMUNA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CELULAR", item.CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDireccionCelularRut(String CELULAR, String RUT)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DIRECCION_UPDATE_CELULAR_RUT");
                Instance.DAAgregarParametro("@CELULAR", CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
