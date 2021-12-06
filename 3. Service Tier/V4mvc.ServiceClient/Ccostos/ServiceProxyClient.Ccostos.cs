using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
    public partial class ServiceProxyClient : IServiceProxyClient
    {

        #region [ Propiedades ]

        [Dependency]
        public IBLCcostos BL_Ccostos { get; set; }

        #endregion

        #region [ Constructor]

        public ServiceProxyClient(IBLCcostos BL_Ccostos)
        {
            this.BL_Ccostos = BL_Ccostos;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Ccostos> GetAllCcostos()
        {
            try
            {
                return this.BL_Ccostos.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Ccostos GetOneCcostos(string EMPRESA, string CCOSTO)
        {
            try
            {
                return this.BL_Ccostos.GetOne(EMPRESA, CCOSTO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}