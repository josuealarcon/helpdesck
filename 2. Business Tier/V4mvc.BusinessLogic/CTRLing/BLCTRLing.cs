using System;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLCTRLing : IBLCTRLing
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDACTRLing Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLCTRLing(IDACTRLing x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<CTRLing> GetAll(String DIVISIONES)
        {
            try
            {
                return this.Repository.GetAll(DIVISIONES);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public CTRLing GetOne()
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
