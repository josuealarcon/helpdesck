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

        public ObservableCollection<Polizas> GetPolizasPagoPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.GetPolizasPagoPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetPolizasDatatablePolizasCtta()
        {
            try
            {
                return this.BL_Polizas.GetPolizasDatatablePolizasCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetPolizasEditarDatatablePolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.GetPolizasEditarDatatablePolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetOstsubcComboPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.GetOstsubcComboPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Polizas> GetPolizasNominaDatatablePolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.GetPolizasNominaDatatablePolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas GetOnePolizaCargada(int IDDOC, string NROPOLIZA)
        {
            try
            {
                return this.BL_Polizas.GetOnePolizaCargada(IDDOC, NROPOLIZA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        public bool InsertPolizaEditarPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.InsertPolizaEditarPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeletePolizaEditarPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.DeletePolizaEditarPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas DeletePolizaPagoPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.DeletePolizaPagoPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas InsertPolizaDuplicarPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.InsertPolizaDuplicarPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Polizas InsertPolizaNominaTotalPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.InsertPolizaNominaTotalPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertPolizaPagoPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.InsertPolizaPagoPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertPolizaNominaPolizasCtta(Polizas Item)
        {
            try
            {
                return this.BL_Polizas.InsertPolizaNominaPolizasCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
