
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs_OST_Prevencionista
    {
        #region [ Consultas ]
        Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL, int NUM_SOLICITUD, out int SUBE_DOCUMENTO);
        Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD);
        #endregion

        #region [ Metodos ]
        bool SaveDocsOSTPrevencionista_ContratOSTCtta(Docs_OST_Prevencionista prev);

        bool DelDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD, string USUARIO);
        #endregion
    }
}
	