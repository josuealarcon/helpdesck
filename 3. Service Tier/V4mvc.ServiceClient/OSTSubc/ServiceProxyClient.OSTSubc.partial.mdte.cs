using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
      
        public ObservableCollection<OSTSubc> GetListContratOST_Mdte(ref OSTSubc model)
        {
            try
            {
                return this.BL_OSTSubc.GetListContratOST_Mdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public OSTSubc GetOST_Empresa_Mdte(ref OSTSubc model)
        {
            try
            {
                return this.BL_OSTSubc.GetOST_Empresa_Mdte(ref model);
            }
            catch (Exception ex)
            {  throw ex;   }
        }

        public OSTSubc GetOstSubcOST_Mdte(string OST, string EMPRESA, Int16 NIVEL)
        {
            try
            {
                return this.BL_OSTSubc.GetOstSubcOST_Mdte(OST, EMPRESA, NIVEL);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveOST_Mdte(OSTSubc item)
        {
            try
            {
                return this.BL_OSTSubc.SaveOST_Mdte(item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveOSTEmpresa_Mdte(OSTSubc item)
        {
            try
            {
                return this.BL_OSTSubc.SaveOSTEmpresa_Mdte(item);
            }
            catch (Exception ex)
            { throw ex; }
        }
     
        #endregion

    }
}
