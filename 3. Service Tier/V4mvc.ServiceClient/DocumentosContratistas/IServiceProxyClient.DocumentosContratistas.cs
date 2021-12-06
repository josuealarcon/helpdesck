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

		ObservableCollection<DocumentosContratistas> GetAllDocumentosContratistas(ref DocumentosContratistas documentosContratistas);

		DocumentosContratistas GetOneDocumentoContratistas(Int32 IDCTTA_DOC);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveDocumentoContratistas(ref DocumentosContratistas item);
		
		bool DeleteDocumentoContratistas(ref DocumentosContratistas item);
		
		bool SaveDocumentosContratistas(ref ObservableCollection<DocumentosContratistas> items);
		
		#endregion

	}
}
