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
	public partial class DAReservas_Revision_Vehicular
    {
        #region [ Consultas ]
        public ObservableCollection<Reservas_Revision_Vehicular> GetFechasGrid_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
        {
            try
            {
                ObservableCollection<Reservas_Revision_Vehicular> items = new ObservableCollection<Reservas_Revision_Vehicular>();
                Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
                Instance.DAAsignarProcedure("V4MVC_ACREDITACION_VEHICULAR_SELECT_FECHAS_ACREDITACIONVEHICULARCTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Reservas_Revision_Vehicular();
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

        public ObservableCollection<Reservas_Revision_Vehicular> GetMotivoDivisionVehicular_AcreditacionVehicularCtta()
        {
            try
            {
                ObservableCollection<Reservas_Revision_Vehicular> items = new ObservableCollection<Reservas_Revision_Vehicular>();
                Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
                Instance.DAAsignarProcedure("V4MVC_MOTIVO_REVISION_VEHICULAR_SELECT_ACREDITACIONVEHICULARCTTA");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Reservas_Revision_Vehicular();
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

        public ObservableCollection<Reservas_Revision_Vehicular> GetComboOst_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
        {
            try
            {
                ObservableCollection<Reservas_Revision_Vehicular> items = new ObservableCollection<Reservas_Revision_Vehicular>();
                Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
                Instance.DAAsignarProcedure("V4MVC_COMBOOST_CASCADA_SELECT_ACREDITACIONVEHICULARCTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Reservas_Revision_Vehicular();
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

        public ObservableCollection<Reservas_Revision_Vehicular> GetComboPatente_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
        {
            try
            {
                ObservableCollection<Reservas_Revision_Vehicular> items = new ObservableCollection<Reservas_Revision_Vehicular>();
                Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
                Instance.DAAsignarProcedure("V4MVC_COMBOPATENTE_CASCADA_SELECT_ACREDITACIONVEHICULARCTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Reservas_Revision_Vehicular();
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
        public ObservableCollection<Reservas_Revision_Vehicular> GetReservasRevisionVehicularPorFecharesAcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
        {
            try
            {
                ObservableCollection<Reservas_Revision_Vehicular> items = new ObservableCollection<Reservas_Revision_Vehicular>();
                Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
                Instance.DAAsignarProcedure("V4MVC_RESERVAS_REVISION_VEHICULAR_SELECT_PORFECHARES_ACREDITACIONVEHICULAR_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHARES", Item.FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Reservas_Revision_Vehicular();
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

        public ObservableCollection<Reservas_Revision_Vehicular> GetInformeRevisionVehicularCtta(ref Reservas_Revision_Vehicular model)
        {
            try
            {
                ObservableCollection<Reservas_Revision_Vehicular> items = new ObservableCollection<Reservas_Revision_Vehicular>();
                Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
                Instance.DAAsignarProcedure("V4MVC_INFORME_REVISION_VEHICULAR_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", model.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO", model.ESTADO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Reservas_Revision_Vehicular();
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

        public bool Insert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref Reservas_Revision_Vehicular Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_RESERVAS_REVISION_VEHICULAR_INSERT_PEDIRRESERVA_ACREDITACIONVEHICULAR_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", Item.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHARES", Item.FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORAINICIO", Item.HORAINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORATERMINO", Item.HORATERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MINUTOS", Item.MINUTOS, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIOSOL", Item.USUARIOSOL, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.CODDIV, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDMOTIVORESERVA", Item.IDMOTIVORESERVA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXITOSO", false, SqlDbType.Bit, 1, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SALIDA", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@EXITOSO"].Value != null)
                {
                    Item.EXITOSO = Boolean.Parse(Instance.DASqlCommand.Parameters["@EXITOSO"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@SALIDA"].Value != null)
                {
                    Item.ESTADO_OPERACION = Int32.Parse(Instance.DASqlCommand.Parameters["@SALIDA"].Value.ToString());
                }
                return Item.EXITOSO;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Delete_ReservasRevisionVehiculo_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_RESERVAS_REVISION_VEHICULAR_DELETE_ACREDITACIONVEHICULAR_CTTA");
                Instance.DAAgregarParametro("@USUARIOSOL", Item.USUARIOSOL, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", Item.ID, SqlDbType.Int, 4, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
