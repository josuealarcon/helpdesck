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

		ObservableCollection<Empresascertificadoras> GetAllEmpresascertificadoras();

		Empresascertificadoras GetOneEmpresascertificadora(Int32 ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveEmpresascertificadora(ref Empresascertificadoras item);
		
		bool DeleteEmpresascertificadora(ref Empresascertificadoras item);
		
		bool SaveEmpresascertificadoras(ref ObservableCollection<Empresascertificadoras> items);
		
		#endregion

	}
}
