using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCTRLing
    {

        #region [ Consultas ]
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen(CTRLing Item)
        {
            try
            {
                var response = Repository.Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen(Item);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.FECHA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.Guion);
                        item.DIVCOD = Item.DIVCOD;
                        item.LOCAL = Item.LOCAL;
                    }
                }
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diatotal(CTRLing Item)
        {
            try
            {
                var response = Repository.Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diatotal(Item);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.FECHA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.GuionMesLetras);
                    }
                }
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }
        
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_CensoAccesos(CTRLing Item)
        {
            try
            {
                var response = Repository.Get_WC3_Vista_Ctrling_Informe_CensoAccesos(Item);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.FECHA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.GuionMesLetras);
                        item.DIVCOD = Item.DIVCOD;
                        item.LOCAL = Item.LOCAL;
                    }
                }
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataSet Get_WC3_Vista_Ctrling_Informe_CensoAccesos_Detalle(CTRLing Item)
        {
            try
            {
                return Repository.Get_WC3_Vista_Ctrling_Informe_CensoAccesos_Detalle(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }
        
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_AccesosZonasControladas(CTRLing Item)
        {
            try
            {
                var response = Repository.Get_WC3_Vista_Ctrling_Informe_AccesosZonasControladas(Item);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.FECHA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.Guion);
                        item.DIVCOD = Item.DIVCOD;
                        item.LOCAL = Item.LOCAL;
                    }
                }
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diatotal(CTRLing Item)
        {
            try
            {
                var response = Repository.Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diatotal(Item);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.FECHA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.GuionMesLetras);
                    }
                }
                return response;

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
                return Repository.GetCTRLing_Grid_Movimiento_IngSal_MesActual_InformeFuncionariosCtta(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diaresumen(CTRLing Item)
        {
            try
            {
                return Repository.Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diaresumen(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diaresumen(CTRLing Item)
        {
            try
            {
                return Repository.Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diaresumen(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> GetCTRLing_Grid_Movimiento_IngSal_MesActual_Detalle_InformeFuncionariosCtta(CTRLing Item)
        {
            try
            {
                return Repository.GetCTRLing_Grid_Movimiento_IngSal_MesActual_Detalle_InformeFuncionariosCtta(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }
        
        #endregion
    }
}
