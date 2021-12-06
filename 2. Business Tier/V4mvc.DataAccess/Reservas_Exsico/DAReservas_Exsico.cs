using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAReservas_Exsico : IDAReservas_Exsico
    {

        #region [ Propiedades ]

        public IUnityContainer ContainerService { get; set; }
        public LoaderEntity<Reservas_Exsico> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }

        #endregion

        #region [ Constructores ]

        public DAReservas_Exsico(IDataAccessEnterprise container)
        {
            this.Instance = container;
            Loader = new LoaderEntity<Reservas_Exsico>();
            Reservas_Exsico item = new Reservas_Exsico();
            Loader.EntityType = item.GetType();
        }

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Reservas_Exsico> GetAll()
		{
			try
			{
				ObservableCollection<Reservas_Exsico> items = new ObservableCollection<Reservas_Exsico>();
				Reservas_Exsico item = new Reservas_Exsico();
				Instance.DAAsignarProcedure("_SS_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Reservas_Exsico();
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

		public Reservas_Exsico GetOne(Decimal ID)
		{
			try
			{
				Reservas_Exsico item = new Reservas_Exsico();
				Instance.DAAsignarProcedure("_SS_UnReg");
				Instance.DAAgregarParametro("@ID", ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ throw new Exception("No se encontro el registro."); }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public bool Save(ref Reservas_Exsico item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHARES", item.FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAINICIO", item.HORAINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORATERMINO", item.HORATERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPO", item.TIPO, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ASISTIO", item.ASISTIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MOTIVO", item.MOTIVO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHASOL", item.FECHASOL, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORASOL", item.HORASOL, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIOSOL", item.USUARIOSOL, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@APROBO", item.APROBO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
