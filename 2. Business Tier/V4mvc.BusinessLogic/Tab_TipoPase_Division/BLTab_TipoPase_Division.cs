using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLTab_TipoPase_Division : IBLTab_TipoPase_Division
    {

        #region [ Propiedades ]

        [Dependency]
        public IDATab_TipoPase_Division Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLTab_TipoPase_Division(IDATab_TipoPase_Division x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Tab_TipoPase_Division> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Tab_TipoPase_Division GetOne(String TIPOPASE, String DIVISION)
        {
            try
            {
                if (TIPOPASE == null || DIVISION == null) { return null; }
                return this.Repository.GetOne(TIPOPASE, DIVISION);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Tab_TipoPase_Division Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Tab_TipoPase_Division> Items)
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
