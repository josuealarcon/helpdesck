
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

		#region [ Consultas ]
		public ObservableCollection<A056_Form30_1_Det> GetFormF30Detalles_ControlLaboralCtta(string EMPRESA, string ID_CERTIFICADO)
        {
            try
            {
                return this.BL_A056_Form30_1_Det.GetFormF30Detalles_ControlLaboralCtta(EMPRESA, ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	