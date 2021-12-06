using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAEmpresascertificadoras : IDAEmpresascertificadoras
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Empresascertificadoras> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DAEmpresascertificadoras(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Empresascertificadoras>();
			var item = new Empresascertificadoras();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<Empresascertificadoras> GetAll()
		{
			try
			{
				var items = new ObservableCollection<Empresascertificadoras>();
				Instance.DAAsignarProcedure("V4MVC_EMPRESASCERTIFICADORAS_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Empresascertificadoras();
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

		public Empresascertificadoras GetOne(Int32 ID)
		{
			try
			{
				var item = new Empresascertificadoras();
				Instance.DAAsignarProcedure("V4MVC_EMPRESASCERTIFICADORAS_SELECT_ONE");
				Instance.DAAgregarParametro("@ID", ID, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ return null; }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref Empresascertificadoras item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_EMPRESASCERTIFICADORAS_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_EMPRESASCERTIFICADORAS_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 500, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRMOD", item.USRMOD, SqlDbType.NVarChar, 40, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@ID"].Value != null)
						{
							item.ID = Int32.Parse(Instance.DASqlCommand.Parameters["@ID"].Value.ToString());
						}
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref Empresascertificadoras item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_EMPRESASCERTIFICADORAS_DELETE");
					Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					return false;
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
