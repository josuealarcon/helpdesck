using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLWC_SubMenu : IBLWC_SubMenu
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAWC_SubMenu Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLWC_SubMenu(IDAWC_SubMenu x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<WC_SubMenu> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public WC_SubMenu GetOne(Decimal CODSUBMENU)
        {
            try
            {
                return this.Repository.GetOne(CODSUBMENU);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref WC_SubMenu Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<WC_SubMenu> Items)
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
