using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {
        #region[ Consultas ]
        public ObservableCollection<Divisiones> GetListDivision_Mdte( string DIVISIONES)
        {
            try
            {
                return this.BL_Divisiones.GetListDivision_Mdte( DIVISIONES);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetListDivisiones_Mdte()
        {
            try
            {
                return this.BL_Divisiones.GetListDivisiones_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
