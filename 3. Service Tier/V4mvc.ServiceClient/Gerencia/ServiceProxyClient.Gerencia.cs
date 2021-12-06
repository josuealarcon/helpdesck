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
        public IBLGerencia BL_Gerencia { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLGerencia BL_Gerencia)
        {
            this.BL_Gerencia = BL_Gerencia;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Gerencia> GetAllGerencia()
        {
            try
            {
                return this.BL_Gerencia.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Gerencia GetOneGerencia()
        {
            try
            {
                return this.BL_Gerencia.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion

    }
}