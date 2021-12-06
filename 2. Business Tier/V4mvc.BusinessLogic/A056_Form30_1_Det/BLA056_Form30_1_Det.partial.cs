
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLA056_Form30_1_Det
    {
        #region [ Consultas ]
        public ObservableCollection<A056_Form30_1_Det> GetFormF30Detalles_ControlLaboralCtta(string EMPRESA, string ID_CERTIFICADO)
        {
            try
            {
                return Repository.GetFormF30Detalles_ControlLaboralCtta(EMPRESA, ID_CERTIFICADO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveFormF301Detail_ControlLaboralCtta(A056_Form30_1_Det model)
        {
            try
            {
                return Repository.SaveFormF301Detail_ControlLaboralCtta(model);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	