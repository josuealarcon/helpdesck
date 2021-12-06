using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		
		Finiquitos GetFiniquito_FuncionariosCtta(string RUT, string EMPRESA,int COMUN = 0);
		#endregion

		#region [ Metodos ]
		bool AprobarFiniquitoQv_FuncionariosCtta(string RUT, string USUARIO, string EMPRESA);
		bool SaveFiniquito_FuncionariosCtta(Archivos archivo, string RUT, string IDEMPRESA, string USUARIO, Finiquitos finiquito);
		#endregion

	}
}
