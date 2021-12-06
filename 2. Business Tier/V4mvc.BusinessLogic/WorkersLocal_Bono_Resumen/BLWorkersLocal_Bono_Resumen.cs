using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkersLocal_Bono_Resumen : IBLWorkersLocal_Bono_Resumen
    {

        #region [ Propiedades ]

        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAWorkersLocal_Bono_Resumen Repository { get; set; }

        #endregion

        #region [ Constructores ]

        public BLWorkersLocal_Bono_Resumen(IDAWorkersLocal_Bono_Resumen x_container)
        { Repository = x_container; }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<WorkersLocal_Bono_Resumen> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public WorkersLocal_Bono_Resumen GetOne(String RUT, String DIVISION, String EMPRESA)
        {
            try
            {
                return this.Repository.GetOne(RUT, DIVISION, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        public Boolean Save(ref WorkersLocal_Bono_Resumen Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean Save(ref ObservableCollection<WorkersLocal_Bono_Resumen> Items)
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
