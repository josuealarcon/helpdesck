using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAProgBus
	{

		#region [ Consultas ]
		ObservableCollection<ProgBus> GetListBusesProgramacion_mdte(ProgBus ProgBus);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
