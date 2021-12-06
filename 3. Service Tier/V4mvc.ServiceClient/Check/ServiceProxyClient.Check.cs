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
        public IBLCheck BL_Check { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCheck BL_Check)
        {
            this.BL_Check = BL_Check;
        }
        #endregion

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        #endregion

    }
}