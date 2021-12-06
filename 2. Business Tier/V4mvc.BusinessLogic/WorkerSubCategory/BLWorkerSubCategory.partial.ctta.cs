using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLWorkerSubCategory
	{

		#region [ Consultas ]


        public ObservableCollection<WorkerSubCategory> GetAllWorkerSubCategory_PasesCtta()
        {
            try
            {
                return this.Repository.GetAllWorkerSubCategory_PasesCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
