
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLDocs_OST2
    {

        #region [ Consultas ]

        ObservableCollection<Docs_OST2> GetInformeContratosCArranqueDocsOst2Ctta(ref Docs_OST2 model);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	