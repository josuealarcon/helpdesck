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
	public partial class DACertDesautorizacionTransport : IDACertDesautorizacionTransport
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<CertDesautorizacionTransport> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DACertDesautorizacionTransport(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<CertDesautorizacionTransport>();
			var item = new CertDesautorizacionTransport();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<CertDesautorizacionTransport> GetAll()
		{
			try
			{
				var items = new ObservableCollection<CertDesautorizacionTransport>();
				Instance.DAAsignarProcedure("V4MVC_CERT_DESAUTORIZACION_TRANSPORT_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new CertDesautorizacionTransport();
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

		public CertDesautorizacionTransport GetOne(string PATENTE)
		{
			try
			{
				var item = new CertDesautorizacionTransport();
				Instance.DAAsignarProcedure("V4MVC_CERT_DESAUTORIZACION_TRANSPORT_SELECT_ONE");
				Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

		public bool Save(ref CertDesautorizacionTransport item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_CERT_DESAUTORIZACION_TRANSPORT_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_CERT_DESAUTORIZACION_TRANSPORT_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@PATENTE", item.PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBSERVACION", item.OBSERVACION, SqlDbType.NVarChar, 400, ParameterDirection.Input);
						Instance.DAAgregarParametro("@BLOQUEA", item.BLOQUEA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_ARCHIVO", item.ID_ARCHIVO.Value, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USRBLOQUEA", item.USRBLOQUEA, SqlDbType.NVarChar, 40, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECBLOQUEA", item.FECBLOQUEA, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORABLOQUEA", item.HORABLOQUEA, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PATENTE", item.PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@PATENTE"].Value != null)
						{
							item.PATENTE = (Instance.DASqlCommand.Parameters["@PATENTE"].Value.ToString());
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

		public bool Delete(ref CertDesautorizacionTransport item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_CERT_DESAUTORIZACION_TRANSPORT_DELETE");
					Instance.DAAgregarParametro("@PATENTE", item.PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
