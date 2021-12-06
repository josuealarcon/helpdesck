using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLE200_Dothh
	{
		#region [ Consultas ]
		public ObservableCollection<E200_Dothh> GetSubContratistasE200Dot_Ctta(string OST)
		{
			try
			{
				return this.Repository.GetSubContratistasE200Dot_Ctta(OST);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool Save_E200_Dothh_Ctta(ref ObservableCollection<E200_Dothh> items)
		{
			try
			{
				for (int i = 0; i < items.Count; ++i)
				{
					var item = items.ElementAt(i);
					this.Repository.Save_E200_Dothh_Ctta(ref item);
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<E200_Dothh> GetAllE200_Datos_Dothh_SubcontratistaCtta(Guid ID)
		{
			try
			{
				return this.Repository.GetAllE200_Datos_Dothh_SubcontratistaCtta(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
