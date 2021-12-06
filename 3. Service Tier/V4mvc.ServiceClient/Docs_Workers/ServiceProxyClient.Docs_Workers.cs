using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
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
        public IBLDocs_Workers BL_Docs_Workers { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Workers container)
        {
            this.BL_Docs_Workers = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Workers> GetAllDocs_Workers()
        {
            try
            {
                return this.BL_Docs_Workers.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_Workers GetOneDocs_Workers()
        {
            try
            {

                return this.BL_Docs_Workers.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean SaveDocs_Workers(ref Docs_Workers Item)
        {
            try
            {
                return this.BL_Docs_Workers.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean SaveDocs_Workers(ref ObservableCollection<Docs_Workers> Items)
        {
            try
            {
                return this.BL_Docs_Workers.Save(ref Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
