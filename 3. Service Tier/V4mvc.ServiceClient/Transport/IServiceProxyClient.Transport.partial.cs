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
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]
        ObservableCollection<Transport> GetTransportsSearcherMdte(ref Transport model);
        ObservableCollection<Transport> GetAllTransportEnterpriseCtta(string IDEMPRESA);
        ObservableCollection<Transport> BuscarVehiculos(Int32 iDisplayStart, Int32 iDisplayLength, String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB, String sortCOLUMN, String sortDIRECTION);
        Transport BuscarVehiculos_NumRegistros(String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB);
        Transport GetOneTransport_PasesCtta(string PATENTE, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN);
        ObservableCollection<Transport> GetTransportsAcreditacionVehicularCtta(string IDEMPRESA, string DIVCOD);
        ObservableCollection<Transport> GetAllTransportDatatablesCtta(ref JqueryDatatableParam model, out int iTotalCount);
        Transport GetAllTransportDatatablesCountCtta(ref JqueryDatatableParam model);
        int GetTransportCumpleCertificacion_Ctta(string PATENTE, int? TIPO,string DIVCOD);
        Transport GetDataByPatente_VehiculosCtta(string patente);

        #endregion

        #region [ Informes ]
        Transport GetTransport_DatosFichaVehiculo_InformeConsultaRapidaCtta(Transport request);
        Transport GetTransport_ValidaExistenciaPatente_InformeConsultaRapidaCtta(Transport Item);

        DataSet GetAllTransport_IAcreditacionVeh_Informes(ref Transport parametros);

        #endregion

        #region [ Metodos ]

        bool DeleteTransportCtta(string PATENTE, string IDEMPRESA);
        bool UpdateTransport_VehiculosCtta(ref Transport vehiculo);
        bool UpdateTransportEnterpriseCtta(string PATENTE, string EMPRESA);
        bool SaveTransport_VehiculosCtta(Transport vehiculo);

        #endregion

    }
}
