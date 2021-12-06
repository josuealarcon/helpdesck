using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALiquidacion
	{
		
		#region [ Consultas ]
		ObservableCollection<Liquidacion> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Liquidacion Item);
		#endregion
		
	}
}
