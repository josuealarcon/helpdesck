using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DACert_Auditoria
    {

		#region [ Consultas ]

		public ObservableCollection<Cert_Auditoria> GetAllLog_Cert_AuditoriaCtta(int ID_CERT_AUDITORIA)
		{
			try
			{
				ObservableCollection<Cert_Auditoria> items = new ObservableCollection<Cert_Auditoria>();
				Cert_Auditoria item = new Cert_Auditoria();
				Instance.DAAsignarProcedure("V4MVC_LOG_CERT_AUDITORIA_SELECT_CTTA");
				Instance.DAAgregarParametro("@ID_CERT_AUDITORIA", ID_CERT_AUDITORIA, SqlDbType.Int, 4, ParameterDirection.Input);
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

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
