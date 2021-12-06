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
    public partial class BLLotePases : IBLLotePases
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDALotePases Repository { get; set; }
        public IDALotePasesFun RepositoryLotePasesFun { get; set; }
        public IDALocal RepositoryLocal { get; set; }
        #endregion

        #region [ Constructores ]
        public BLLotePases(IDALotePases x_container, IDALotePasesFun x_container1, IDALocal l_container2)
        { Repository = x_container;
            RepositoryLotePasesFun = x_container1;
            RepositoryLocal = l_container2;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<LotePases> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePases GetOne()
        {
            try
            {
                return null;// this.Repository.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref LotePases Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<LotePases> Items)
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
