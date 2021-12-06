using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<LotePases> GetAllLotePases_PasesCtta(string IDEMPRESA, bool ACTUAL)
        {
            try
            {
                return this.BL_LotePases.GetAllLotePases_PasesCtta(IDEMPRESA, ACTUAL);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<LotePases> GetLugaresVisita() {
            try
            {
                return this.BL_LotePases.GetLugaresVisita();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LotePases GetOneLotePases_PasesCtta(int LOTENUM)
        {
            try
            {
                return this.BL_LotePases.GetOneLotePases_PasesCtta(LOTENUM);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool SendPase_PasesCtta(ref LotePases modelo)
        {
            try
            {
                return this.BL_LotePases.SendPase_PasesCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveLotePases_PasesCtta(string INS_OST, string INS_EMP, string INS_DIVCOD, string INS_FINICIO, string INS_FFINAL, string INS_TPASE, string INS_DESCRIP, string IDEMPRESA, string USUARIO, out int new_id)
        {
            try
            {
                return this.BL_LotePases.SaveLotePases_PasesCtta(INS_OST, INS_EMP, INS_DIVCOD, INS_FINICIO, INS_FFINAL, INS_TPASE, INS_DESCRIP, IDEMPRESA, USUARIO, out new_id);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveLotePases_PaseVisitaCtta(LotePases pase, out int NEW_ID)
        {
            try
            {
                return this.BL_LotePases.SaveLotePases_PaseVisitaCtta(pase, out NEW_ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool SendPaseModelo_PasesCtta(ref LotePases modelo)
        {
            try
            {
                return this.BL_LotePases.SendPaseModelo_PasesCtta(ref modelo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
