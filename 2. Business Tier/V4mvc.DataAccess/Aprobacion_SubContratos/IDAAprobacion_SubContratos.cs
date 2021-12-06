using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAAprobacion_SubContratos
	{
		
		#region [ Consultas ]
		ObservableCollection<Aprobacion_SubContratos> GetAll();
        Aprobacion_SubContratos GetOne(Int32 ID);
        #endregion

        #region [ Metodos ]
        bool Save(ref Aprobacion_SubContratos Item);
		#endregion
		
	}
}
