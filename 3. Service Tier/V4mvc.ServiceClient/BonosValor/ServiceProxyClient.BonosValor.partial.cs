using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public BonosValor GetBonosValorCtta(string TIPO_BONO, string PERIODO, string DIVISION)
		{
			try
			{
				return this.BL_BonosValor.GetBonosValorCtta(TIPO_BONO, PERIODO, DIVISION);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
