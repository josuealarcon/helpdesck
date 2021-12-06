using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
    public partial class ServiceProxyClient : IServiceProxyClient
    {

        #region [ Propiedades ]

        [Dependency]
        public IBLWorkersLocal_Bono_Resumen BL_WorkersLocal_Bono_Resumen { get; set; }

        #endregion

        #region [ Constructor]

        public ServiceProxyClient(IBLWorkersLocal_Bono_Resumen BL_WorkersLocal_Bono_Resumen)
        {
            this.BL_WorkersLocal_Bono_Resumen = BL_WorkersLocal_Bono_Resumen;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<WorkersLocal_Bono_Resumen> GetAllWorkersLocal_Bono_Resumen()
        {
            try
            {
                return this.BL_WorkersLocal_Bono_Resumen.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public WorkersLocal_Bono_Resumen GetOneWorkersLocal_Bono_Resumen(String RUT, String DIVISION, String EMPRESA)
        {
            try
            {
                return this.BL_WorkersLocal_Bono_Resumen.GetOne(RUT, DIVISION, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        public Boolean SaveWorkersLocal_Bono_Resumen(ref WorkersLocal_Bono_Resumen Item)
        {
            try
            {
                return this.BL_WorkersLocal_Bono_Resumen.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean SaveWorkersLocal_Bono_Resumen(ref ObservableCollection<WorkersLocal_Bono_Resumen> Items)
        {
            try
            {
                return this.BL_WorkersLocal_Bono_Resumen.Save(ref Items);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
