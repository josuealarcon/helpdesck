
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_OST_Prevencionista
    {
        #region [ Consultas ]
        public Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL, int NUM_SOLICITUD, out int SUBE_DOCUMENTO)
		{
			try
			{
				return this.Repository.GetOneDocsOSTPrevencionista_ContratOSTCtta(NROOST, IDEMPRESA, MADRE, NIVEL, NUM_SOLICITUD, out SUBE_DOCUMENTO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD)
		{
			try
			{
				return this.Repository.GetOneDocsOSTPrevencionista_ContratOSTCtta(NUM_SOLICITUD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]
		public bool SaveDocsOSTPrevencionista_ContratOSTCtta(Archivos archivo, Docs_OST_Prevencionista prev)
		{
			bool ok = false;
			try
			{
                using (TransactionScope tran = new TransactionScope())
                {
                    if (archivo.ARCHIVO != null)
                    {
                        this.RepositoryArchivos.Save(ref archivo);
                        prev.ID_ARCHIVO = archivo.ID;

						ok = this.Repository.SaveDocsOSTPrevencionista_ContratOSTCtta(prev);

					}
                    tran.Complete();
                }
                return ok;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DelDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD, string USUARIO)
		{
			try
			{
				return this.Repository.DelDocsOSTPrevencionista_ContratOSTCtta(NUM_SOLICITUD, USUARIO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
	