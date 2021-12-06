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

		public ObservableCollection<Docs_Formato> GetDocsFormatDocumentacionCtta(int ID_DOC)
		{
			try
			{
				return this.BL_Docs_Formato.GetDocsFormatDocumentacionCtta(ID_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Docs_Formato GetDocumentoExtensionesCtta(int ID_DOC)
		{
			try
			{
				return this.BL_Docs_Formato.GetDocumentoExtensionesCtta(ID_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
