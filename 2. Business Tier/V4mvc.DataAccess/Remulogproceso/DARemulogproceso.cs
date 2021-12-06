using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;
namespace V4mvc.DataAccess
{
	public partial class DARemulogproceso : IDARemulogproceso
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Remulogproceso> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DARemulogproceso(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Remulogproceso>();
			Remulogproceso item = new Remulogproceso();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Remulogproceso> GetAll()
		{
			try
			{
				ObservableCollection<Remulogproceso> items = new ObservableCollection<Remulogproceso>();
				Remulogproceso item = new Remulogproceso();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Remulogproceso();
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
		public Remulogproceso GetOne(Decimal IDPROG)
		{
			try
			{
				Remulogproceso item = new Remulogproceso();
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
		public bool Save(ref Remulogproceso item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");;
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
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
