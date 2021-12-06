using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADivisiones
	{
		
		#region [ Consultas ]
		ObservableCollection<Divisiones> GetAll();
		ObservableCollection<Divisiones> GetAllA024Divisiones_FiniquitolCtta(string RUT);
        
        Divisiones GetOne(String DIVCOD);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Divisiones Item);
		#endregion
		
	}
}
