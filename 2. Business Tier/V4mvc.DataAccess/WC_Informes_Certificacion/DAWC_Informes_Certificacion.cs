using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAWC_Informes_Certificacion : IDAWC_Informes_Certificacion
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<WC_Informes_Certificacion> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		#endregion

		#region [ Constructores ]
		public DAWC_Informes_Certificacion(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<WC_Informes_Certificacion>();
			WC_Informes_Certificacion item = new WC_Informes_Certificacion();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<WC_Informes_Certificacion> GetAll()
		{
			try
			{
				ObservableCollection<WC_Informes_Certificacion> items = new ObservableCollection<WC_Informes_Certificacion>();
				WC_Informes_Certificacion item = new WC_Informes_Certificacion();
				Instance.DAAsignarProcedure("V4MVC_WC_INFORMES_CERTIFICACION_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new WC_Informes_Certificacion();
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
		public WC_Informes_Certificacion GetOne(Decimal CODMENU)
		{
			try
			{
				WC_Informes_Certificacion item = new WC_Informes_Certificacion();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@CODMENU", CODMENU, SqlDbType.Decimal, 9, 0, ParameterDirection.Input);
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

		#region [ Metodos ]

		#endregion
	}
}