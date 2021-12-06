using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkerscasino
	{
		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		bool SaveWorkercasino_Ctta(string RUT, string LOCAL, string SERVICIO);
		bool DeleteWorkerCasino_Ctta(string RUT);

		#endregion
	}
}
