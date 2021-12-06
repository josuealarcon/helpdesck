using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAEnterprise
	{
		
		#region [ Consultas ]
		ObservableCollection<Enterprise> GetAll();
		Enterprise GetOne(String IDEMPRESA);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Enterprise Item);
		#endregion
		
	}
}
