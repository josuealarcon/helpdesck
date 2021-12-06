using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions; 

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Disputa_Trans
	{

		#region [ Consultas ]
        #endregion

        #region [ Metodos ]
        public bool SaveDocDisputaTransVehiculo(Docs_Disputa docs_disputa)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    if (docs_disputa.VALIDADO == "RE")
                    {
                        RepositoryDocsRechazoVeh.DeleteDocsTransportRechazoVehiculo_Mdte(docs_disputa.ID);
                        foreach (var item in docs_disputa.ListDocsTipoRechazo)
                        {
                            item.RUT = docs_disputa.RUT;
                            item.ID = docs_disputa.ID;
                            item.ID_DOC = docs_disputa.ID_DOC;
                            item.USUARIO = docs_disputa.USUARIO;
                            RepositoryDocsRechazoVeh.InsertDocsTransportRechazoVehiculo_Mdte(item);

                        }
                    }
                    Repository.SaveDocDisputaTransVehiculo(docs_disputa);
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
