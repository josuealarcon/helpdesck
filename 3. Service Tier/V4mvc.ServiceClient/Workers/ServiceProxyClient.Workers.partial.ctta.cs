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

        public ObservableCollection<Workers> GetAllWorkersCtta(String IDEMPRESA)
        {
            try
            {
                return this.BL_Workers.GetAllWorkersCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> BuscarFuncionarios(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String sortCOLUMN, String sortDIRECTION, string IDEMPRESA)
        {
            try
            {
                return this.BL_Workers.BuscarFuncionarios(iDisplayStart, iDisplayLength, searchRUT, searchNOMBRES, searchAPELLIDOS, searchEMPRESA, sortCOLUMN, sortDIRECTION, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers BuscarFuncionarios_NumRegistros(String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, string IDEMPRESA)
        {
            try
            {
                return this.BL_Workers.BuscarFuncionarios_NumRegistros(searchRUT, searchNOMBRES, searchAPELLIDOS, searchEMPRESA, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }


        public ObservableCollection<Workers> WorkersDatatablesEnterpriseCtta(string IDEMPRESA, Int32 iDisplayStart, Int32 iDisplayLength, string searchRUT, string searchNOMBRES, string searchAPELLIDOS, string sortCOLUMN, String sortDIRECTION)
        {
            try
            {
                return this.BL_Workers.WorkersDatatablesEnterpriseCtta(IDEMPRESA, iDisplayStart, iDisplayLength, searchRUT, searchNOMBRES, searchAPELLIDOS, sortCOLUMN, sortDIRECTION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers WorkersDatatablesEnterpriseCountCtta(string IDEMPRESA, string RUT, string NOMBRES, string APELLIDOS)
        {
            try
            {
                return this.BL_Workers.WorkersDatatablesEnterpriseCountCtta(IDEMPRESA, RUT, NOMBRES, APELLIDOS);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers BuscarDuenioMixto(string RUT, string TIPO)
        {
            try
            {
                return this.BL_Workers.BuscarDuenioMixto(RUT, TIPO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkers_PasesCtta(string RUT, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                return this.BL_Workers.GetOneWorkers_PasesCtta(RUT, IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorker_ContratOSTCtta(string RUT)
        {
            try
            {
                return this.BL_Workers.GetOneWorker_ContratOSTCtta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneDatosPersonalesCtta(string IDEMPRESA, string RUT)
        {
            try
            {
                return this.BL_Workers.GetOneDatosPersonalesCtta(IDEMPRESA, RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> GetWorkersDatatablesBusesReserva(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String searchOST, String searchIDEMPRESA, String sortCOLUMN, String sortDIRECTION)
        {
            try
            {
                return this.BL_Workers.WorkersDatatablesBusesReserva(iDisplayStart, iDisplayLength, searchRUT, searchNOMBRES, searchAPELLIDOS, searchEMPRESA, searchOST, searchIDEMPRESA, sortCOLUMN, sortDIRECTION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> GetAllWorkersEnterpriseCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Workers.GetAllWorkersEnterpriseCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> SaveReservas_ExsicoCtta(string IDEMPRESA, string USUARIO, string LIST_RUT, string FECHARES, string HORAINICIO, string HORATERMINO, Decimal TIPO)
        {
            try
            {
                return this.BL_Workers.SaveReservas_ExsicoCtta(IDEMPRESA, USUARIO, LIST_RUT, FECHARES, HORAINICIO, HORATERMINO, TIPO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetWorkersExisteNominaCtta(string RUT)
        {
            try
            {
                return this.BL_Workers.GetWorkersExisteNominaCtta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Informes ]
        public ObservableCollection<Workers> GetWorkersInformeConsultaRapidaCtta(Workers Item)
        {
            try
            {
                return this.BL_Workers.GetWorkersInformeConsultaRapidaCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Workers> GetWorkers_Grid_AdminColaboradorResumen_InformeConsultaRapidaCtta(Workers Item)
        {
            try
            {
                return this.BL_Workers.GetWorkers_Grid_AdminColaboradorResumen_InformeConsultaRapidaCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public Boolean SaveWorkersPersonalesCtta(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersPersonalesCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersLaboralesCtta(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersLaboralesCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorker(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersLaboralesCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }


        public bool SaveWorkersCovidDI(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersCovidDI(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCovidF00(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersCovidF00(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCovidF100(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersCovidF100(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCovidF200(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersCovidF200(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersCovidF300(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersCovidF300(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersNewEnterpriseCTTA(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersNewEnterpriseCTTA(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDatosPersonalesCtta(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveDatosPersonalesCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCursos(ref Workers Item)
        {
            try
            {
                return this.BL_Workers.SaveWorkersCursos(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Save_Workers_AprobacionSubContrato( Workers Item)
        {
            try
            {
                return this.BL_Workers.Save_Workers_AprobacionSubContrato( Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
