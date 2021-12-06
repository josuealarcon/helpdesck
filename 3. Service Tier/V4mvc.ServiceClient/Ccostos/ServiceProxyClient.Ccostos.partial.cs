using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<Ccostos> GetAllCcostosEnterpriseCtta(string EMPRESA)
        {
            try
            {
                return this.BL_Ccostos.GetAllCcostosEnterpriseCtta(EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Ccostos GetOneCcostoEnterpriseCtta(string EMPRESA, string CCOSTO)
        {
            try
            {
                return this.BL_Ccostos.GetOneCcostoEnterpriseCtta(EMPRESA, CCOSTO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Ccostos> GetCCostosSearcherCtta(ref Ccostos model)
        {
            try
            {
                return this.BL_Ccostos.GetCCostosSearcherCtta(ref  model);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Métodos ]

        public bool ValidateCcosto_Ctta(string IDEMPRESA, string CCOSTO)
        {
            try
            {
                return this.BL_Ccostos.ValidateCcosto_Ctta(IDEMPRESA, CCOSTO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean SaveCcostoEntepriseCtta(ref Ccostos Item)
        {
            try
            {
                return this.BL_Ccostos.SaveCcostoEntepriseCtta(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean SaveCcostoEntepriseCtta(ref ObservableCollection<Ccostos> Items)
        {
            try
            {
                return this.BL_Ccostos.SaveCcostoEntepriseCtta(ref Items);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
