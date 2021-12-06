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
        public IBLReqVal_Docs BL_ReqVal_Docs { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLReqVal_Docs BL_ReqVal_Docs)
        {
            this.BL_ReqVal_Docs = BL_ReqVal_Docs;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<ReqVal_Docs> GetAllReqVal_Docs()
        {
            try
            {
                return this.BL_ReqVal_Docs.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ReqVal_Docs GetOneReqVal_Docs()
        {
            try
            {
                return null;//this.BL_ReqVal_Docs.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean SaveReqVal_Docs(ref ReqVal_Docs Item)
        {
            try
            {
                return this.BL_ReqVal_Docs.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean SaveReqVal_Docs(ref ObservableCollection<ReqVal_Docs> Items)
        {
            try
            {
                return this.BL_ReqVal_Docs.Save(ref Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
