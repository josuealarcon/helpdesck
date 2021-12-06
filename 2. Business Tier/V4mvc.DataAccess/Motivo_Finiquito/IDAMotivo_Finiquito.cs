using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAMotivo_Finiquito
	{
		
		#region [ Consultas ]
		ObservableCollection<Motivo_Finiquito> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Motivo_Finiquito Item);
		#endregion
		
	}
}
