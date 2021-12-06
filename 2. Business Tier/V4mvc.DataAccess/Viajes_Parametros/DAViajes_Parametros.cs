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
	public partial class DAViajes_Parametros : IDAViajes_Parametros
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Viajes_Parametros> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAViajes_Parametros(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Viajes_Parametros>();
			Viajes_Parametros item = new Viajes_Parametros();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Viajes_Parametros> GetAll()
		{
			try
			{
				ObservableCollection<Viajes_Parametros> items = new ObservableCollection<Viajes_Parametros>();
				Viajes_Parametros item = new Viajes_Parametros();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Viajes_Parametros();
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
		public Viajes_Parametros GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Viajes_Parametros item)
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
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@TIEMPO_CANCELA", item.TIEMPO_CANCELA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIEMPO_RESERVA", item.TIEMPO_RESERVA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTROL_PEREZ", item.CONTROL_PEREZ, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDA_VUELTA", item.IDA_VUELTA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIAS_CASTIGO", item.DIAS_CASTIGO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PORC_NOUTILIZA", item.PORC_NOUTILIZA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PERIODO_NOUTILIZA", item.PERIODO_NOUTILIZA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTROL_NOUTILIZA", item.CONTROL_NOUTILIZA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GLOSA_TICKET", item.GLOSA_TICKET, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GLOSA", item.GLOSA, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CORREO_ADICIONAL", item.CORREO_ADICIONAL, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CONTROL_MANTENCION", item.CONTROL_MANTENCION, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CANCELA_REALIZADO", item.CANCELA_REALIZADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CANTIDAD_SUBIDAS", item.CANTIDAD_SUBIDAS, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CANTIDAD_BAJADAS", item.CANTIDAD_BAJADAS, SqlDbType.Int, 4, ParameterDirection.Input);
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
