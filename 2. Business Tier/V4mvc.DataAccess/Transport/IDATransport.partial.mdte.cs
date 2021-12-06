using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDATransport
    {

        #region [ Consultas ]
        ObservableCollection<Transport> GetTransportsSearcherMdte(ref Transport model);
        Transport GetOneTransport_PasesMdte(Docs modelo);
        Transport GetOneTransportExtra_PasesMdte(Transport modelo);
        ObservableCollection<Transport> GetListTransports_Mdte(ref Transport transports);
        Transport GetOneTransport_CertificacionMdte(string PATENTE);


        Transport GetOneTransport_v2_CertificacionMdte(string PATENTE);

        Transport GetOneTransport_Acreditacion_CertificacionMdte(string DIVCOD, string PATENTE, string TIPO_VEHICULO, string IDEMPRESA);


        Transport GetOneTransport_Mdte(string PATENTE, string DIVCOD);
        bool ValidarTransportRFID_Mdte(string RFID, string PATENTE);
        Transport GetOneTransportCertificacion_Mdte(string DIVCOD, string PATENTE, string TIPO_VEHICULO, string IDEMPRESA);

        #endregion

        #region [ Metodos ]
        bool DeleteTransport_Mdte(string PATENTE, int TIPO, string IDEMPRESA, string USUARIO);
        bool UpdateTransport_Mdte(ref Transport Transport);
        bool SaveTransport_Mdte(ref Transport Transport);

        bool SaveTransport_CertificacionMdte(ref Transport modelo);

        #endregion
    }
}