using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkers : IBLWorkers
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAWorkers Repository { get; set; }
        public IDALocal Local_Repository { get; set; }
        public IDAEnterprise Enterprise_Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLWorkers(IDAWorkers x_container, IDALocal y_container, IDAEnterprise a_container)
        {
            Repository = x_container;
            Local_Repository = y_container;
            Enterprise_Repository = a_container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Workers> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Workers GetOne(String RUT)
        {
            try
            {
                if (RUT == null) { return null; }
                return this.Repository.GetOne(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Workers Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Workers> Items)
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
