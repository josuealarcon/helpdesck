
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs_OST2
    {

        #region [ Consultas ]

        ObservableCollection<Docs_OST2> GetInformeContratosCArranqueDocsOst2Ctta(ref Docs_OST2 model);

        #endregion

        #region [ Metodos ]
        bool InsertDocsOST2_ContratOSTCtta(Guid ID_ARCHIVO, int ID_DOC, string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, string USUARIO);
        #endregion
    }
}
	