using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLOST : IBLOST
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAOST Repository { get; set; }
        public IDADocs_Formato RepositoryDocsFormato { get; set; }

        public IDAArchivos RepositoryArchivos { get; set; }
        #endregion

        #region [ Constructores ]
        public BLOST(IDAOST x_container, IDADocs_Formato y_container, IDAArchivos z_container)
        { 
            Repository = x_container;
            RepositoryDocsFormato = y_container;
            RepositoryArchivos = z_container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<OST> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public OST GetOne(String NROOST, String IDEMPRESA)
        {
            try
            {
                if (NROOST == null || IDEMPRESA == null) { return null; }
                return this.Repository.GetOne(NROOST, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref OST Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<OST> Items)
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
