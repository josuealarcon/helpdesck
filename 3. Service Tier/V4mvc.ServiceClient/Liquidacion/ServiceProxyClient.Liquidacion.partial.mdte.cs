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
        public ObservableCollection<Liquidacion> GetListLiquidacion_Mdte(ref Liquidacion liquidacionvalid)
        {
            try
            {
                return this.BL_Liquidacion.GetListLiquidacion_Mdte(ref liquidacionvalid);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Liquidacion GetOneLiquidacionValidada_Mdte(string RUT, string FECHA, string EMPRESA) {
            try
            {
                return this.BL_Liquidacion.GetOneLiquidacionValidada_Mdte(RUT, FECHA, EMPRESA);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Liquidacion GetOneLiquidacionDisputa_Mdte(int ID_DISPUTA)
        {
            try
            {
                return this.BL_Liquidacion.GetOneLiquidacionDisputa_Mdte(ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDocsDisputaLiquidacion(Liquidacion Liquidacion)
        {
            try
            {
                return this.BL_Liquidacion.SaveDocsDisputaLiquidacion(Liquidacion);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Liquidacion GetOneLiquidacionDisputaSendAlert_Mdte(int ID_DISPUTA)
        {
            try
            {
                return this.BL_Liquidacion.GetOneLiquidacionDisputaSendAlert_Mdte(ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveLiquidacionValidada_Mdte(ref Liquidacion items) {
            try
            {
                return this.BL_Liquidacion.SaveLiquidacionValidada_Mdte(ref items);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool SaveLiquidacionRechazada_Mdte(ref Liquidacion items) {
            try
            {
                return this.BL_Liquidacion.SaveLiquidacionRechazada_Mdte (ref items);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
