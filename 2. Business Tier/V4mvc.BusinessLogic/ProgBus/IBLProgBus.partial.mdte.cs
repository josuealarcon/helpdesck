using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLProgBus
	{

		#region [ Consultas ]
		ObservableCollection<ProgBus> GetListBusesProgramacion_mdte(ProgBus ProgBus);

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
