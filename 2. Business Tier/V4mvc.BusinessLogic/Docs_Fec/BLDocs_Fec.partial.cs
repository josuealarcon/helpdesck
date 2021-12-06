using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Fec
	{

		#region [ Consultas ]
		public ObservableCollection<Docs_Fec> GetFechasFiniquito_FuncionariosCtta(string RUT, string EMPRESA)
		{
			try
			{
				return this.Repository.GetFechasFiniquito_FuncionariosCtta(RUT, EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Nullable<DateTime> GetNowAsDateTime()
		{
			try
			{
				return Repository.GetNowAsDateTime();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
