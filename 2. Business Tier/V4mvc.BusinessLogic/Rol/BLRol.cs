using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLRol : IBLRol
    {

        #region [ Propiedades ]

        [Dependency]
        public IDARol Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLRol(IDARol x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Rol> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Rol GetOne(Int32 ID_ROL)
        {
            try
            {
                return this.Repository.GetOne(ID_ROL);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Rol Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Rol> Items)
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
