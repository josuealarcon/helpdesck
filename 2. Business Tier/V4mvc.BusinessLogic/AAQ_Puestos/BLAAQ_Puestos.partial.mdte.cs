using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLAAQ_Puestos
	{
        #region [ Consultas ]
 
        #endregion

        #region [ Metodos ]
        public bool SaveUpdatePuestos_Mdte(ref AAQ_Puestos item)
        {
            try
            {
                return this.Repository.SaveUpdatePuestos_Mdte(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
