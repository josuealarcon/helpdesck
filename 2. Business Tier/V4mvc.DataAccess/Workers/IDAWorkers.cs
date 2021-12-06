using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkers
	{
		
		#region [ Consultas ]
		ObservableCollection<Workers> GetAll();
		Workers GetOne(String RUT);
		Workers Getworkersctta(String RUT, string EMPRESA );
		#endregion

		#region [ Metodos ]
		bool Save(ref Workers Item);
		#endregion
		
	}
}
