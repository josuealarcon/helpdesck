using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]


        public Docs_ControlAcceso_Laboral GetOneControlAccesoLaboral_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.GetOneControlAccesoLaboral_Mdte(ID_DISPUTA, ID_DOC, ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_ControlAcceso_Laboral GetOneControlAccesoLaboralSendAlert_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID_ARCHIVO)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.GetOneControlAccesoLaboralSendAlert_Mdte(ID_DISPUTA, ID_DOC, ID_ARCHIVO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool SaveDocsDisputaControlAcceso(Docs_ControlAcceso_Laboral DocsControlAccesoLaboral)
        {
            try
            {
                return this.BL_Docs_ControlAcceso_Laboral.SaveDocsDisputaControlAcceso(DocsControlAccesoLaboral);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
