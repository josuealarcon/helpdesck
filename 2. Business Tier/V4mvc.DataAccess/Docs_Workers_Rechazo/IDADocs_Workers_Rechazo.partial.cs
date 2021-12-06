using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Workers_Rechazo
	{

        #region [ Consultas ]
        ObservableCollection<Docs_Workers_Rechazo> GetAllMotivosRechazo(Guid ID, string DIVISION);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
