using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using System.Data;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<Casino> GetListCasino()
        {
            try
            {
                return this.BL_Casino.GetListCasino();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoFechasCtta(string FECHAINI, string FECHAFIN)
        {
            try
            {
                return this.BL_Casino.GetCasinoFechasCtta(FECHAINI, FECHAFIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllCasinoServicioFecha(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetAllCasinoServicioFecha(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetAllCasinoServicioEmpresa(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetAllCasinoServicioEmpresa(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioLocalCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoServicioLocalCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioLocalFechaCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoServicioLocalFechaCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoLocalesCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoLocalesCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoSubtotalCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoSubtotalCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoTotalCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoTotalCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoDetalleCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoDetalleCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoServicioCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioDiaCtta(ref Casino model)
        {
            try
            {
                return this.BL_Casino.GetCasinoServicioDiaCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
        #region [ Informes ]
        public ObservableCollection<Casino> GetCasino_Grid_Consumo_Casino_MesActual_InformeFuncionariosCtta(Casino request)
        {
            try
            {
                return this.BL_Casino.GetCasino_Grid_Consumo_Casino_MesActual_InformeFuncionariosCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region [ Métodos ]

        #endregion

    }
}
