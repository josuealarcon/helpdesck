using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Workers_Rechazo
	{

        #region [ Consultas ]
        public ObservableCollection<Docs_Workers_Rechazo> GetListDocumentosRechazo_mdte(Guid? ID) {
            try
            {
                return this.Repository.GetListDocumentosRechazo_mdte(ID);
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
