using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Fec
	{

        #region [ Consultas ]
        ObservableCollection<Docs_Fec> GetDocumentacionFechasDocumentoMdte(ref Docs modelo);

        ObservableCollection<Docs_Fec> GetDocumentacionFechasDocumentoVehiculosMdte(ref Docs modelo);
        ObservableCollection<Docs_Fec> GetAllDocsFec_CertificacionDocsMdte(ref Docs modelo);
        ObservableCollection<Docs_Fec> GetCertificadosPasesFechas_Mdte(string RUT, string DIV_COD, int ID_DOC);

        ObservableCollection<Docs_Fec> GetListDocsFecFechaNombre_Mdte(int ID_DOC, string PATENTE, string EMPRESA, string DIVCOD);
        ObservableCollection<Docs_Fec> GetListFechasDocumentos_Mdte();
        ObservableCollection<Docs_Fec> GetAllDocsFecSelect_mdte();

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
