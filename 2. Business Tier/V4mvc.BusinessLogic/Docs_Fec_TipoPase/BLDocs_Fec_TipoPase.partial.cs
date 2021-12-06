using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Fec_TipoPase
	{

		#region [ Consultas ]
		public ObservableCollection<Docs_Fec_TipoPase> GetDocsFecTipoPaseDivision(string DIVCOD)
		{
			try
			{
				return Repository.GetDocsFecTipoPaseDivision(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
