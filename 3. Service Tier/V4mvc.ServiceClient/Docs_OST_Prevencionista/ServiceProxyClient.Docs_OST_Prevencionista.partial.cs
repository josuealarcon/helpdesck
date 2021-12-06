
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
		public Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL, int NUM_SOLICITUD, out int SUBE_DOCUMENTO)
        {
            try
            {
                return this.BL_Docs_OST_Prevencionista.GetOneDocsOSTPrevencionista_ContratOSTCtta(NROOST, IDEMPRESA, MADRE, NIVEL, NUM_SOLICITUD, out SUBE_DOCUMENTO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD)
        {
            try
            {
                return this.BL_Docs_OST_Prevencionista.GetOneDocsOSTPrevencionista_ContratOSTCtta(NUM_SOLICITUD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool SaveDocsOSTPrevencionista_ContratOSTCtta(Archivos archivo, Docs_OST_Prevencionista prev)
        {
            try
            {
                return this.BL_Docs_OST_Prevencionista.SaveDocsOSTPrevencionista_ContratOSTCtta(archivo, prev);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD, string USUARIO)
        {
            try
            {
                return this.BL_Docs_OST_Prevencionista.DelDocsOSTPrevencionista_ContratOSTCtta(NUM_SOLICITUD, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	