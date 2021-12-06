
using System;
using System.Collections.ObjectModel;
using System.Linq;
using V4mvc.Entities;
using V4mvc.DataAccess;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLAdmin : IBLAdmin
    {
        #region [ Propiedades ]

        [Dependency]
        public IDAAdmin Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLAdmin(IDAAdmin x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Admin> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Admin GetOne(String ADMRUT)
        {
            try
            {
                if (ADMRUT == null) { return null; }
                return this.Repository.GetOne(ADMRUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Admin Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Admin> Items)
        {
            try
            {
                //using (TransactionScope tran = new TransactionScope())
                //{
                    for (int i = 0; i < Items.Count; i++)
                    {
                        var item = Items.ElementAt(i);
                        this.Repository.Save(ref item);
                    }
                    //tran.Complete();
                //}
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
