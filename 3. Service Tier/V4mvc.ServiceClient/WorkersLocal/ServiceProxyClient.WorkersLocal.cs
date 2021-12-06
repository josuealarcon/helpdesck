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
        public IBLWorkersLocal BL_WorkersLocal { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLWorkersLocal BL_WorkersLocal)
        {
            this.BL_WorkersLocal = BL_WorkersLocal;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<WorkersLocal> GetAllWorkersLocal()
        {
            try
            {
                return this.BL_WorkersLocal.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public WorkersLocal GetOneWorkersLocal(String RUT, String DIVISION, String EMPRESA)
        {
            try
            {
                return this.BL_WorkersLocal.GetOne(RUT, DIVISION, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean SaveWorkersLocal(ref WorkersLocal Item)
        {
            try
            {
                return this.BL_WorkersLocal.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean SaveWorkersLocal(ref ObservableCollection<WorkersLocal> Items)
        {
            try
            {
                return this.BL_WorkersLocal.Save(ref Items);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
