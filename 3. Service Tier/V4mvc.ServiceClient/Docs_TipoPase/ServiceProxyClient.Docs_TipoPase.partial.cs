using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]
		public ObservableCollection<Docs_TipoPase> GetDocsTipoPaseDivision(string DIVCOD)
		{
			try
			{
				return this.BL_Docs_TipoPase.GetDocsTipoPaseDivision(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Docs_TipoPase> GetFecDocsTipoPaseDivision(string DIVCOD)
		{
			try
			{
				return this.BL_Docs_TipoPase.GetFecDocsTipoPaseDivision(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
