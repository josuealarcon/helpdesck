
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDALogDocsOST2
    {

        #region [ Consultas ]

        ObservableCollection<LogDocsOST2> GetAllLogDocsOST2_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, int ID_DOC);
        ObservableCollection<LogDocsOST2> GetInformeContratosCArranqueHistorialCtta(ref LogDocsOST2 model);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	