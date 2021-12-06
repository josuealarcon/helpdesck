using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLTab_TipoExsico : IBLTab_TipoExsico
    {

        #region [ Propiedades ]

        [Dependency]
        public IDATab_TipoExsico Repository { get; set; }

        #endregion

        #region [ Constructores ]

        public BLTab_TipoExsico(IDATab_TipoExsico x_container)
        { Repository = x_container; }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Tab_TipoExsico> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Tab_TipoExsico GetOne(Decimal ID)
        {
            try
            {
                return this.Repository.GetOne(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        public Boolean Save(ref Tab_TipoExsico Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean Save(ref ObservableCollection<Tab_TipoExsico> Items)
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
