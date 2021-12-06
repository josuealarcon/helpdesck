using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_TipoContrato
	{
		
		#region [ Consultas ]
		ObservableCollection<Tab_TipoContrato> GetAll();
        Tab_TipoContrato GetOne(int ID_TIPOCONTRATO);
        #endregion

        #region [ Metodos ]
        bool Save(ref Tab_TipoContrato Item);
		#endregion
		
	}
}
