using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]
        ObservableCollection<Workers> GetWorkersSearcherMdte(ref Workers model);
        ObservableCollection<Workers> GetAllWorkersCtta(String IDEMPRESA);
        ObservableCollection<Workers> BuscarFuncionarios(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String sortCOLUMN, String sortDIRECTION,string IDEMPRESA);
        Workers BuscarFuncionarios_NumRegistros(String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, string IDEMPRESA);

        ObservableCollection<Workers> BuscarFuncionariosPases(ref Workers worker);
        ObservableCollection<Workers> BuscarFuncionariosPasesSolicita_Visita(ref Workers worker);
        ObservableCollection<Workers> BuscarFuncionariosPasesAutorizador(ref Workers worker);
        Workers BuscarFuncionariosPases_NumRegistros(String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, string IDEMPRESA);

        ObservableCollection<Workers> WorkersDatatablesEnterpriseCtta(string IDEMPRESA, Int32 iDisplayStart, Int32 iDisplayLength, string searchRUT, string searchNOMBRES, string searchAPELLIDOS, string sortCOLUMN, string sortDIRECTION);
        Workers WorkersDatatablesEnterpriseCountCtta(string IDEMPRESA, string RUT, string NOMBRES, string APELLIDOS);

        Workers BuscarDuenioMixto(string RUT, string TIPO);


        Workers GetOneWorkers_PasesCtta(string RUT, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE);


        Workers GetOneDatosPersonalesCtta(string IDEMPRESA, string RUT);


        Workers GetOneWorker_ContratOSTCtta(string RUT);

        ObservableCollection<Workers> GetWorkersDatatablesBusesReserva(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String searchOST, String searchIDEMPRESA,String sortCOLUMN, String sortDIRECTION);

        ObservableCollection<Workers> GetAllWorkersEnterpriseCtta(string IDEMPRESA);
        ObservableCollection<Workers> SaveReservas_ExsicoCtta(string IDEMPRESA, string USUARIO, string LIST_RUT, string FECHARES, string HORAINICIO, string HORATERMINO, Decimal TIPO);
        Workers GetWorkersExisteNominaCtta(string RUT);

        #endregion

        #region [ Informes ]
        ObservableCollection<Workers> GetWorkersInformeConsultaRapidaCtta(Workers Item);
        ObservableCollection<Workers> GetWorkers_Grid_AdminColaboradorResumen_InformeConsultaRapidaCtta(Workers Item);
        #endregion

        #region [ Metodos ]

        Boolean SaveWorkersPersonalesCtta(ref Workers Item);
        bool SaveWorkersLaboralesCtta(ref Workers Item);
        bool SaveWorkersCovidDI(ref Workers Item);
        bool SaveWorkersCovidF00(ref Workers Item);
        bool SaveWorkersCovidF100(ref Workers Item);
        bool SaveWorkersCovidF200(ref Workers Item);
        bool SaveWorkersCovidF300(ref Workers Item);

        bool SaveWorkersNewEnterpriseCTTA(ref Workers Item);
        bool SaveDatosPersonalesCtta(ref Workers Item);
        bool SaveWorkersCursos(ref Workers Item);
        bool Save_Workers_AprobacionSubContrato( Workers Item);
        bool SaveWorkersAutorizacionesFuncionariosCtta(Workers workers);

        #endregion

        }
}
