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
        public IBLInformes_Certificacion BL_Informes_Certificacion { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLInformes_Certificacion BL_Informes_Certificacion)
        {
            this.BL_Informes_Certificacion = BL_Informes_Certificacion;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Informes_Certificacion> GetAllInformes_Certificacion(String DIVCOD)
        {
            try
            {
                return this.BL_Informes_Certificacion.GetAll(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Informes_Certificacion GetOneInformes_Certificacion()
        {
            try
            {
                return this.BL_Informes_Certificacion.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion

    }
}