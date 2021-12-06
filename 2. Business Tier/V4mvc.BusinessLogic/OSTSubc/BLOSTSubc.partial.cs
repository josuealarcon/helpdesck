
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLOSTSubc
    {
        #region [ Consultas ]
        public ObservableCollection<OSTSubc> GetAllOSTSubC_ContratOSTCtta(string IDEMPRESA)
		{
			try
			{
				return this.Repository.GetAllOSTSubC_ContratOSTCtta(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
	