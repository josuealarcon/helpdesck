using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DABonosValor : IDABonosValor
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<BonosValor> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		#endregion

		#region [ Constructores ]
		public DABonosValor(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<BonosValor>();
			BonosValor item = new BonosValor();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<BonosValor> GetAll()
		{
			try
			{
				ObservableCollection<BonosValor> items = new ObservableCollection<BonosValor>();
				BonosValor item = new BonosValor();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new BonosValor();
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
		public BonosValor GetOne(Int32 ID_VALOR)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref BonosValor item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID_VALOR", item.ID_VALOR, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@ID_VALOR", item.ID_VALOR, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID_VALOR", item.ID_VALOR, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID_BONO", item.ID_BONO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALOR", item.VALOR, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PAGO_FUNC", item.PAGO_FUNC, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EP_FACTURA", item.EP_FACTURA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PERIODOINI", item.PERIODOINI, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PERIODOFIN", item.PERIODOFIN, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ASISTENCIAINI", item.ASISTENCIAINI, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ASISTENCIAFIN", item.ASISTENCIAFIN, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PORCASISTENCIA", item.PORCASISTENCIA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRMOD", item.USRMOD, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERRADO", item.CERRADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA_CIERRE", item.FECHA_CIERRE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORA_CIERRE", item.HORA_CIERRE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO_CIERRE", item.USUARIO_CIERRE, SqlDbType.NVarChar, 12, ParameterDirection.Input);
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
