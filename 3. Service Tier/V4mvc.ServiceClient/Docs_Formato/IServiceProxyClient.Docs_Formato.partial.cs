using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		ObservableCollection<Docs_Formato> GetDocsFormatDocumentacionCtta(int ID_DOC);
		Docs_Formato GetDocumentoExtensionesCtta(int ID_DOC);

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
