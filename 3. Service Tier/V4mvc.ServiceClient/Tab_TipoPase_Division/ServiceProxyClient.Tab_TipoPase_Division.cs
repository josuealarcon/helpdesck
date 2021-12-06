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
		public IBLTab_TipoPase_Division BL_Tab_TipoPase_Division { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTab_TipoPase_Division BL_Tab_TipoPase_Division)
        {
            this.BL_Tab_TipoPase_Division = BL_Tab_TipoPase_Division;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Tab_TipoPase_Division> GetAllTab_TipoPase_Division()
		{
			try
			{
				return this.BL_Tab_TipoPase_Division.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Tab_TipoPase_Division GetOneTab_TipoPase_Division(String TIPOPASE, String DIVISION)
		{
			try
			{
				if (TIPOPASE == null || DIVISION == null) { return null; }
				return this.BL_Tab_TipoPase_Division.GetOne(TIPOPASE, DIVISION);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTab_TipoPase_Division(ref Tab_TipoPase_Division Item)
		{
			try
			{
				return this.BL_Tab_TipoPase_Division.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTab_TipoPase_Division(ref ObservableCollection<Tab_TipoPase_Division> Items)
		{
			try
			{
				return this.BL_Tab_TipoPase_Division.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
