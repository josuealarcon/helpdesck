using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAMotivo_Finiquito : IDAMotivo_Finiquito
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
        public LoaderEntity<Motivo_Finiquito> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAMotivo_Finiquito(IDataAccessEnterprise container)
		{
            this.Instance = container;
            Loader = new LoaderEntity<Motivo_Finiquito>();
			Motivo_Finiquito item = new Motivo_Finiquito();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Motivo_Finiquito> GetAll()
		{
			try
			{
				ObservableCollection<Motivo_Finiquito> items = new ObservableCollection<Motivo_Finiquito>();
				Motivo_Finiquito item = new Motivo_Finiquito();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Motivo_Finiquito();
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
		public Motivo_Finiquito GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Motivo_Finiquito item)
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
							Instance.DAAsignarProcedure("_SU_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@MOTIVO", item.MOTIVO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GLOSA", item.GLOSA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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
