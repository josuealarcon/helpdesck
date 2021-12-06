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
		public ObservableCollection<Docs_Fec> GetListFechasDocumentos_Mdte()
		{
			try
			{
				return this.Repository.GetListFechasDocumentos_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Docs_Fec> GetAllDocsFecSelect_mdte()
        {
			try
			{
				return this.Repository.GetAllDocsFecSelect_mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
