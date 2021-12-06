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
        public IBLCTRLultimo BL_CTRLultimo { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLCTRLultimo BL_CTRLultimo)
        {
            this.BL_CTRLultimo = BL_CTRLultimo;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<CTRLultimo> GetAllCTRLultimo(String DIVISIONES)
        {
            try
            {
                return this.BL_CTRLultimo.GetAll(DIVISIONES);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public CTRLultimo GetOneCTRLultimo()
        {
            try
            {
                return this.BL_CTRLultimo.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion

    }
}