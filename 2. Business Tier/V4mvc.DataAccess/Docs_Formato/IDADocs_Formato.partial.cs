using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Formato
	{

        #region [ Consultas ]

        ObservableCollection<Docs_Formato> GetDocsFormatDocumentacionCtta(int ID_DOC);
        bool ExistsDocsFormato_ContratOSTCtta(string EXTENSION, int index);
        Docs_Formato GetDocumentoExtensionesCtta(int ID_DOC_EXT);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
