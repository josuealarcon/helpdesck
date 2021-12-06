using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLInformes_Certificacion : IBLInformes_Certificacion
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAInformes_Certificacion Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLInformes_Certificacion(IDAInformes_Certificacion x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Informes_Certificacion> GetAll(String DIVCOD)
        {
            try
            {
                return this.Repository.GetAll(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Informes_Certificacion GetOne()
        {
            try
            {
                return this.Repository.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion

    }
}
