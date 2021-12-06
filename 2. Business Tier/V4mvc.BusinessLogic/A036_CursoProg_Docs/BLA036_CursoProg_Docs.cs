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
    public partial class BLA036_CursoProg_Docs : IBLA036_CursoProg_Docs
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAA036_CursoProg_Docs Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLA036_CursoProg_Docs(IDAA036_CursoProg_Docs x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<A036_CursoProg_Docs> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public A036_CursoProg_Docs GetOne(Guid Codigo)
        {
            try
            {
                return this.Repository.GetOne(Codigo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref A036_CursoProg_Docs Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<A036_CursoProg_Docs> Items)
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
