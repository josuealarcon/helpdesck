using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]
		public ObservableCollection<E200_Dothh> GetSubContratistasE200Dot_Ctta(string OST)
		{
			try
			{
				return this.BL_E200_Dothh.GetSubContratistasE200Dot_Ctta(OST);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		
		public  bool Save_E200_Dothh_Ctta(ref ObservableCollection<E200_Dothh> items)
		{
			try
			{
				return this.BL_E200_Dothh.Save_E200_Dothh_Ctta(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<E200_Dothh> GetAllE200_Datos_Dothh_SubcontratistaCtta(Guid ID)
		{
			try
			{
				return this.BL_E200_Dothh.GetAllE200_Datos_Dothh_SubcontratistaCtta(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
