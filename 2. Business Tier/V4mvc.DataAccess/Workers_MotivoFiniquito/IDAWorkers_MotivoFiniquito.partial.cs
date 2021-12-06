using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkers_MotivoFiniquito
	{

		#region [ Consultas ]
		bool getMotivoUltimo(string MOTIVO, string RUT, string EMPRESA, int ID_DOC);
		#endregion

		#region [ Metodos ]
		bool SaveWorkerMotivFiniq_FuncionariosCtta(ref Workers_MotivoFiniquito Item);
		#endregion
	}
}
