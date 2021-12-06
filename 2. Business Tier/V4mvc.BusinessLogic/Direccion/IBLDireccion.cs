using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDireccion
	{
		
		#region [ Consultas ]
		ObservableCollection<Direccion> GetAll();
        Direccion GetOne(String RUT);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Direccion Item);
		Boolean Save(ref ObservableCollection<Direccion> Items);
		#endregion
		
	}
}
