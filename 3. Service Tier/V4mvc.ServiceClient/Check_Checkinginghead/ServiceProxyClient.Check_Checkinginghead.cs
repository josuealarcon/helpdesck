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
        public IBLCheck_Checkinginghead BL_Check_Checkinginghead { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCheck_Checkinginghead BL_Check_Checkinginghead)
        {
            this.BL_Check_Checkinginghead = BL_Check_Checkinginghead;
        }
        #endregion

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        #endregion

    }
}