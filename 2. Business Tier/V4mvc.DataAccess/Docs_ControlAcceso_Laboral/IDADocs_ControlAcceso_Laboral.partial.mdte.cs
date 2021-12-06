using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_ControlAcceso_Laboral
	{

        #region [ Consultas ]
        Docs_ControlAcceso_Laboral GetOneControlAccesoLaboral_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID);
        Docs_ControlAcceso_Laboral GetOneControlAccesoLaboralSendAlert_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID_ARCHIVO);
        #endregion

        #region [ Metodos ]
        bool SaveDocsDisputaControlAcceso(Docs_ControlAcceso_Laboral item);
        #endregion
    }
}
