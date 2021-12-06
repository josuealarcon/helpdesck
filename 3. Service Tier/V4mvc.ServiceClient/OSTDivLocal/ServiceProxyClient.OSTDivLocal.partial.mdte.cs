using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_Mdte(string NROOST, string MANDANTE, string EMPRESA)
        {
            try
            {
                return this.BL_OSTDivLocal.GetAllOSTDivLocal_Mdte(NROOST, MANDANTE, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveOstDivLocalOST_Mdte(ref OSTDivLocal Item)
        {
            try
            {
                return this.BL_OSTDivLocal.SaveOstDivLocalOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveOstDivLocalOST_Mdte(ObservableCollection<OSTDivLocal> Items)
        {
            try
            {
                return this.BL_OSTDivLocal.SaveOstDivLocalOST_Mdte(Items);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
