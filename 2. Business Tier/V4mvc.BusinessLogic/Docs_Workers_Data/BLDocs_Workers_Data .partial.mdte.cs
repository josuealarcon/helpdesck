using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Workers_Data 
	{
        #region [ Consultas ]
        public Docs_Workers_Data GetOneDocsWorkersDataDatos_Mdte(Guid ID_DOC, string EMPRESA)
        {
            try
            {
                return this.Repository.GetOneDocsWorkersDataDatos_Mdte(ID_DOC, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
