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

		ObservableCollection<Gerencias_General> GetAllGerencias_Generales();

		Gerencias_General GetOneGerencias_General(decimal IDGENERAL);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveGerencias_General(ref Gerencias_General item);
		
		bool DeleteGerencias_General(ref Gerencias_General item);
		
		bool SaveGerencias_Generales(ref ObservableCollection<Gerencias_General> items);
		
		#endregion

	}
}
