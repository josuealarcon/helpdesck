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
	public partial class DATypeTrans : IDATypeTrans
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<TypeTrans> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
		#endregion
		
		#region [ Constructores ]
		public DATypeTrans(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<TypeTrans>();
			TypeTrans item = new TypeTrans();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<TypeTrans> GetAll()
		{
			try
			{
				ObservableCollection<TypeTrans> items = new ObservableCollection<TypeTrans>();
				TypeTrans item = new TypeTrans();
				Instance.DAAsignarProcedure("V4MVC_TYPETRANS_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new TypeTrans();
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
		public TypeTrans GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref TypeTrans item)
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
						Instance.DAAgregarParametro("@IDTIPO", item.IDTIPO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DSCTIPOV", item.DSCTIPOV, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DURACION", item.DURACION, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPOV", item.TIPOV, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LICENCIAS", item.LICENCIAS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDSYNC", item.IDSYNC, SqlDbType.BigInt, 8, ParameterDirection.Input);
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
