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
	public partial class BLLiquidacion
    {

        #region [ Consultas ]

        public Liquidacion GetOneLiquidacionValidada_Mdte(string RUT, string FECHA, string EMPRESA) {
            try
            {
                return this.Repository.GetOneLiquidacionValidada_Mdte(RUT, FECHA, EMPRESA);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Liquidacion GetOneLiquidacionDisputa_Mdte(int ID_DISPUTA)
        {
            try
            {
                return this.Repository.GetOneLiquidacionDisputa_Mdte(ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDocsDisputaLiquidacion(Liquidacion Liquidacion)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    if (Liquidacion.VALIDADO == "RE")
                    {
                        RepositoryDocs_Workers_Rechazo.DeleteDocsWorkersRechazoLiquidacion_Mdte(Liquidacion.ID);
                        foreach (var item in Liquidacion.ListDocsTipoRechazo)
                        {
                            item.RUT = Liquidacion.RUT;
                            item.ID = Liquidacion.ID.GetValueOrDefault();
                            item.USUARIO = Liquidacion.USUARIO;
                            RepositoryDocs_Workers_Rechazo.InsertDocsWorkersRechazoLiquidacion_Mdte(item);
                        }
                    }
                    Repository.SaveDocsDisputaLiquidacion(Liquidacion);
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Liquidacion GetOneLiquidacionDisputaSendAlert_Mdte(int ID_DISPUTA)
        {
            try
            {
                return this.Repository.GetOneLiquidacionDisputaSendAlert_Mdte(ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Liquidacion> GetListLiquidacion_Mdte(ref Liquidacion liquidacionvalid) {
            try
            {
                return this.Repository.GetListLiquidacion_Mdte(ref liquidacionvalid);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveLiquidacionValidada_Mdte(ref Liquidacion items)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    this.Repository.SaveLiquidacionValidada_Mdte(ref items);
                    RepositoryDocs_Workers_Rechazo.DeleteDocsWorkersRechazoLiquidacion_Mdte(items.ID);
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveLiquidacionRechazada_Mdte(ref Liquidacion items) {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    RepositoryDocs_Workers_Rechazo.DeleteDocsWorkersRechazoLiquidacion_Mdte(items.ID);
                    foreach (var item in items.ListDocsRechazo.Where(var => var.CHECKED).ToList())
                    {
                        item.RUT = items.RUT;
                        item.ID = items.ID.GetValueOrDefault();
                        item.USUARIO = items.USUARIO;
                        RepositoryDocs_Workers_Rechazo.InsertDocsWorkersRechazoLiquidacion_Mdte(item);
                    }
                    Repository.SaveLiquidacionRechazada_Mdte(ref items);
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
