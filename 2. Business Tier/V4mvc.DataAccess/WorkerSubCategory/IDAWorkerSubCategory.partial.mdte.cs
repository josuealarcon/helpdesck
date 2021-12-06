using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkerSubCategory
	{

		#region [ Consultas ]
        ObservableCollection<WorkerSubCategory> GetAllWorkerSubCategory_PasesMdte();
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
