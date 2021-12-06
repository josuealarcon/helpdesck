using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLRoles : IBLRoles
    {

        #region [ Propiedades ]

        [Dependency]
        public IDARoles Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLRoles(IDARoles x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Roles> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Roles GetOne(String ROL, String AREA, String PROCESO, String SUBPROCESO)
        {
            try
            {
                if (ROL == null || AREA == null || PROCESO == null || SUBPROCESO == null) { return null; }
                return this.Repository.GetOne(ROL, AREA, PROCESO, SUBPROCESO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Roles Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Roles> Items)
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
