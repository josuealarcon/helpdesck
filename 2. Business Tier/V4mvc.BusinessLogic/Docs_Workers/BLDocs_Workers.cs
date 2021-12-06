using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_Workers : IBLDocs_Workers
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDADocs_Workers Repository { get; set; }
        public IDADocs_Tipo_Rechazo Repository_Docs_Tipo_Rechazo { get; set; }
        public IDADocs_Workers_Data Repository_Docs_Workers_Data { get; set; }
        #endregion

        #region [ Constructores ]
        public BLDocs_Workers(IDADocs_Workers x_container, IDADocs_Tipo_Rechazo x_container1, IDADocs_Workers_Data x_container2)
        {
            Repository = x_container;
            Repository_Docs_Tipo_Rechazo = x_container1;
            Repository_Docs_Workers_Data = x_container2;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Workers> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs_Workers GetOne()
        {
            try
            {

                return this.Repository.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Docs_Workers Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Docs_Workers> Items)
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
