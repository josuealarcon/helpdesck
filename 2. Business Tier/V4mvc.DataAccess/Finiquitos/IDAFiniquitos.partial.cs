using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAFiniquitos
	{

		#region [ Consultas ]
		#endregion

		#region [ Metodos ]
		bool AprobarFiniquitoQv_FuncionariosCtta(string RUT, string USUARIO, string EMPRESA, ref string parametros_mail);
		#endregion
	}
}
