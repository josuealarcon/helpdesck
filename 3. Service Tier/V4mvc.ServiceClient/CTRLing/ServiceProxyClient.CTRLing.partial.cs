using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diatotal(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diatotal(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_CensoAccesos(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_Informe_CensoAccesos(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataSet Get_WC3_Vista_Ctrling_Informe_CensoAccesos_Detalle(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_Informe_CensoAccesos_Detalle(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_AccesosZonasControladas(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_Informe_AccesosZonasControladas(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diatotal(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diatotal(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region [ Informes ]
        public ObservableCollection<CTRLing> GetCTRLing_Grid_Movimiento_IngSal_MesActual_InformeFuncionariosCtta(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.GetCTRLing_Grid_Movimiento_IngSal_MesActual_InformeFuncionariosCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diaresumen(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diaresumen(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diaresumen(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diaresumen(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> GetCTRLing_Grid_Movimiento_IngSal_MesActual_Detalle_InformeFuncionariosCtta(CTRLing Item)
        {
            try
            {
                return this.BL_CTRLing.GetCTRLing_Grid_Movimiento_IngSal_MesActual_Detalle_InformeFuncionariosCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        #endregion
        #region [ Metodos ]
        #endregion

    }
}
