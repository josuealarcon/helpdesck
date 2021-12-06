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
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]
        public Docs_Workers_Data GetOneDocsWorkersDataDatos_Mdte(Guid ID_DOC, string EMPRESA)
        {
            try
            {
                return this.BL_Docs_Workers_Data.GetOneDocsWorkersDataDatos_Mdte(ID_DOC, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
