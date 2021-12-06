using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;


using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_Disputa
    {

      
        #region [ Consultas ]
        public ObservableCollection<Docs_Disputa> GetListDocsDisputa_Mdte(ref Docs_Disputa item)
        {
            try
            {
                return this.Repository.GetListDocsDisputa_Mdte(ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs_Disputa GetOneDocsDisputaFuncionario_Mdte(string IDDISPUTA)
        {
            try
            {
                return this.Repository.GetOneDocsDisputaFuncionario_Mdte(IDDISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_Disputa GetOneDocsDisputaVehiculo_Mdte(string IDDISPUTA, string PATENTE)
        {
            try
            {
                return this.Repository.GetOneDocsDisputaVehiculo_Mdte(IDDISPUTA, PATENTE);
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion

        #region [ Metodos ] 
        public bool SaveDocDisputaFuncionario(Docs_Disputa docs_Disputa)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    if (docs_Disputa.VALIDADO == "RE")
                    {
                        RepositoryDocsTipoRechazo.DeleteDocsWorkersRechazoFuncionario_Mdte(docs_Disputa.ID);
                        foreach (var item in docs_Disputa.ListDocsTipoRechazo)
                        {
                            item.RUT = docs_Disputa.RUT;
                            item.ID = docs_Disputa.ID;
                            item.USUARIO = docs_Disputa.USUARIO;
                            item.ID_DOC = docs_Disputa.ID_DOC;
                            RepositoryDocsTipoRechazo.InsertDocsWorkersRechazoFuncionario_Mdte(item);
                        }
                    }

                    Repository.SaveDocDisputaFuncionario(docs_Disputa);
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
