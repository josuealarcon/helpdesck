using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAMutualidad
	{
		
		#region [ Consultas ]
		ObservableCollection<Mutualidad> GetAll();
        Mutualidad GetOne(int IDMUTUAL);
        #endregion

        #region [ Metodos ]
        bool Save(ref Mutualidad Item);
		#endregion
		
	}
}
