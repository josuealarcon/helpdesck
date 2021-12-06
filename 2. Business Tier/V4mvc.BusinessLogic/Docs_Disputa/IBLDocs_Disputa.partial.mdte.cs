using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Disputa
	{

        #region [ Consultas ]
        ObservableCollection<Docs_Disputa> GetListDocsDisputa_Mdte(ref Docs_Disputa item);
        Docs_Disputa GetOneDocsDisputaFuncionario_Mdte(string IDDISPUTA);
        Docs_Disputa GetOneDocsDisputaVehiculo_Mdte(string IDDISPUTA, string PATENTE);

        #endregion

        #region [ Metodos ] 
        bool SaveDocDisputaFuncionario(Docs_Disputa Item);
        #endregion

    }
}
