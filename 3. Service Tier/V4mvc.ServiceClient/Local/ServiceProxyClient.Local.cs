using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;
namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{
		
		#region [ Propiedades ]
		[Dependency]
		public IBLLocal BL_Local { get; set; }
        #endregion
        #region [ Constructor]
        public ServiceProxyClient(IBLLocal BL_Local)
        {
            this.BL_Local = BL_Local;
        }

        #endregion
        #region [ Consultas ]
        public ObservableCollection<Local> GetAllLocal()
		{
			try
			{
				return this.BL_Local.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Local GetOneLocal(String LOCAL, String EMPRESAL, String LOCALL)
		{
			try
			{
				if (LOCAL == null || EMPRESAL == null || LOCALL == null) { return null; }
				return this.BL_Local.GetOne(LOCAL, EMPRESAL, LOCALL);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion		
		#region [ Metodos ]
		public Boolean SaveLocal(ref Local Item)
		{
			try
			{
				return this.BL_Local.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveLocal(ref ObservableCollection<Local> Items)
		{
			try
			{
				return this.BL_Local.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
