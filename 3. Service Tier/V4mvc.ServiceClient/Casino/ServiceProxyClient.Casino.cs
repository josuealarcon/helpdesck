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
        public IBLCasino BL_Casino { get; set; }

        #endregion

        #region [ Constructor]

        public ServiceProxyClient(IBLCasino BL_Casino)
        {
            this.BL_Casino = BL_Casino;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Casino> GetAllCasino()
        {
            try
            {
                return this.BL_Casino.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Casino GetOneCasino()
        {
            try
            {
                return this.BL_Casino.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}