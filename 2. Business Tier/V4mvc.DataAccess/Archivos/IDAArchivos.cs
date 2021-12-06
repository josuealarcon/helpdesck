using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAArchivos
	{
		
		#region [ Consultas ]
		ObservableCollection<Archivos> GetAll();
        Archivos GetOne(Guid ID);
        #endregion

        #region [ Metodos ]
        bool Save(ref Archivos Item);
		#endregion
		
	}
}
