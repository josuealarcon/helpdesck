using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs_Fec_Workers
    {

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        bool SaveFechasWorkersLocal_Mdte(string RUT, int ID_DOC_FEC, string DIV, string EMPRESA, string FECHA, string USUARIO);

        bool SaveFechasDocs_Fec_Workers_Mdte(ref Docs_Fec_Workers docs_Fec_Workers);

        #endregion


    }
}