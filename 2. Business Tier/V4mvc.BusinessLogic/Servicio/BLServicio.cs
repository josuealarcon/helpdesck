using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLServicio : IBLServicio
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAServicio Repository { get; set; }

        #endregion

        #region [ Constructores ]

        public BLServicio(IDAServicio x_container)
        { Repository = x_container; }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Servicio> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Servicio GetOne(string SERVICIO)
        {
            try
            {
                return this.Repository.GetOne(SERVICIO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        public Boolean Save(ref Servicio Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean Save(ref ObservableCollection<Servicio> Items)
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
