using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLOSTAdmin
    {
        #region [ Consultas ]

        public ObservableCollection<OSTAdmin> GetListOstAdmins_Mdte(string NROOST, string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetListOstAdmins_Mdte(NROOST, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveOstAdminOST_Mdte(ref OSTAdmin Item)
        {
            try
            {
                return this.Repository.SaveOstAdminOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveOstAdminOST_Mdte(ObservableCollection<OSTAdmin> Items)
        {
            try
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    this.Repository.SaveOstAdminOST_Mdte(ref item);
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
