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
    public partial class BLReqVal_Docs : IBLReqVal_Docs
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAReqVal_Docs Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLReqVal_Docs(IDAReqVal_Docs x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<ReqVal_Docs> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ReqVal_Docs GetOne()
        {
            try
            {
                return null;//this.Repository.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref ReqVal_Docs Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<ReqVal_Docs> Items)
        {
            try
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    this.Repository.Save(ref item);
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
