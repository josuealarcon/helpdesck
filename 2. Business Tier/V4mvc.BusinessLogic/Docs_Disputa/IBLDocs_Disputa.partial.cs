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

        ObservableCollection<Docs_Disputa> GetInformeDocsPendientesDisputaCtta(ref Docs_Disputa model);

        #endregion

        #region [ Metodos ]

        bool SaveDisputa(ref Docs_Disputa Item);

        #endregion

    }
}
