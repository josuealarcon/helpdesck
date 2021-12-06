using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Disputa
	{

        #region [ Consultas ]

        public ObservableCollection<Docs_Disputa> GetInformeDocsPendientesDisputaCtta(ref Docs_Disputa model)
        {
            try
            {
                return Repository.GetInformeDocsPendientesDisputaCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveDisputa(ref Docs_Disputa Item)
        {
            try
            {
                return this.Repository.SaveDisputa(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
