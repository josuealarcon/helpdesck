using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkers
    {

        #region [ Consultas ]

        public ObservableCollection<Workers> GetAllWorkersCtta(String IDEMPRESA)
        {
            try
            {
                return this.Repository.GetAllWorkersCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> BuscarFuncionarios(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String sortCOLUMN, String sortDIRECTION, string IDEMPRESA)
        {
            try
            {
                return this.Repository.BuscarFuncionarios(iDisplayStart, iDisplayLength, searchRUT, searchNOMBRES, searchAPELLIDOS, searchEMPRESA, sortCOLUMN, sortDIRECTION, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers BuscarFuncionarios_NumRegistros(String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, string IDEMPRESA)
        {
            try
            {
                return this.Repository.BuscarFuncionarios_NumRegistros(searchRUT, searchNOMBRES, searchAPELLIDOS, searchEMPRESA, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }


        public ObservableCollection<Workers> WorkersDatatablesEnterpriseCtta(string IDEMPRESA, Int32 iDisplayStart, Int32 iDisplayLength, string searchRUT, string searchNOMBRES, string searchAPELLIDOS, string sortCOLUMN, string sortDIRECTION)
        {
            try
            {
                return this.Repository.WorkersDatatablesEnterpriseCtta(IDEMPRESA, iDisplayStart, iDisplayLength, searchRUT, searchNOMBRES, searchAPELLIDOS, sortCOLUMN, sortDIRECTION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers WorkersDatatablesEnterpriseCountCtta(string IDEMPRESA, string RUT, string NOMBRES, string APELLIDOS)
        {
            try
            {
                return this.Repository.WorkersDatatablesEnterpriseCountCtta(IDEMPRESA, RUT, NOMBRES, APELLIDOS);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers BuscarDuenioMixto(string RUT, string TIPO)
        {
            try
            {
                return this.Repository.BuscarDuenioMixto(RUT, TIPO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkers_PasesCtta(string RUT, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                Workers worker = this.Repository.GetOneWorkers_PasesCtta(RUT, IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
                return worker;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneDatosPersonalesCtta(string IDEMPRESA, string RUT)
        {
            try
            {
                return this.Repository.GetOneDatosPersonalesCtta(IDEMPRESA, RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorker_ContratOSTCtta(string RUT)
        {
            try
            {
                return this.Repository.GetOneWorker_ContratOSTCtta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> WorkersDatatablesBusesReserva(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String searchOST, String searchIDEMPRESA, String sortCOLUMN, String sortDIRECTION)
        {
            try
            {
                return this.Repository.WorkersDatatablesBusesReserva(iDisplayStart, iDisplayLength, searchRUT, searchNOMBRES, searchAPELLIDOS, searchEMPRESA, searchOST, searchIDEMPRESA, sortCOLUMN, sortDIRECTION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> GetAllWorkersEnterpriseCtta(string IDEMPRESA)
        {
            try
            {
                return this.Repository.GetAllWorkersEnterpriseCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> SaveReservas_ExsicoCtta(string IDEMPRESA, string USUARIO, string LIST_RUT, string FECHARES, string HORAINICIO, string HORATERMINO, Decimal TIPO)
        {
            try
            {
                return this.Repository.SaveReservas_ExsicoCtta(IDEMPRESA, USUARIO, LIST_RUT, FECHARES, HORAINICIO, HORATERMINO, TIPO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetWorkersExisteNominaCtta(string RUT)
        {
            try
            {
                return this.Repository.GetWorkersExisteNominaCtta(RUT);
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
                ObservableCollection<Workers> workers = Repository.GetWorkersInformeConsultaRapidaCtta(Item);
                if (workers != null)
                {
                    foreach (var item in workers)
                    {
                        item.Lista_Empresas = Enterprise_Repository.GeEnterprise_InformeConsultaRapidaCtta(new Enterprise() { RUT = item.RUT });

                    }
                }
                return workers;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Workers> GetWorkers_Grid_AdminColaboradorResumen_InformeConsultaRapidaCtta(Workers Item)
        {
            try
            {
                return this.Repository.GetWorkers_Grid_AdminColaboradorResumen_InformeConsultaRapidaCtta(Item);
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
                return this.Repository.SaveWorkersPersonalesCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersLaboralesCtta(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersLaboralesCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersCovidDI(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersCovidDI(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersCovidF00(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersCovidF00(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersCovidF100(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersCovidF100(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersCovidF200(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersCovidF200(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersCovidF300(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersCovidF300(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool setWorkersDatos(string RUT, string EMPRESA, string FECHA_FINIQ, string USUARIO, string DIVCOD, Guid ARCHIVO, string OBSERVACION)
        {
            try
            {
                return this.Repository.setWorkersDatos(RUT, EMPRESA, FECHA_FINIQ, USUARIO, DIVCOD, ARCHIVO, OBSERVACION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersNewEnterpriseCTTA(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersNewEnterpriseCTTA(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDatosPersonalesCtta(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveDatosPersonalesCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean SaveWorkersCursos(ref Workers Item)
        {
            try
            {
                return this.Repository.SaveWorkersCursos(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean Save_Workers_AprobacionSubContrato( Workers Item)
        {
            try
            {
                return this.Repository.Save_Workers_AprobacionSubContrato( Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
       

        #endregion

    }
}
