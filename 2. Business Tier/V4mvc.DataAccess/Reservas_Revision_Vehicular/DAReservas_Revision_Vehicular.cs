using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;
namespace V4mvc.DataAccess
{
	public partial class DAReservas_Revision_Vehicular : IDAReservas_Revision_Vehicular
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Reservas_Revision_Vehicular> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAReservas_Revision_Vehicular(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Reservas_Revision_Vehicular>();
			Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Reservas_Revision_Vehicular> GetAll()
		{
			try
			{
				ObservableCollection<Reservas_Revision_Vehicular> items = new ObservableCollection<Reservas_Revision_Vehicular>();
				Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
				Instance.DAAsignarProcedure("_SI_UnReg");
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
		public Reservas_Revision_Vehicular GetOne(Decimal IDPROG)
		{
			try
			{
				Reservas_Revision_Vehicular item = new Reservas_Revision_Vehicular();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@IDPROG", IDPROG, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
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

		#region [ Metodos ]
		public bool Save(ref Reservas_Revision_Vehicular item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDPROG", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@IDPROG", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDPROG", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@PATENTE", item.PATENTE, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ORIGEN", item.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
