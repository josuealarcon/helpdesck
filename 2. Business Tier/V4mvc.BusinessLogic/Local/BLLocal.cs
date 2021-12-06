using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLLocal : IBLLocal
    {

        #region [ Propiedades ]

        [Dependency]
        public IDALocal Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLLocal(IDALocal x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Local> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Local GetOne(String LOCAL, String EMPRESAL, String LOCALL)
        {
            try
            {
                if (LOCAL == null || EMPRESAL == null || LOCALL == null) { return null; }
                return this.Repository.GetOne(LOCAL, EMPRESAL, LOCALL);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Local Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Local> Items)
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
