using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial class BLCasino
    {

        #region [ Consultas ]

        public ObservableCollection<Casino> GetListCasino()
        {
            try
            {
                return this.Repository.GetListCasino();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoFechasCtta(string FECHAINI, string FECHAFIN)
        {
            try
            {
                return this.Repository.GetCasinoFechasCtta(FECHAINI, FECHAFIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllCasinoServicioFecha(ref Casino model)
        {
            try
            {
                return this.Repository.GetAllCasinoServicioFecha(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetAllCasinoServicioEmpresa(ref Casino model)
        {
            try
            {
                return this.Repository.GetAllCasinoServicioEmpresa(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioLocalCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoServicioLocalCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioLocalFechaCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoServicioLocalFechaCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoLocalesCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoLocalesCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoSubtotalCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoSubtotalCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoTotalCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoTotalCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoDetalleCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoDetalleCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoServicioCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetCasinoServicioDiaCtta(ref Casino model)
        {
            try
            {
                return this.Repository.GetCasinoServicioDiaCtta(ref model);
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
                return this.Repository.GetCasino_Grid_Consumo_Casino_MesActual_InformeFuncionariosCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region [ Métodos ]

        #endregion

    }
}
