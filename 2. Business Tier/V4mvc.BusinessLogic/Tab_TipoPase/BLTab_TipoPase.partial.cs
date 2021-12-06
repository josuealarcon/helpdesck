using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLTab_TipoPase
	{

		#region [ Consultas ]
		public ObservableCollection<Tab_TipoPase> GetAllTabTipoPase_PasesCtta()
        {
            try
            {
                return this.Repository.GetAllTabTipoPase_PasesCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
