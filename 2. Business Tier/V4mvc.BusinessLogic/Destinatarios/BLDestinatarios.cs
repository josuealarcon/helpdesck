using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Unity;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLDestinatarios: IBLDestinatarios
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDADestinatarios Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLDestinatarios(IDADestinatarios x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Destinatarios> GetAll(String MODULO)
        {
            try
            {
                return this.Repository.GetAll(MODULO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Destinatarios GetOne(String MODULO)
        {
            try
            {
                if (MODULO == null) { return null; }
                return this.Repository.GetOne(MODULO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Destinatarios Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Destinatarios> Items)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        var item = Items.ElementAt(i);
                        this.Repository.Save(ref item);
                    }
                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
