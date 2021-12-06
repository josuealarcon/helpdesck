using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]
        Docs_Workers_Data GetOneDocsWorkersDataDatos_Mdte(Guid ID_DOC, string EMPRESA);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
