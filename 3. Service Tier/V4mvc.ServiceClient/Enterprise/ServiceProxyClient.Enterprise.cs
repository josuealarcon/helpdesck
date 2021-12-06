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
        public IBLEnterprise BL_Enterprise { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLEnterprise BL_Enterprise)
        {
            this.BL_Enterprise = BL_Enterprise;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Enterprise> GetAllEnterprise()
        {
            try
            {
                return this.BL_Enterprise.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Enterprise GetOneEnterprise(String IDEMPRESA)
        {
            try
            {
                return this.BL_Enterprise.GetOne(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean SaveEnterprise(ref Enterprise Item)
        {
            try
            {
                return this.BL_Enterprise.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean SaveEnterprise(ref ObservableCollection<Enterprise> Items)
        {
            try
            {
                return this.BL_Enterprise.Save(ref Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
