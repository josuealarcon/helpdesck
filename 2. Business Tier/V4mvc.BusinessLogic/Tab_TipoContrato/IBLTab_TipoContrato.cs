using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTab_TipoContrato
	{
		
		#region [ Consultas ]
		ObservableCollection<Tab_TipoContrato> GetAll();
        Tab_TipoContrato GetOne(int ID_TIPOCONTRATO);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Tab_TipoContrato Item);
		Boolean Save(ref ObservableCollection<Tab_TipoContrato> Items);
		#endregion
		
	}
}
