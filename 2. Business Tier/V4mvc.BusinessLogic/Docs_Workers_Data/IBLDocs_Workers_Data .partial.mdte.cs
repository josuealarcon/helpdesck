using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Workers_Data 
	{
        #region [ Consultas ]
        Docs_Workers_Data GetOneDocsWorkersDataDatos_Mdte(Guid Codigo, string EMPRESA);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
