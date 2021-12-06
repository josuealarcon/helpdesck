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
		public ObservableCollection<ProgBus> GetListusesProgramacion_mdte(ProgBus ProgBus)
		{
			try
			{
				return this.BL_ProgBus.GetListBusesProgramacion_mdte(ProgBus);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
