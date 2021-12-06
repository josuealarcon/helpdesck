using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using System.Reflection;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]


		public Finiquitos GetFiniquito_FuncionariosCtta(string RUT, string EMPRESA, int COMUN = 0)
		{
			try
			{
				return this.BL_Finiquitos.GetFiniquito_FuncionariosCtta(RUT, EMPRESA, COMUN);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool AprobarFiniquitoQv_FuncionariosCtta(string RUT, string USUARIO, string EMPRESA) {
			try
			{
				string parametros_mail = "";
				bool ret = this.BL_Finiquitos.AprobarFiniquitoQv_FuncionariosCtta(RUT, USUARIO, EMPRESA, ref parametros_mail);
				//TODO: send email
				return ret;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveFiniquito_FuncionariosCtta(Archivos archivo, string RUT, string IDEMPRESA, string USUARIO, Finiquitos finiquito)
		{
			try
			{
				return this.BL_Finiquitos.SaveFiniquito_FuncionariosCtta(archivo, RUT, IDEMPRESA, USUARIO, finiquito);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
