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
        public IBLCTRLing BL_CTRLing { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCTRLing BL_CTRLing)
        {
            this.BL_CTRLing = BL_CTRLing;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<CTRLing> GetAllCTRLing(String DIVISIONES)
        {
            try
            {
                return this.BL_CTRLing.GetAll(DIVISIONES);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public CTRLing GetOneCTRLing()
        {
            try
            {
                return this.BL_CTRLing.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion

    }
}