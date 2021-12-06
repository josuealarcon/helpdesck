using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Formato
	{

		#region [ Consultas ]


		public ObservableCollection<Docs_Formato> GetDocsFormatDocumentacionCtta(int ID_DOC)
		{
			try
			{
				return Repository.GetDocsFormatDocumentacionCtta(ID_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Docs_Formato GetDocumentoExtensionesCtta(int ID_DOC)
		{
			try
			{
				return Repository.GetDocumentoExtensionesCtta(ID_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
