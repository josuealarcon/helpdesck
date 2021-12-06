using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLEmpresascertificadoras
	{
        #region [ Consultas ]
        public ObservableCollection<Empresascertificadoras> GetListEmpresasCertificadoras_Mdte()
        {
            try
            {
                return this.Repository.GetListEmpresasCertificadoras_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
