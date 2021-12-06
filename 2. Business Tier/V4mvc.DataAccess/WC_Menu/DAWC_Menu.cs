using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAWC_Menu : IDAWC_Menu
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<WC_Menu> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAWC_Menu(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<WC_Menu>();
			WC_Menu item = new WC_Menu();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<WC_Menu> GetAll()
		{
			try
			{
				ObservableCollection<WC_Menu> items = new ObservableCollection<WC_Menu>();
				WC_Menu item = new WC_Menu();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new WC_Menu();
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
		public WC_Menu GetOne(Decimal CODMENU)
		{
            try
            {
                WC_Menu item = new WC_Menu();
                Instance.DAAsignarProcedure("_SI_UnReg");
                Instance.DAAgregarParametro("@CODMENU", CODMENU, SqlDbType.Decimal, 9,0, ParameterDirection.Input);
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
		public bool Save(ref WC_Menu item)
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
						Instance.DAAgregarParametro("@CODMENU", item.CODMENU, SqlDbType.Decimal, 9, 0, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCMENU", item.DESCMENU, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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
