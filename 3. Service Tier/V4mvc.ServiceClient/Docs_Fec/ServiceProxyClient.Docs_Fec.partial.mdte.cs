using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]

        public ObservableCollection<Docs_Fec> GetListFechasDocumentos_Mdte() {
            try
            {
                return this.BL_Docs_Fec.GetListFechasDocumentos_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs_Fec> GetAllDocsFecSelect_mdte()
        {
            try
            {
                return this.BL_Docs_Fec.GetAllDocsFecSelect_mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
