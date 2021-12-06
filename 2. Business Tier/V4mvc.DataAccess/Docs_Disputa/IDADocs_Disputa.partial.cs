using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Disputa
	{

        #region [ Consultas ]

        Docs_Disputa GetDocumentacionDisputaCtta(string RUT, string DIVCOD, int ID_DOC, Guid? ID, string COMUN_DIV, string IDEMPRESA);
        ObservableCollection<Docs_Disputa> GetInformeDocsPendientesDisputaCtta(ref Docs_Disputa model);

        #endregion

        #region [ Metodos ]

        bool SaveDisputa(ref Docs_Disputa item);

        #endregion
    }
}
