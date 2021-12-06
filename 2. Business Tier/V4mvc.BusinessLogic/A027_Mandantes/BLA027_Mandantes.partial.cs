using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLA027_Mandantes
	{

		#region [ Consultas ]

		public A027_Mandantes GetA027_MandantesEmpresa(string EMPRESA)
        {
			try
			{
				return this.Repository.GetA027_MandantesEmpresa(EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
