using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADireccion
	{
		
		#region [ Consultas ]
		ObservableCollection<Direccion> GetAll();

        Direccion GetOne(String RUT);

        #endregion

        #region [ Metodos ]
        bool Save(ref Direccion Item);
		#endregion
		
	}
}
