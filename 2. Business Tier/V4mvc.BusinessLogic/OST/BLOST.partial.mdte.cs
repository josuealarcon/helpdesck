using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLOST
    {

        #region [ Consultas ]

        public OST GetOneOST_Mdte(string NROOST)
        {
            try
            {
                return this.Repository.GetOneOST_Mdte(NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidateOST(string NROOST)
        {
            try
            {
                return this.Repository.ValidateOST(NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool GetStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE)
        {
            try
            {
                return this.Repository.GetStatusOst_Mdte(NROOST, IDEMPRESA, MADRE);
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
                return this.Repository.UpdateStatusOst_Mdte(NROOST, IDEMPRESA, MADRE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveContratoOST_Mdte(ref OST model)
        {
            try
            {
                model.FECINICIO = Utils.Fec_User(model.FECINICIO, Utils.Formato_Fecha.BaseDatos);
                model.FECTERM = Utils.Fec_User(model.FECTERM, Utils.Formato_Fecha.BaseDatos);
                model.FECCIERRE = Utils.Fec_User(model.FECCIERRE, Utils.Formato_Fecha.BaseDatos);
                model.FECHAESEFORMAT = Utils.Fec_User(model.FECHAESEFORMAT, Utils.Formato_Fecha.BaseDatos);
                model.HORAESEFORMAT = model.HORAESEFORMAT ?? "00:00:00";
                return this.Repository.SaveContratoOST_Mdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
