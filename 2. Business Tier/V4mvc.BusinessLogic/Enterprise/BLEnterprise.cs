using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLEnterprise : IBLEnterprise
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAEnterprise Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLEnterprise(IDAEnterprise x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Enterprise> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Enterprise GetOne(String IDEMPRESA)
        {
            try
            {
                if (IDEMPRESA == null) { return null; }
                return this.Repository.GetOne(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Enterprise Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Enterprise> Items)
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
