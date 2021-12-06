using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Transport
	{

        #region [ Consultas ]

        Docs_Transport GetDocsTransportDocumentoValidado(string DIVCOD, string PATENTE, int ID_DOC, string COMUN_DIV, int? COMUN, string IDEMPRESA);
        ObservableCollection<Docs_Transport> GetDocsHistoricoVehiculosCtta(int ID_DOC, string PATENTE, string DIVCOD);
        Docs_Transport GetDocTransportsDisputa(string ID, string DIVCOD, int ID_DISPUTA);

        bool DocsTransport_Insert_HistoricoVehiculosCtta(Docs_Transport item);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
