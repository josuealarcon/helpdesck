using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Workers_Data
	{

        #region [ Consultas ]

        Docs_Workers_Data GetDocWorkersDataDisputa(string ID);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
