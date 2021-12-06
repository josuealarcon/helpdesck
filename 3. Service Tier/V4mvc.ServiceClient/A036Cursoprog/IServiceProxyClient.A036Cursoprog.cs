using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<A036Cursoprog> GetAllA036Cursosprogs();

		A036Cursoprog GetOneA036Cursoprog(Int32 CODIGO);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveA036Cursoprog(ref A036Cursoprog item);
		
		bool DeleteA036Cursoprog(ref A036Cursoprog item);
		
		bool SaveA036Cursosprogs(ref ObservableCollection<A036Cursoprog> items);
		
		#endregion

	}
}
