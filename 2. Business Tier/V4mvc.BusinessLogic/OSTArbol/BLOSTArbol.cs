using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLOSTArbol : IBLOSTArbol
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAOSTArbol Repository { get; set; }
        public IDAArchivos ArchivoRepository { get; set; }

        public IDADocs_OST2 RepositoryDocsOST2 { get; set; }

        #endregion

        #region [ Constructores ]
        public BLOSTArbol(IDAOSTArbol x_container, IDAArchivos y_container, IDADocs_OST2 z_container)
        { 
            Repository = x_container;
            ArchivoRepository = y_container;
            RepositoryDocsOST2 = z_container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<OSTArbol> GetAll(OSTArbol oSTArbol)
        {
            try
            {
                return this.Repository.GetAll(oSTArbol);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public OSTArbol GetOne(String OST, String MADRE, String EMPRESA)
        {
            try
            {
                if (OST == null || MADRE == null || EMPRESA == null) { return null; }
                return this.Repository.GetOne(OST, MADRE, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref OSTArbol Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<OSTArbol> Items)
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
