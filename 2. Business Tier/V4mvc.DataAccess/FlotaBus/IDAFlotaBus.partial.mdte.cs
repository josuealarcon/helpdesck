using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAFlotaBus
	{
		#region [ Consultas ]
		ObservableCollection<FlotaBus> GetListFlotaBus_Mdte(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
