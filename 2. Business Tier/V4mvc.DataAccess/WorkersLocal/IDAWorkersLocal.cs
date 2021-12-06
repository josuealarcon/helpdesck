using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkersLocal
	{
		
		#region [ Consultas ]
		ObservableCollection<WorkersLocal> GetAll();

        WorkersLocal GetOne(String RUT, String DIVISION, String EMPRESA);

        #endregion

        #region [ Metodos ]
        bool Save(ref WorkersLocal Item);

		#endregion
		
	}
}
