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
    public partial class BLPolizas
    {

        #region [ Consultas ]
        public ObservableCollection<Polizas> GetPolizasDatatablePolizasCtta()
        {
            try
            {
                return this.Repository.GetPolizasDatatablePolizasCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetPolizasEditarDatatablePolizasCtta(Polizas request)
        {
            try
            {
                return this.Repository.GetPolizasEditarDatatablePolizasCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetOstsubcComboPolizasCtta(Polizas Item)
        {
            try
            {
                return this.Repository.GetOstsubcComboPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetPolizasNominaDatatablePolizasCtta(Polizas Item)
        {
            try
            {
                return this.Repository.GetPolizasNominaDatatablePolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetPolizasPagoPolizasCtta(Polizas Item)
        {
            try
            {
                return this.Repository.GetPolizasPagoPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas GetOnePolizaCargada(int IDDOC, string NROPOLIZA)
        {
            try
            {
                return this.Repository.GetOnePolizaCargada(IDDOC, NROPOLIZA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool InsertPolizaEditarPolizasCtta(Polizas Item)
        {
            try
            {
                return this.Repository.InsertPolizaEditarPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeletePolizaEditarPolizasCtta(Polizas Item)
        {
            try
            {
                return this.Repository.DeletePolizaEditarPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas DeletePolizaPagoPolizasCtta(Polizas Item)
        {
            try
            {
                return this.Repository.DeletePolizaPagoPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas InsertPolizaDuplicarPolizasCtta(Polizas Item)
        {
            try
            {
                Polizas data = new Polizas();
                using (TransactionScope tran = new TransactionScope())
                {
                    if (Item.RUTS_DUPLICARPOLIZA != null)
                    {
                        List<string> RUTS = Item.RUTS_DUPLICARPOLIZA.Split(',').ToList();
                        foreach (var RUT in RUTS)
                        {
                            var result = this.Repository.InsertPolizaNominaPolizasCtta(new Polizas() { IDDOC = Item.IDDOC, NROPOLIZA = Item.NROPOLIZA, RUT = RUT });
                        }
                    }
                    else
                    {
                        var result = this.Repository.InsertPolizaNominaPolizasCtta(new Polizas() { IDDOC = Item.IDDOC, NROPOLIZA = Item.NROPOLIZA, RUT = "" });
                    }

                    tran.Complete();
                }
                return data;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas InsertPolizaNominaTotalPolizasCtta(Polizas Item)
        {
            try
            {
                Polizas data = new Polizas();
                using (TransactionScope tran = new TransactionScope())
                {
                    this.Repository.DeletePolizaNominaPorNroPolizaPolizasCtta(Item);
                    List<string> RUTS = Item.RUTS_DUPLICARPOLIZA.Split(',').ToList();
                    List<string> RUT_CARGADOSOK = new List<string>();
                    foreach (var RUT in RUTS)
                    {
                        var result = this.Repository.InsertPolizaNominaPolizasCtta(new Polizas() { IDDOC = Item.IDDOC, NROPOLIZA = Item.NROPOLIZA, RUT = RUT });
                        if (result == true)
                        {
                            RUT_CARGADOSOK.Add(RUT);
                        }
                    }
                    data.EXITOSO = RUTS.Count() == RUT_CARGADOSOK.Count() ? true : false;
                    data.MENSAJE = RUTS.Count() == RUT_CARGADOSOK.Count() ? "OK" : "ALGUNAS NOMINAS NO SE INSERTARON";
                    tran.Complete();
                }
                return data;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertPolizaPagoPolizasCtta(Polizas Item)
        {
            try
            {
                    return this.Repository.InsertPolizaPagoPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertPolizaNominaPolizasCtta(Polizas Item)
        {
            try
            {
                return this.Repository.InsertPolizaNominaPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
