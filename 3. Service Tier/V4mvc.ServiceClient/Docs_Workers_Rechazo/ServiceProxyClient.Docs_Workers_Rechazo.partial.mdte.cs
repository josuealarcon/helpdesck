using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]
        public ObservableCollection<Docs_Workers_Rechazo> GetListDocumentosRechazo_mdte(Guid? ID) {
            try
            {
                return this.BL_Docs_Workers_Rechazo.GetListDocumentosRechazo_mdte(ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region [ Metodos ]


        #endregion

    }
}
