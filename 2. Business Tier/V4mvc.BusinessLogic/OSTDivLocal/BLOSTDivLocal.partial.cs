
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLOSTDivLocal
    {
        #region [ Consultas ]
        public ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_ContratOSTCtta(string NROOST)
		{
			try
			{
				return this.Repository.GetAllOSTDivLocal_ContratOSTCtta(NROOST);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
	