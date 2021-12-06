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
	public partial class DADocs_Fec_TipoPase : IDADocs_Fec_TipoPase
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Docs_Fec_TipoPase> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DADocs_Fec_TipoPase(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Docs_Fec_TipoPase>();
			Docs_Fec_TipoPase item = new Docs_Fec_TipoPase();
			Loader.EntityType = item.GetType();
            Instance = container;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_Fec_TipoPase> GetAll()
		{
			try
			{
				ObservableCollection<Docs_Fec_TipoPase> items = new ObservableCollection<Docs_Fec_TipoPase>();
				Docs_Fec_TipoPase item = new Docs_Fec_TipoPase();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Docs_Fec_TipoPase();
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
		public Docs_Fec_TipoPase GetOne()
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Docs_Fec_TipoPase item)
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
						Instance.DAAgregarParametro("@TIPOPASE", item.TIPOPASE, SqlDbType.NVarChar, 9, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC_FEC", item.ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
