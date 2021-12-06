using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        ObservableCollection<Ccostos> GetAllCcostosEnterpriseCtta(string EMPRESA);
        Ccostos GetOneCcostoEnterpriseCtta(string EMPRESA, string CCOSTO);
        ObservableCollection<Ccostos> GetCCostosSearcherCtta(ref Ccostos model);

        #endregion

        #region [ Metodos ]

        bool ValidateCcosto_Ctta(string IDEMPRESA, string CCOSTO);
        Boolean SaveCcostoEntepriseCtta(ref Ccostos Item);
        Boolean SaveCcostoEntepriseCtta(ref ObservableCollection<Ccostos> Items);

        #endregion

    }
}