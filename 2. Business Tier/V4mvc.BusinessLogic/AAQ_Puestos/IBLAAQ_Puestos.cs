using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLAAQ_Puestos
	{
		#region [ Consultas ]

		ObservableCollection<AAQ_Puestos> GetAllPuestos_Mdte(ref AAQ_Puestos item); 

		AAQ_Puestos GetOnePuestos_Mdte(Int32 IDPUESTO);

		#endregion

		#region [ Metodos ]

	
		bool DeletePuestos_Mdte(string IDPUESTO);


		#endregion
	}
}