using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLFiniquitos
	{

		#region [ Consultas ]
		Finiquitos GetFiniquito_FuncionariosCtta(string RUT, string EMPRESA, int COMUN = 0);
		

		#endregion

		#region [ Metodos ]
		bool AprobarFiniquitoQv_FuncionariosCtta(string RUT, string USUARIO, string EMPRESA, ref string parametros_mail);
		bool SaveFiniquito_FuncionariosCtta(Archivos archivo, string RUT, string IDEMPRESA, string USUARIO, Finiquitos finiquito);
		#endregion

	}
}
