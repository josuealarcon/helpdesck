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
        public IBLDocs_Enterprise BL_Docs_Enterprise { get; set; }

        #endregion

        #region [ Constructor]

        public ServiceProxyClient(IBLDocs_Enterprise BL_Docs_Enterprise)
        {
            this.BL_Docs_Enterprise = BL_Docs_Enterprise;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Docs_Enterprise> GetAllDocs_Enterprise()
        {
            try
            {
                return this.BL_Docs_Enterprise.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs_Enterprise GetOneDocs_Enterprise()
        {
            try
            {
                return this.BL_Docs_Enterprise.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}