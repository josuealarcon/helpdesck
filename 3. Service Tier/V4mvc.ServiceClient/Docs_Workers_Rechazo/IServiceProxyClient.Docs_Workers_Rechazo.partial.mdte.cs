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
        ObservableCollection<Docs_Workers_Rechazo> GetListDocumentosRechazo_mdte(Guid? ID);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
