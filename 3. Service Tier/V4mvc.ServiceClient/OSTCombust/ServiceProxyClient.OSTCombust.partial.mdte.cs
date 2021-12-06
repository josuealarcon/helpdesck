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

        public ObservableCollection<OSTCombust> GetAllOSTCombust_Mdte(string NROOST, string IDEMPRESA)
        {
            try
            {
                return this.BL_OSTCombust.GetAllOSTCombust_Mdte(NROOST, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool DeleteOstCombustOST_Mdte(ref OST Item)
        {
            try
            {
                return this.BL_OSTCombust.DeleteOstCombustOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveOstCombustOST_Mdte(ref OSTCombust Item)
        {
            try
            {
                return this.BL_OSTCombust.SaveOstCombustOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveOstCombustOST_Mdte(ObservableCollection<OSTCombust> Items)
        {
            try
            {
                return this.BL_OSTCombust.SaveOstCombustOST_Mdte(Items);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
