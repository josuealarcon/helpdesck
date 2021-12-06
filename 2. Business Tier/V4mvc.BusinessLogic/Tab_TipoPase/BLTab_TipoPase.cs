using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLTab_TipoPase : IBLTab_TipoPase
    {

        #region [ Propiedades ]

        [Dependency]
        public IDATab_TipoPase Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLTab_TipoPase(IDATab_TipoPase x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Tab_TipoPase> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Tab_TipoPase GetOne(Int16 ID_TIPOPASE)
        {
            try
            {
                return this.Repository.GetOne(ID_TIPOPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Tab_TipoPase Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Tab_TipoPase> Items)
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
