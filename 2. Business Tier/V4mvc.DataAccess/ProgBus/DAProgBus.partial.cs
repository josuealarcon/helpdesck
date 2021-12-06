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
    public partial class DAProgBus
    {
        #region [ Consultas ]
        public ObservableCollection<ProgBus> GetAllBusesReservaCtta(ProgBus Item)
        {
            try
            {
                ObservableCollection<ProgBus> items = new ObservableCollection<ProgBus>();
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_A203_BUS_PAS_SELECT_BUSESRESERVA_CTTA");
                Instance.DAAgregarParametro("@DIAS", Item.DIAS, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new ProgBus();
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

        public ProgBus GetViaje_BusesReservaCtta(ProgBus Item)
        {
            try
            {
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_A203_BUS_PAS_SELECT_VIAJE_BUSESRESERVA_CTTA");
                Instance.DAAgregarParametro("@IDPROG", Item.IDPROG, SqlDbType.Decimal, 20, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new ProgBus();
                    Loader.LoadEntity(reader, item);
                    item.Instance = InstanceEntity.Unchanged;
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<ProgBus> GetAsientosReservados_BusesReservaCtta(ProgBus Item)
        {
            try
            {
                ObservableCollection<ProgBus> items = new ObservableCollection<ProgBus>();
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_RESERVA_BUS_SELECT_ASIENTOSRESERVADOS_BUSESRESERVA_CTTA");
                Instance.DAAgregarParametro("@IDPROG", Item.IDPROG, SqlDbType.Decimal, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new ProgBus();
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

        public ProgBus ReservaBus_Select_ValidaEmpresa_BusesReservaCtta(ProgBus Item)
        {
            try
            {
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_RESERVA_BUS_SELECT_VALIDAEMPRESA_BUSESRESERVA_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    reader.Read();
                    item = new ProgBus();
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
        public bool AsientosReservados_Delete_BusesReservaCtta(ProgBus Item)
        {
            try
            {
                ObservableCollection<ProgBus> items = new ObservableCollection<ProgBus>();
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_RESERVA_BUS_DELETE_ASIENTOSRESERVADOS_BUSESRESERVA_CTTA");
                Instance.DAAgregarParametro("@IDPROG", Item.IDPROG, SqlDbType.Decimal, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", Item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ProgBus ReservaBus_Insert_BusesReservaCtta(ProgBus Item)
        {
            try
            {
                bool EXITOSO = false;
                string MENSAJE = "";
                string TABLA = "";
                ObservableCollection<ProgBus> items = new ObservableCollection<ProgBus>();
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_RESERVA_BUS_INSERT_BUSESRESERVA_CTTA");
                Instance.DAAgregarParametro("@IDPROG", Item.IDPROG, SqlDbType.Decimal, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", Item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXITOSO", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAAgregarParametro("@MENSAJE", false, SqlDbType.NVarChar, 100, ParameterDirection.Output);
                Instance.DAAgregarParametro("@TABLA", false, SqlDbType.NVarChar, 1000, ParameterDirection.Output);
                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@EXITOSO"].Value != null)
                {
                    EXITOSO = Boolean.Parse(Instance.DASqlCommand.Parameters["@EXITOSO"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@MENSAJE"].Value != null)
                {
                    MENSAJE = Instance.DASqlCommand.Parameters["@MENSAJE"].Value.ToString();
                }
                if (Instance.DASqlCommand.Parameters["@TABLA"].Value != null)
                {
                    TABLA = Instance.DASqlCommand.Parameters["@TABLA"].Value.ToString();
                }
                return new ProgBus() { EXITOSO = EXITOSO, MENSAJE = MENSAJE, TABLA = TABLA };
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ProgBus GetReservaBuses(int IDPROG, string RUT, string EMPRESA, string OST, string USUARIO)
        {
            try
            {
                //ObservableCollection<ProgBus> items = new ObservableCollection<ProgBus>();
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_RESERVA_BUS_INSERT_BUSESRESERVA_CTTA");
                Instance.DAAgregarParametro("@IDPROG", IDPROG, SqlDbType.Decimal, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        return null;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
    #endregion
}
