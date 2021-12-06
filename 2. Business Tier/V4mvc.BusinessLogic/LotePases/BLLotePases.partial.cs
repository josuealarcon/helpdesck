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
	public partial class BLLotePases
	{

        #region [ Consultas ]

        public ObservableCollection<LotePases> GetAllLotePases_PasesCtta(string IDEMPRESA, bool ACTUAL)
        {
            try
            {
                return this.Repository.GetAllLotePases_PasesCtta(IDEMPRESA,ACTUAL);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<LotePases> GetLugaresVisita() {
            try
            {
                return this.Repository.GetLugaresVisita();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePases GetOneLotePases_PasesCtta(int LOTENUM)
        {
            try
            {
                return this.Repository.GetOneLotePases_PasesCtta(LOTENUM);
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion

        #region [ Metodos ]

        public bool SendPase_PasesCtta(ref LotePases modelo)
        {
            try
            {
                return this.Repository.SendPase_PasesCtta(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveLotePases_PasesCtta(string INS_OST, string INS_EMP, string INS_DIVCOD, string INS_FINICIO, string INS_FFINAL, string INS_TPASE, string INS_DESCRIP, string IDEMPRESA, string USUARIO, out int new_id)
        {
            try
            {
                return this.Repository.SaveLotePases_PasesCtta(INS_OST, INS_EMP, INS_DIVCOD, INS_FINICIO, INS_FFINAL, INS_TPASE, INS_DESCRIP, IDEMPRESA, USUARIO, out new_id);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveLotePases_PaseVisitaCtta(LotePases pase, out int NEW_ID)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    this.Repository.SaveLotePases_PaseVisitaCtta(pase, out NEW_ID);
                    foreach (var item in pase.funcionarios)
                    {
                        item.IDPASE = NEW_ID;
                        item.LOTEFINICIO = pase.LOTEFINICIO;
                        item.LOTEFFINAL = pase.LOTEFFINAL;
                        item.ID_EMPRESA = pase.IDEMPRESA;
                        item.LOTEFINICIO = pase.LOTEFINICIO;
                        item.LOTEFFINAL = pase.LOTEFFINAL;
                        this.RepositoryLotePasesFun.SaveLotePasesFun_PasesVisitaCtta(item);
                        if (item.LISTACASINOS != null) {
                            //delete
                            this.RepositoryLocal.DeleteLocalCasino_Ctta(item.RUTLOTE);
                            foreach (var itemCasinos in item.LISTACASINOS) {
                                if (itemCasinos.EXISTE==true)
                                {
                                    itemCasinos.RUT = item.RUTLOTE;
                                    itemCasinos.IDEMPRESA = pase.IDEMPRESA;
                                    this.RepositoryLocal.SaveLocalCasino_Ctta(itemCasinos);
                                    //añadir
                                }
                            }
                        }
                    }
                    if (pase.vehiculos!=null)
                    {
                        foreach (var item in pase.vehiculos)
                        {
                            item.IDPASE = NEW_ID;
                            item.ID_EMPRESA = pase.IDEMPRESA;
                            this.RepositoryLotePasesFun.SaveLotePasesFunV2_PasesVisitaCtta(item);
                        }
                    }
                    tran.Complete();
                }
                //return this.Repository.SaveLotePases_PaseVehicularCtta(pase, out NEW_ID);
                //var result;
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool SendPaseModelo_PasesCtta(ref LotePases modelo)
        {
            try
            {
                return this.Repository.SendPaseModelo_PasesCtta(ref modelo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
