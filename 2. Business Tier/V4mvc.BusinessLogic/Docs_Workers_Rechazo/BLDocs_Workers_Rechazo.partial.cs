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
        
        public ObservableCollection<Docs_Workers_Rechazo> GetAllMotivosRechazo(Guid ID, string DIVISION)
        {
            try
            {
                return this.Repository.GetAllMotivosRechazo(ID, DIVISION);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
