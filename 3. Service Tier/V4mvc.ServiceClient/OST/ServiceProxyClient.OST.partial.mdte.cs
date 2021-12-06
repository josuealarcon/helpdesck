using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public OST GetOneOST_Mdte(string NROOST)
        {
            try
            {
                return this.BL_OST.GetOneOST_Mdte(NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidateOST(string NROOST)
        {
            try
            {
                return this.BL_OST.ValidateOST(NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool GetStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE)
        {
            try
            {
                return this.BL_OST.GetStatusOst_Mdte(NROOST, IDEMPRESA, MADRE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool UpdateStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE)
        {
            try
            {
                return this.BL_OST.UpdateStatusOst_Mdte(NROOST,IDEMPRESA, MADRE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveContratoOST_Mdte(ref OST model)
        {
            try
            {
                return this.BL_OST.SaveContratoOST_Mdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
