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

        ObservableCollection<Docs_Transport> GetListDocsTransport_Mdte(string PATENTE, int ID_DOC, Guid ID, int ID_DISPUTA);
        ObservableCollection<Docs_Transport> GetListDocTransportsArchivosAlmacenados_Mdte(string PATENTE, string DIVCOD, int ID_DOC, string EMPRESA);

        #endregion

        #region [ Metodos ]
        bool saveDocsTransport_Mdte(ref Docs Docs);
        #endregion
    }
}
