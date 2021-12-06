using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAAAQ_Regimen
	{
		#region [ Consultas ]
		//  ObservableCollection<AAQ_Regimen> GetOSTsPorEmpresa(string IDEMPRESA);
		ObservableCollection<AAQ_Regimen> GetListRegimenesPorCategoria_Mdte(int IDCATEGORIA);

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
