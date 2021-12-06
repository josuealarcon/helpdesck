using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAAAQ_Puestos
	{
		#region [ Consultas ]
		#endregion
		#region [ Metodos ]
		bool SaveUpdatePuestos_Mdte(ref AAQ_Puestos item);
		#endregion
	}
}