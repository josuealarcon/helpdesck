using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
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
		public IBLTypeTrans BL_TypeTrans { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTypeTrans BL_TypeTrans)
        {
            this.BL_TypeTrans = BL_TypeTrans;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<TypeTrans> GetAllTypeTrans_PasesCtta()
		{
			try
			{
				return this.BL_TypeTrans.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public TypeTrans GetOneTypeTrans()
		{
			try
			{
                return null;// this.BL_TypeTrans.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTypeTrans(ref TypeTrans Item)
		{
			try
			{
				return this.BL_TypeTrans.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTypeTrans(ref ObservableCollection<TypeTrans> Items)
		{
			try
			{
				return this.BL_TypeTrans.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
