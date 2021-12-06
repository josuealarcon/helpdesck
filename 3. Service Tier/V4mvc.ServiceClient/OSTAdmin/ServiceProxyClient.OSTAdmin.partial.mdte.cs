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

		public ObservableCollection<OSTAdmin> GetListOstAdmins_Mdte(string NROOST, string IDEMPRESA)
		{
			try
			{
				return this.BL_OSTAdmin.GetListOstAdmins_Mdte(NROOST,IDEMPRESA);
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
                return this.BL_OSTAdmin.SaveOstAdminOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveOstAdminOST_Mdte(ObservableCollection<OSTAdmin> Items)
        {
            try
            {
                return this.BL_OSTAdmin.SaveOstAdminOST_Mdte(Items);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
