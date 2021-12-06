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

		ObservableCollection<DocsGrupos> GetAllDocsGrupos();

		DocsGrupos GetOneDocsGrupo(Int32 ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveDocsGrupo(ref DocsGrupos item);
		
		bool DeleteDocsGrupo(ref DocsGrupos item);
		
		bool SaveDocsGrupos(ref ObservableCollection<DocsGrupos> items);
		
		#endregion

	}
}
