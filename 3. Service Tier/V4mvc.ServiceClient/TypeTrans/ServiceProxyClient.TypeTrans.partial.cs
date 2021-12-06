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
		
		public ObservableCollection<TypeTrans> GetTypeTransCombo()
		{
			try
			{
				return this.BL_TypeTrans.GetTypeTransCombo();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<TypeTrans> GetTypeTrans_Informes()
		{
			try
			{
				return this.BL_TypeTrans.GetTypeTrans_Informes();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public TypeTrans GetOneTypeTrans_Informes(int IDTIPO)
		{
			try
			{
				return this.BL_TypeTrans.GetOneTypeTrans_Informes(IDTIPO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
