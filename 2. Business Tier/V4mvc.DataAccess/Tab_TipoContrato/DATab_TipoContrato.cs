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
	public partial class DATab_TipoContrato : IDATab_TipoContrato
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Tab_TipoContrato> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DATab_TipoContrato(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Tab_TipoContrato>();
			Tab_TipoContrato item = new Tab_TipoContrato();
			Loader.EntityType = item.GetType();
            Instance = container;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Tab_TipoContrato> GetAll()
		{
			try
			{
				ObservableCollection<Tab_TipoContrato> items = new ObservableCollection<Tab_TipoContrato>();
				Tab_TipoContrato item = new Tab_TipoContrato();
				Instance.DAAsignarProcedure("TAB_ID_TSS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Tab_TipoContrato();
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
		public Tab_TipoContrato GetOne(int ID_TIPOCONTRATO)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Tab_TipoContrato item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("TAB_SI_UnReg");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("TAB_ID_TSU_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@Id_TipoContrato", item.Id_TipoContrato, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TipoContrato", item.TipoContrato, SqlDbType.NVarChar, 15, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Descripcion", item.Descripcion, SqlDbType.NVarChar, 30, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Activo", item.Activo, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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
