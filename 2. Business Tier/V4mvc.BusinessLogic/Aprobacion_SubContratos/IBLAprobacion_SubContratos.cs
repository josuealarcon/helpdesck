using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLAprobacion_SubContratos
	{
		
		#region [ Consultas ]
		ObservableCollection<Aprobacion_SubContratos> GetAll();
        Aprobacion_SubContratos GetOne(Int32 ID);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Aprobacion_SubContratos Item);
		Boolean Save(ref ObservableCollection<Aprobacion_SubContratos> Items);
		#endregion
		
	}
}
