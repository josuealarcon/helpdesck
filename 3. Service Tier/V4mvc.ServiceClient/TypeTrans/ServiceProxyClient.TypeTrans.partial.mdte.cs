using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]
		public ObservableCollection<TypeTrans> GetAllTypeTrans_PasesMdte()
		{
			try
			{
				return this.BL_TypeTrans.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<TypeTrans> GetAllTypeTrans_CertificacionMdte()
		{
			try
			{
				return this.BL_TypeTrans.GetAllTypeTrans_CertificacionMdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<TypeTrans> GetListTypeTrans_Mdte()
		{
			try
			{
				return this.BL_TypeTrans.GetListTypeTrans_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion


		#region [ Metodos ]

		#endregion

	}
}
