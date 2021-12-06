using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_ControlAcceso_Laboral
	{

        #region [ Consultas ]

        public Docs_ControlAcceso_Laboral GetOneControlAccesoLaboral_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID)
        {
            try
            {
                return this.Repository.GetOneControlAccesoLaboral_Mdte(ID_DISPUTA, ID_DOC, ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_ControlAcceso_Laboral GetOneControlAccesoLaboralSendAlert_Mdte(int ID_DISPUTA, int ID_DOC, Guid ID_ARCHIVO)
        {
            try
            {
                return this.Repository.GetOneControlAccesoLaboralSendAlert_Mdte(ID_DISPUTA, ID_DOC, ID_ARCHIVO);
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
                
                using (TransactionScope tran = new TransactionScope())
                {
                    if (DocsControlAccesoLaboral.VALIDADO == "RE")
                    {
                        RepositoryDocs_Workers_Rechazo.DeleteDocsWorkersRechazoControlAcceso_Mdte(DocsControlAccesoLaboral.ID_ARCHIVO);
                        foreach (var item in DocsControlAccesoLaboral.ListDocsTipoRechazo)
                        {
                            item.RUT = DocsControlAccesoLaboral.RUT;
                            item.ID_DOC = DocsControlAccesoLaboral.ID_DOC;
                            item.USUARIO = DocsControlAccesoLaboral.USUARIO;
                            item.ID = DocsControlAccesoLaboral.ID_ARCHIVO.GetValueOrDefault();
                            RepositoryDocs_Workers_Rechazo.InsertDocsWorkersRechazoControlAcceso_Mdte(item);
                        }
                    }
                    Repository.SaveDocsDisputaControlAcceso(DocsControlAccesoLaboral);
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
      
        #endregion

    }
}
