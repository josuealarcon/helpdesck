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
        ObservableCollection<Docs_Fec> GetDocumentacionFechasDocumentoCtta(int ID_DOC, string DIVCOD,string RUT,string IDEMPRESA);
        ObservableCollection<Docs_Fec> GetDocsFecVehiculosCtta(int ID_DOC, string DIVCOD, string PATENTE, string IDEMPRESA);
        ObservableCollection<Docs_Fec> GetFechasFiniquito_FuncionariosCtta(string RUT, string EMPRESA);
        ObservableCollection<Docs_Fec> GetAllFechasDocsEmpresasCtta(string IDEMPRESA, int ID_DOC);

        Nullable<DateTime> GetNowAsDateTime();

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
