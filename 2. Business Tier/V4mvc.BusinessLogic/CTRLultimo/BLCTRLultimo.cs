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
    public partial class BLCTRLultimo : IBLCTRLultimo
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDACTRLultimo Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLCTRLultimo(IDACTRLultimo x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<CTRLultimo> GetAll(String DIVISIONES)
        {
            try
            {
                return this.Repository.GetAll(DIVISIONES);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public CTRLultimo GetOne()
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
