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
        public IBLA407_dotacion_docs_emp_2 BL_A407_dotacion_docs_emp_2 { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLA407_dotacion_docs_emp_2 BL_A407_dotacion_docs_emp_2)
        {
            this.BL_A407_dotacion_docs_emp_2 = BL_A407_dotacion_docs_emp_2;
        }
        #endregion

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        #endregion

    }
}