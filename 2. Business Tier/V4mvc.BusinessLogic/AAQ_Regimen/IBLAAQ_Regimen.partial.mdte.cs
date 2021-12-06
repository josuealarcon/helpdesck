using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLAAQ_Regimen
	{
		#region [ Consultas ]
		ObservableCollection<AAQ_Regimen> GetListRegimenesPorCategoria_Mdte(int IDCATEGORIA);

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
