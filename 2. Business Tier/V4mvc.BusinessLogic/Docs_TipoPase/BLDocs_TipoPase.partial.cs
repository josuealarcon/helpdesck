using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_TipoPase
	{

		#region [ Consultas ]
		public ObservableCollection<Docs_TipoPase> GetDocsTipoPaseDivision(string DIVCOD)
		{
			try
			{
				return Repository.GetDocsTipoPaseDivision(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Docs_TipoPase> GetFecDocsTipoPaseDivision(string DIVCOD)
		{
			try
			{
				return Repository.GetFecDocsTipoPaseDivision(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
