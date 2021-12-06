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
		ObservableCollection<Direccion> GetAllDireccion();
        Direccion GetOneDireccion(String RUT);
        #endregion

        #region [ Metodos ]
        Boolean SaveDireccion(ref Direccion Item);
		Boolean SaveDireccion(ref ObservableCollection<Direccion> Items);
		#endregion
		
	}
}
