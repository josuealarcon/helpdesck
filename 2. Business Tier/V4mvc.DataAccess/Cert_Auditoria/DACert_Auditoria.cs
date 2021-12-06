using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DACert_Auditoria : IDACert_Auditoria
	{

		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Cert_Auditoria> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }

		#endregion

		#region [ Constructores ]

		public DACert_Auditoria(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Cert_Auditoria>();
			Cert_Auditoria item = new Cert_Auditoria();
			Loader.EntityType = item.GetType();
		}

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Cert_Auditoria> GetAll(string IDEMPRESA)
		{
			try
			{
				ObservableCollection<Cert_Auditoria> items = new ObservableCollection<Cert_Auditoria>();
				Cert_Auditoria item = new Cert_Auditoria();
				Instance.DAAsignarProcedure("V4MVC_CERT_AUDITORIA_SELECT_CTTA");
				Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Cert_Auditoria();
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

		public Cert_Auditoria GetOne(int ID_CERT_AUDITORIA)
		{
			try
			{
				Cert_Auditoria item = new Cert_Auditoria();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@ID_CERT_AUDITORIA", ID_CERT_AUDITORIA, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool Save(ref Cert_Auditoria item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID_CERT_AUDITORIA", item.ID_CERT_AUDITORIA, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@ID_CERT_AUDITORIA", item.ID_CERT_AUDITORIA, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID_CERT_AUDITORIA", item.ID_CERT_AUDITORIA, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PERIODO", item.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPO_AUDITORIA", item.TIPO_AUDITORIA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PORCENTAJE_APROBACION", item.PORCENTAJE_APROBACION, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CANT_PERSONAS", item.CANT_PERSONAS, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBSERVACION", item.OBSERVACION, SqlDbType.NVarChar, 500, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHASUBE", item.FECHASUBE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERTUSUARIO", item.CERTUSUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERTFECHA", item.CERTFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CERTHORA", item.CERTHORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIOMOD", item.USUARIOMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NCONTRATO", item.NCONTRATO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@COD_INTERNO_CERT", item.COD_INTERNO_CERT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_FOLIO", item.ID_FOLIO, SqlDbType.Int, 4, ParameterDirection.Input);
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
