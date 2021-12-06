using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkers_MotivoFiniquito
	{
		
		#region [ Consultas ]
		ObservableCollection<Workers_MotivoFiniquito> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Workers_MotivoFiniquito Item);
		#endregion
		
	}
}
