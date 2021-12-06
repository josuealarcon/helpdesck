using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCheckDetail
	{
		#region [ Consultas ]
		ObservableCollection<CheckDetail> GetPreguntasListadoEncuestas_Ctta(int ID_CHECKINGHEAD);

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
