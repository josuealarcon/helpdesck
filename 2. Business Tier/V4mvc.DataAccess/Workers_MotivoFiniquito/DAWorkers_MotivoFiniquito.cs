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
	public partial class DAWorkers_MotivoFiniquito : IDAWorkers_MotivoFiniquito
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Workers_MotivoFiniquito> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAWorkers_MotivoFiniquito(IDataAccessEnterprise container)
		{
			Instance = container;
			Loader = new LoaderEntity<Workers_MotivoFiniquito>();
			Workers_MotivoFiniquito item = new Workers_MotivoFiniquito();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Workers_MotivoFiniquito> GetAll()
		{
			try
			{
				ObservableCollection<Workers_MotivoFiniquito> items = new ObservableCollection<Workers_MotivoFiniquito>();
				Workers_MotivoFiniquito item = new Workers_MotivoFiniquito();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Workers_MotivoFiniquito();
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
		public Workers_MotivoFiniquito GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Workers_MotivoFiniquito item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_WORKERS_MOTIVOFINIQUITO_INSERT");
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
						Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDARCHIVO", item.IDARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MOTIVO", item.MOTIVO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRREGISTRA", item.USRREGISTRA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAREGISTRA", item.FECHAREGISTRA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAREGISTRA", item.HORAREGISTRA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRMOD", item.USRMOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
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
