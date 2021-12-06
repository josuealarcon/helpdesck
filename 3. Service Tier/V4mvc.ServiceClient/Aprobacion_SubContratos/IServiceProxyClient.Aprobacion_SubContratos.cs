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
		ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratos();
        Aprobacion_SubContratos GetOneAprobacion_SubContratos(Int32 ID);
        #endregion

        #region [ Metodos ]
        Boolean SaveAprobacion_SubContratos(ref Aprobacion_SubContratos Item);
		Boolean SaveAprobacion_SubContratos(ref ObservableCollection<Aprobacion_SubContratos> Items);
		#endregion
		
	}
}
