using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Mutualidad> GetAllMutualidad();
        Mutualidad GetOneMutualidad(int IDMUTUAL);
        #endregion

        #region [ Metodos ]
        Boolean SaveMutualidad(ref Mutualidad Item);
		Boolean SaveMutualidad(ref ObservableCollection<Mutualidad> Items);
		#endregion
		
	}
}
